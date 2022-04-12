using System;
using System.Collections.Generic;
using System.Text;
using Topic_11_Aircrafts_project.Repositories;

namespace Topic_11_Aircrafts_project
{
    public class ReportGenerator
    {
        private AircraftRepository AircraftRepository { get; set; }
        private AircraftModelRepository AircraftModelRepository { get; set; }
        private CompanyRepository CompanyRepository { get; set; }
        private CountryRepository CountryRepository { get; set; }

        public ReportGenerator () { }
        public ReportGenerator (AircraftRepository aircraftRepository, AircraftModelRepository aircraftModelRepository, CompanyRepository companyRepository, CountryRepository countryRepository)
        {
            AircraftRepository = aircraftRepository;
            AircraftModelRepository = aircraftModelRepository;
            CompanyRepository = companyRepository;
            CountryRepository = countryRepository;
        }
       
        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            var EUAircrafts = new List<ReportItem>();
            var allAircrafts = AircraftRepository.Retrieve();
            foreach (var aircraft in allAircrafts)
            {
                var companyId = aircraft.CompanyId;
                var modelId = aircraft.ModelId;
                var model = AircraftModelRepository.RetrieveById(modelId);
                var company = CompanyRepository.RetrieveById(companyId);
                var country = CountryRepository.RetrieveById(company.CountryId);

                if (country.BelongsToEU)
                {
                    EUAircrafts.Add(new ReportItem(aircraft.TailNumber, model.Number, model.Description, company.Name, country.Code, country.Name));
                }

            }
            return EUAircrafts;
        

    }
}
