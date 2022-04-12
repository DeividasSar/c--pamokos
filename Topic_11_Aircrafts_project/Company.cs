using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_11_Aircrafts_project
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public object Country { get; internal set; }

        public Company (int id, string name, int countryId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
        }
    }
}
