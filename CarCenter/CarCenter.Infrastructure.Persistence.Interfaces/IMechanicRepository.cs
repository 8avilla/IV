using CarCenter.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CarCenter.Infrastructure.Persistence.Interfaces
{
    public interface IMechanicRepository
    {
        public List<Mechanic> GetAll();
        public Mechanic Create(Mechanic mechanic);
        public Mechanic Set(Mechanic mechanic);
        public bool Delete(string documentType, string documentNumber);
    }
}
