using AutoMapper;
using CarCenter.Domain.Entities;
using CarCenter.Infrastructure.Persistence.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace CarCenter.Infrastructure.Persistence.Repository
{
    public class MechanicRepository : IMechanicRepository
    {
        private readonly IMapper _mapper;
        private string connection;
        //private string connection = "Data Source=DESKTOP-LK3D7VR\\MSSQLSERVER2019;Initial Catalog=prueba;User Id=sa;Password=Amaranto1;";
        private readonly IConfiguration _configuration;

        public MechanicRepository(IMapper mapper, IConfiguration configuration) { 
            _mapper = mapper;
            _configuration = configuration;
        }
        public Mechanic Create(Mechanic mechanic)
        {
            using (var db = new SqlConnection(_configuration.GetConnectionString("dbprueba")))
            {
                var mechanicPersistence = _mapper.Map<Persistence.Entities.Mechanic>(mechanic);

                var jj = (int)mechanic.Status;
                char c = Convert.ToChar(jj);

                var procedure = "[MecanicosMaster]";
                var values = new
                {
                    StatementType = "Insert",
                    tipo_documento = mechanicPersistence.tipo_documento,
                    documento = mechanicPersistence.tipo_documento,
                    primer_nombre = mechanicPersistence.primer_nombre,
                    segundo_nombre = mechanicPersistence.segundo_nombre,
                    primer_apellido = mechanicPersistence.primer_apellido,
                    segundo_apellido = mechanicPersistence.segundo_apellido,
                    email = mechanicPersistence.email,
                    direccion = mechanicPersistence.direccion,
                    celular = mechanicPersistence.celular,
                    estado = (int)mechanic.Status
                };
                var results = db.Query<Persistence.Entities.Mechanic>(procedure, values, commandType: CommandType.StoredProcedure);

                return _mapper.Map<Mechanic>(results.First());
            }
        }

        public bool Delete(string documentType, string documentNumber)
        {
            using (var db = new SqlConnection(_configuration.GetConnectionString("dbprueba")))
            {
                var procedure = "[MecanicosMaster]";
                var values = new { StatementType = "Delete", 
                    tipo_documento = documentType, 
                    documento = documentNumber, 
                    primer_nombre = "" };
                var results = db.Query(procedure, values, commandType: CommandType.StoredProcedure).ToList();
            }
            
            return true;
        }

        public List<Mechanic> GetAll()
        {
            using (var db = new SqlConnection(_configuration.GetConnectionString("dbprueba")))
            {
                string sql = "SELECT * FROM Mecanicos";
                return _mapper.Map<List<Mechanic>>(db.Query<Persistence.Entities.Mechanic>(sql));
            }
        }

        public Mechanic Set(Mechanic mechanic)
        {
            using (var db = new SqlConnection(_configuration.GetConnectionString("dbprueba")))
            {
                var mechanicPersistence = _mapper.Map<Persistence.Entities.Mechanic>(mechanic);

                var jj = (int)mechanic.Status;
                char c = Convert.ToChar(jj);

                var procedure = "[MecanicosMaster]";
                var values = new
                {
                    StatementType = "Update",
                    tipo_documento = mechanicPersistence.tipo_documento,
                    documento = mechanicPersistence.tipo_documento,
                    primer_nombre = mechanicPersistence.primer_nombre,
                    segundo_nombre = mechanicPersistence.segundo_nombre,
                    primer_apellido = mechanicPersistence.primer_apellido,
                    segundo_apellido = mechanicPersistence.segundo_apellido,
                    email = mechanicPersistence.email,
                    direccion = mechanicPersistence.direccion,
                    celular = mechanicPersistence.celular,
                    estado = (int)mechanic.Status
                };
                var results = db.Query<Persistence.Entities.Mechanic>(procedure, values, commandType: CommandType.StoredProcedure);

                return _mapper.Map<Mechanic>(results.First());
            }
        }
    }
}
