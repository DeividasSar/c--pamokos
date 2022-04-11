using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topic_11_Aircrafts_project.Repositories
{
    public class AircraftRepository
    {
        private List<Aircraft> aircrafts { get; set;}
       
        public AircraftRepository()
        {
            aircrafts = new List<Aircraft>();

            aircrafts.Add(new Aircraft(1, 19, 1, "LY-SPH"));
            aircrafts.Add(new Aircraft(2, 18, 2, "VQ-BSB"));
            aircrafts.Add(new Aircraft(3, 17, 3, "VQ-BSA"));
            aircrafts.Add(new Aircraft(4, 16, 4, "EI-FDL(EX.TC-KLA)"));
            aircrafts.Add(new Aircraft(5, 15, 5, "UR-CKB"));
            aircrafts.Add(new Aircraft(6, 14, 6, "PK-BBS"));
            aircrafts.Add(new Aircraft(7, 13, 7, "PK-BBY"));
            aircrafts.Add(new Aircraft(8, 12, 8, "PK-BBB"));
            aircrafts.Add(new Aircraft(9, 11, 9, "TC-KLA"));
            aircrafts.Add(new Aircraft(10, 10, 10, "EI-FDM"));
            aircrafts.Add(new Aircraft(11, 9, 11, "EI-ETJ"));
            aircrafts.Add(new Aircraft(12, 8, 12, "EI-ETH"));
            aircrafts.Add(new Aircraft(13, 7, 13, "EI-ETK"));
            aircrafts.Add(new Aircraft(14, 6, 14, "EI-ETL"));
            aircrafts.Add(new Aircraft(15, 5, 15, "EI-FBV"));
            aircrafts.Add(new Aircraft(16, 4, 16, "EI-FBF"));
            aircrafts.Add(new Aircraft(17, 3, 17, "EI-FBH"));
            aircrafts.Add(new Aircraft(18, 2, 18, "LY-FLH"));
            aircrafts.Add(new Aircraft(19, 1, 19, "LY-SPA"));
        }
        public List<Aircraft> Retrieve()
        {
            return aircrafts;
        }

        public Aircraft RetrieveById(int id)
        {
            return aircrafts.SingleOrDefault(x => x.Id == id);
        }

      
       
    }
}
