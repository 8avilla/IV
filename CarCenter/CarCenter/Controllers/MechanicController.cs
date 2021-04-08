using CarCenter.Application.Interfaces;
using CarCenter.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCenter.Application.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MechanicController : ControllerBase
    {

        private readonly IMechanicServices _mechanicServices;

        public MechanicController(IMechanicServices mechanicServices)
        {
            _mechanicServices = mechanicServices;
        }

        [HttpGet]
        [Route("v1")]
        public ActionResult GetAll() => Ok(_mechanicServices.GetAll());

        [HttpPost]
        [Route("v1")]
        public ActionResult Create([FromBody] Mechanic mechanic) => Ok(_mechanicServices.Create(mechanic));

        [HttpPut]
        [Route("v1")]
        public ActionResult Set([FromBody] Mechanic mechanic) => Ok(_mechanicServices.Set(mechanic));

        [HttpDelete]
        [Route("v1/{documentType}/{documentNumber}")]
        public ActionResult Delete(string documentType, string documentNumber) => Ok(_mechanicServices.Delete(documentType, documentNumber));
    }
}
