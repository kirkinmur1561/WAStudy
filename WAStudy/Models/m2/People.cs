using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAStudy.Models.m2
{
    public static class People
    {
        private const int OffMinute = 20;
        private static readonly List<Person> _person = new List<Person>();
       

        /// <summary>
        /// Append user in collection
        /// </summary>       
        public static void AddPerson(Person person) =>
            _person.Add(person);

        /// <summary>
        /// Trying to update time for user
        /// </summary>
        /// <param name="key">key from cookie</param>
        /// <returns>If not found person or not passed Check return false else true</returns>
        public static async Task<bool> UpdatePerson(string key)
        {
            Person? person = _person.FirstOrDefault(f => f.Key == key);
       
            if (person == null || !Check(key)) return false;
            person.LastEnter = DateTime.Now;
            return true;
        }

        /// <summary>
        /// Is expiration of token to person
        /// </summary>
        /// <param name="key">key from cookie</param>
        /// <returns>if not found key or time out (const 20 min) for token return false, else true</returns>
        public static bool Check(string key)
        {
            Person? person = _person.FirstOrDefault(f => f.Key == key);
            if (person == null) return false;
            return (DateTime.Now - person.LastEnter).TotalMinutes < OffMinute;
        }

        /// <summary>
        /// Delete user from collection
        /// </summary>
        /// <param name="key">key from cookie</param>
        /// <returns>if found key and managed to delete return true else false</returns>
        public static bool Remove(string key)
        {
            Person? person = _person.FirstOrDefault(f => f.Key == key);
            return person != null && _person.Remove(person);
        }
            
    }
}