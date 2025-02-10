using RegionalTaxi.Domain.Abstraction;
using RegionalTaxi.Domain.Models.CarModel.Proporties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionalTaxi.Domain.Models.CarModel
{
    public sealed class Cars:Entity
    {
        private Cars(Guid Id , CarDTO carDTO):base(Id)
        {
            car_class = carDTO.classes;
            car_name = carDTO.name;
            car_model = carDTO.model;
            car_condition = carDTO.condition;
            car_number = carDTO.CarNumber;                     
        }
        public car_model car_model { get; set; }
        public car_name car_name { get; set; }
        public car_condition car_condition { get; set; }
        public car_class car_class { get; set; }
        public car_number car_number { get; set; }

        public static Cars CreateCar(Guid Id , CarDTO carDTO)
        {
            return new Cars(Id , carDTO);
        }
    }
}
