using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutbalVilleBlazor.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutbalVilleBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorLogsController : ControllerBase
    {
        private readonly ErrorLogService errorLogService;

        public ErrorLogsController(ErrorLogService errorLogService)
        {
            this.errorLogService = errorLogService;
        }

        [HttpGet]
        public ActionResult<List<ErrorLog>> Get() => errorLogService.Get();

        [HttpGet("{id:length(24)}", Name = "GetErrorLog")]
        public ActionResult<ErrorLog> Get(string id)
        {
            var error = errorLogService.Get(id);

            if (error == null)
                return NotFound();

            return error;
        }

        [HttpPost]
        public ActionResult<ErrorLog> Create(ErrorLog error)
        {
            errorLogService.Create(error);

            return CreatedAtRoute("GetErrorLog", new { id = error.Id.ToString() }, error);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, ErrorLog errorIn)
        {
            var error = errorLogService.Get(id);

            if (error == null)
                return NotFound();

            errorLogService.Update(id, errorIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var error = errorLogService.Get(id);

            if (error == null)
            {
                return NotFound();
            }

            errorLogService.Remove(error.Id);

            return NoContent();
        }
    }
}