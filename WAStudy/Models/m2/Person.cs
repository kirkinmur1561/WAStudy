using System;

namespace WAStudy.Models.m2
{
    public class Person
    {
        public readonly string Key;
        public DateTime LastEnter;

        public Person()
        {
            
        }

        public Person(string key, DateTime lastEnter)
        {
            Key = key;
            LastEnter = lastEnter;
        }
        
        
    }
}