using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutbalVilleWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutbalVilleWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoService todoService;

        public ToDoController(ToDoService todoService)
        {
            this.todoService = todoService;
        }

        [HttpGet]
        public ActionResult<List<ToDoItem>> Get() => todoService.Get();

        [HttpGet("{id:length(24)}", Name = "GetToDoItem")]
        public ActionResult<ToDoItem> Get(string id)
        {
            var item = todoService.Get(id);

            if (item == null)
                return NotFound();

            return item;
        }

        [HttpPost]
        public ActionResult<ToDoItem> Create(ToDoItem item)
        {
            todoService.Create(item);

            return CreatedAtRoute("GetToDoItem", new { id = item.Id.ToString() }, item);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, ToDoItem itemIn)
        {
            var item = todoService.Get(id);

            if (item == null)
                return NotFound();

            todoService.Update(id, itemIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var item = todoService.Get(id);

            if (item == null)
            {
                return NotFound();
            }

            todoService.Remove(item.Id);

            return NoContent();
        }
    }
}