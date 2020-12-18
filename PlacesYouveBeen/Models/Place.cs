using System;
using System.Collections.Generic;

namespace PlacesYouveBeen.Models
{
    public class Place
    {
        public string _cityName { get; set; }
        public int _stayLength { get; set; }
        public string _journalEntry { get; set; }
        private static List<Place> _instances = new List<Place>() { };
        public int Id { get; }

        public Place(string cityName, int stayLength, string journalEntry)
        {
            _cityName = cityName;
            _stayLength = Convert.ToInt32(stayLength);
            _journalEntry = journalEntry;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Place Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}