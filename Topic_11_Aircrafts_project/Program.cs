using System;

namespace Topic_11_Aircrafts_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var repGen = new ReportGenerator(new Repositories.AircraftRepository, new Repositories.AircraftModelRepository, new Repositories.CompanyRepository, new Repositories.CountryRepository);
            

            //var htmlFormatter = new
        }
    }
}
