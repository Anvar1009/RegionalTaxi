using RegionalTaxi.Domain.Models.CarModel.Proporties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionalTaxi.Domain.Models.CarModel
{
    public class CarDTO
    {
        public car_model model { get; set; }
        public car_name name { get; set; }
        public car_condition condition { get; set; }
        public car_class classes { get; set; }
        public car_number CarNumber { get; set; }
    }
}
