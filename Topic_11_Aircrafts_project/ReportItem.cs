using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_11_Aircrafts_project
{
    public class ReportItem
    {
        public string AircraftTailNumber { get; set; }
        public string ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public string OwnerCompanyName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyCounryName { get; set; }
        public bool BelongsToEU { get; set; }

        public ReportItem(string aircraftTailNumber, string modelNumber, string modelDescription, string ownerCompanyName, int companyCountryCode, string companyCountryName)
        {
            AircraftTailNumber = aircraftTailNumber;
            ModelNumber = modelNumber;
            ModelDescription = modelDescription;
            OwnerCompanyName = ownerCompanyName;
            CompanyCountryCode = companyCountryCode;
            CompanyCounryName = companyCountryCode;
            
        }

        public ReportItem ()
        {

        }

    }
}
