using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RmgAPI.Models;

namespace RmgAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnBeanchCompetancyController : ControllerBase
    {
        private readonly RMGdbContext _context;

        public OnBeanchCompetancyController(RMGdbContext context)
        {
            _context = context;
        }

        // GET: api/Competancy
        [HttpGet("Getemployee")]
        public IEnumerable<Employees> GetEmployees_1()
        {
            var onBench = from s in _context.Employees
                          where s.CurrentProject == "OnBeanch"
                          select s;
            return onBench;
        }
    }
}