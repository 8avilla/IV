using CarCenter.Application.Interfaces;
using CarCenter.Domain.Entities;
using CarCenter.Infrastructure.Persistence.Interfaces;
using System;
using System.Collections.Generic;

namespace CarCenter.Application.Services
{
    public class MechanicServices : IMechanicServices
    {
        public readonly IMechanicRepository _mechanicRepository;
        public MechanicServices(IMechanicRepository mechanicRepository) => _mechanicRepository = mechanicRepository;
        public Mechanic Create(Mechanic mechanic)
        {
            return _mechanicRepository.Create(mechanic);
        }

        public bool Delete(string documentType, string documentNumber)
        {
            return _mechanicRepository.Delete(documentType, documentNumber);
        }

        public List<Mechanic> GetAll()
        {
            return _mechanicRepository.GetAll();
        }

        public Mechanic Set(Mechanic mechanic)
        {
            return _mechanicRepository.Set(mechanic);
        }
    }
}
