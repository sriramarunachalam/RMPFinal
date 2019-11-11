using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RmgAPI.Models;

namespace RmgAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RMGController : ControllerBase
    {
        private RMGdbContext db;

        public RMGController(RMGdbContext dbContext)
        {
            this.db = dbContext;
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpGet("requests")]
        public ActionResult<IEnumerable<ListOfRequests>> GetRequests() 
        {
            return db.listOfRequests.ToList(); 
           // Displays the List of Requests 
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpGet("requests/{role}")]
        public ActionResult<IEnumerable<ListOfRequests>> GetRequestsByRole(string role)
        {
            List<ListOfRequests> AccountList = new List<ListOfRequests>();
            AccountList = db.listOfRequests.Where(R => R.Role == role).ToList();
            return AccountList;
            // Displays the List of Requests 
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpGet("accounts")]
        public ActionResult<IEnumerable<Account>> GetAccounts() 
        {
            return db.accounts.ToList();
            // Displays the List of Accounts
        }


        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [HttpPost("accounts")]
        public async Task<ActionResult<Account>> AddAccountAsync([FromBody] Account account)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await db.accounts.AddAsync(account);
            await db.SaveChangesAsync();
            return Created("Account Created", account);
        }


        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [HttpPost("NewRequest")]
        public async Task<ActionResult<ListOfRequests>> AddRequestAsync([FromBody] ListOfRequests requests) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await db.listOfRequests.AddAsync(requests);
            await db.SaveChangesAsync();
            return Created("Request Succesfully Added", requests);
        }


        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [HttpPost("Employee")]
        public async Task<ActionResult<Employees>> AddEmployeeAsync([FromBody] Employees employees) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await db.Employees.AddAsync(employees);
            await db.SaveChangesAsync();
            return Created("Employee Succesfully Added", employees);

        }


        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpGet("Employees")]
        public ActionResult<IEnumerable<Employees>> GetAllEmployees() 
        {
            return db.Employees.ToList();
        }

        [ProducesResponseType((int)HttpStatusCode.OK)]
        [HttpGet("Employees/{RequestId}")]
        public ActionResult<IEnumerable<Employees>> GetEmployeesbyRequestID(int RequestId)
        {
            List<Employees> EmployeesList = new List<Employees>();
            EmployeesList = db.Employees.Where(E => E.RequestID == RequestId).ToList();
            return EmployeesList;
        }

    }
}