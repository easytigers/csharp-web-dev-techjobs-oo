using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //Test the Empty Constructor
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job(); //create 2 job objects
            Job job2 = new Job();

            Assert.AreEqual(job1.Id, job2.Id,1); // test 2 values not same & differ by 1
        }

        //Test the Full Constructor - Job object contains 6 properties
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job.Name, "Product tester");
            Assert.AreEqual(job.EmployerName.Value, "ACME");
            Assert.AreEqual(job.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job.JobType.Value, "Quality control");
            Assert.AreEqual(job.JobCoreCompetency.Value, "Persistence");
        }

        //Test the Equals() Method - same id = same object
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id.Equals(job2.Id)); // job1 Id differs from job2 Id
        }

        //Test for ToString()
        [TestMethod]
        public void ToStringTest()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string jobString = job.ToString();
            char firstChar = jobString[0];
            char lastChar = jobString[jobString.Length - 1];

            Assert.IsTrue(firstChar == '\n');
            Assert.IsTrue(lastChar == '\n');

            //Second Test for ToString()
            Assert.AreEqual(jobString, 
                $"\nID: {job.Id}\n" +
                $"Name: {job.Name}\n" +
                $"Employer: {job.EmployerName.Value}\n" +
                $"Location: {job.EmployerLocation.Value}\n" +
                $"Position Type: {job.JobType.Value}\n" +
                $"Core Competency: {job.JobCoreCompetency.Value}\n");
        }

        //Test "Data not available"
        [TestMethod]
        public void EmptyToStringTest()
        {
            Job job = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string jobString = job.ToString();

            Assert.AreEqual(jobString,
                $"\nID: {job.Id}\n" +
                $"Name: Data not available\n" +
                $"Employer: Data not available\n" +
                $"Location: Data not available\n" +
                $"Position Type: Data not available\n" +
                $"Core Competency: Data not available\n");

        }
    }
}
