using CustomerManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Services
{
    public class CarParkingService : ICarParkingService
    {
        private readonly ICarParkingRepository _repo;
        public CarParkingService()
        {
        }
    }
}
