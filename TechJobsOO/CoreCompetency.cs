﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency(string value) : base(value)
        {
        }
        /* // private int id;
        private static int nextId = 1;
        // private string value;

        // TODO: Change the fields to auto-implemented properties.
        public int Id { get; }
        public string Value { get; set; }
        
        public CoreCompetency()
        {
            Id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        } */
    }
    
}
