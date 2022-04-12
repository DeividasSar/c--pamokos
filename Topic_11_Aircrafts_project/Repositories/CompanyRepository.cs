using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topic_11_Aircrafts_project.Repositories
{
    public class CompanyRepository
    {
        private List<Company> companies { get; set; }

        public CompanyRepository ()
        {
            companies = new List<Company>();

            companies.Add(new Company(1, "Grand Enterprises O.L Ltd.", 1));
            companies.Add(new Company(2, "AV-EX AVIATION EXCELLENCE", 2));
            companies.Add(new Company(3, "AVIA TECHNIQUE LTD.", 3));
            companies.Add(new Company(4, "Aviall Services Inc.", 4));
            companies.Add(new Company(5, "Air Atlanta Aviaservices LIMITED", 5));
            companies.Add(new Company(6, "AVIATION EXCESS INC.", 6));
            companies.Add(new Company(7, "AVIATION GRAPHIX  LTD", 7));
            companies.Add(new Company(8, "AVIATION POWER INC.", 8));
            companies.Add(new Company(9, "AVIATION SUPPORT EUROPE", 9));
            companies.Add(new Company(10, "AVIATRONICS, INC.", 10));
            companies.Add(new Company(11, "AVIO-DIEPEN B.V.", 11));
            companies.Add(new Company(12, "AVION SYSTEMS, INC.", 12));
            companies.Add(new Company(13, "AVIONIK STRAUBING VERTRIEBS UND SERVICE", 13));
            companies.Add(new Company(14, "AVIOSERV SAN DIEGO, INC.", 14));
            companies.Add(new Company(15, "AVIOSUPPORT", 15));
            companies.Add(new Company(16, "Aircraft Support and Services, Inc.", 16));
            companies.Add(new Company(17, "BIAERO, LLC", 17));
            companies.Add(new Company(18, "BIC CARPETS", 18));
            companies.Add(new Company(19, "BIGGLES LABELLING LIMITED", 19));
            companies.Add(new Company(20, "BILL THOMAS ASSOCIATES, INC.", 20));
            companies.Add(new Company(21, "WILSON AVIATION SERVICES", 21));
            companies.Add(new Company(22, "BOMBARDIER AEROSPACE", 22));
            companies.Add(new Company(23, "BOTRON COMPANY INC.", 23));
            companies.Add(new Company(24, "BOURNEMOUTH AVIATION (CONSULTANTS) LTD.", 24));
            companies.Add(new Company(25, "Magnetic MRO AS", 25));
            companies.Add(new Company(26, "BP OIL INTERNATIONAL LTD", 26));
            companies.Add(new Company(27, "BRESLIN AEROTECH, LLC", 27));
            companies.Add(new Company(28, "BRIDGES NDT", 28));
            companies.Add(new Company(29, "BRIDGESTONE AIRCRAFT TIRE", 29));
            companies.Add(new Company(30, "BRITANNIA AIRWAYS", 30));

        }
        public List<Company> Retrieve()
        {
            return companies;
        }

        public Company RetrieveById(int id)
        {
            return companies.SingleOrDefault(x => x.Id == id);
        }
    }
}
