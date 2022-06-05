using Restaurant.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Repositories.Entites
{
    public class Table
    {
    public decimal Number { get; set; }
    public decimal Seats { get; set; }
    public string FreeOrTaken { get; set; }

        public Table (string[] item)
        {
            Number = Convert.ToDecimal(item[0]);
            Seats = Convert.ToDecimal(item[1]);
            FreeOrTaken = item[2];
        }
        
    }
}
