using CarCenter.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CarCenter.Application.Interfaces
{
    public interface IMechanicServices
    {
        public List<Mechanic> GetAll();
        public Mechanic Create(Mechanic mechanic);
        public Mechanic Set(Mechanic mechanic);
        public bool Delete(string documentType, string documentNumber);

    }
}
