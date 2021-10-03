using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnionContactManagementSolution.Core.Interfaces;
using OnionContactManagementSolution.Core.Logging;
using OnionContactManagementSolution.WebAPI.Exception;

namespace OnionContactManagementSolution.WebAPI.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IContactOperations _contactOperations;
        ILoggerInterface _logging;
        public ValuesController(IContactOperations contactOperations, ILoggerInterface logger)
        {
            _contactOperations = contactOperations;
            _logging = logger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            IEnumerable<Core.Models.Contact> contacts = _contactOperations.GetContacts();
            if (contacts == null)
            {
                _logging.Info("No contact details found.");
                return BadRequest(HttpStatusCode.NotFound);
            }
            return Ok(contacts);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                Core.Models.Contact contact = _contactOperations.GetContactById(id);
                if (contact == null)
                {
                    _logging.Info("No contact details found.");
                    throw new HttpStatusCodeException(HttpStatusCode.NotFound, "No contact details found.");
                }
                return Ok(contact);
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
            
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Core.Models.Contact contact)
        {
            bool result = _contactOperations.CreateContact(contact);
            if (result)
            {
                _logging.Info("contact details are added to database.");
                return Ok(HttpStatusCode.Created);
            }
            return new ObjectResult(StatusCodes.Status500InternalServerError);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Core.Models.Contact contact)
        {
            bool result = _contactOperations.UpdateContact(id, contact);
            if (result)
            {
                _logging.Info("contact details are updated to database.");
                return Ok();
            }
            return new ObjectResult(StatusCodes.Status500InternalServerError);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool result = _contactOperations.DeactivateContact(id);
            if (result)
            {
                _logging.Info("Contact has deactivated.");
                return Ok();
            }
            return new ObjectResult(StatusCodes.Status500InternalServerError);
        }
    }
}