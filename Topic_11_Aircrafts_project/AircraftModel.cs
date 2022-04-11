using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_11_Aircrafts_project
{
    public class AircraftModel
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }

        public AircraftModel (int id, string number, string description)
        {
            Id = id;
            Number = number;
            Description = description;
        }
    }
}
