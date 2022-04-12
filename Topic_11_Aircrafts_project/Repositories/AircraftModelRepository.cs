using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topic_11_Aircrafts_project.Repositories
{
    public class AircraftModelRepository
    {
        private List<AircraftModel> aircraftModels { get; set; }
        
        public AircraftModelRepository()
        {
            aircraftModels = new List<AircraftModel>();

            aircraftModels.Add(new AircraftModel(1, "B737-300", "BOEING 737-300"));
            aircraftModels.Add(new AircraftModel(2, "B737-300", "BOEING 737-300"));
            aircraftModels.Add(new AircraftModel(3, "B737-400", "BOEING 737-400"));
            aircraftModels.Add(new AircraftModel(4, "B737-500", "BOEING 737-500"));
            aircraftModels.Add(new AircraftModel(5, "B737-700", "BOEING 737-700 "));
            aircraftModels.Add(new AircraftModel(6, "B737-800", "BOEING 737-800"));
            aircraftModels.Add(new AircraftModel(7, "A320", "AIRBUS A320"));
            aircraftModels.Add(new AircraftModel(8, "A321", "AIRBUS A321"));
            aircraftModels.Add(new AircraftModel(9, "CRJ200", "Bombardier CRJ200"));
            aircraftModels.Add(new AircraftModel(10, "ATR42-300", "ATR 42-300"));
            aircraftModels.Add(new AircraftModel(11, "B737-300-1", "BOEING 737-300-1"));
            aircraftModels.Add(new AircraftModel(12, "B737-300-1", "BOEING 737-300-1"));
            aircraftModels.Add(new AircraftModel(14, "B737-400-1", "BOEING 737-400-1"));
            aircraftModels.Add(new AircraftModel(15, "B737-500-4", "BOEING 737-500-4"));
            aircraftModels.Add(new AircraftModel(16, "B737-700-2", "BOEING 737-700 -2"));
            aircraftModels.Add(new AircraftModel(17, "B737-800-5", "BOEING 737-800"));
            aircraftModels.Add(new AircraftModel(18, "A320025", "AIRBUS A320-2"));
            aircraftModels.Add(new AircraftModel(19, "A321255", "AIRBUS A32-2"));

        }
        public List<AircraftModel> Retrieve()
        {
            return aircraftModels;
        }

        public AircraftModel RetrieveById(int id)
        {
            return aircraftModels.SingleOrDefault(x => x.Id == id);
        }

    }
}
