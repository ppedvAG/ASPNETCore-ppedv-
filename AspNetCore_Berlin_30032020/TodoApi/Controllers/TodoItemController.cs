using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

using TodoApi.Data;
using TodoApi.Parameters;
using Todo.Domain.Entities;
using Todo.Infrastructure.Http.OpenApi.Pagging;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly TodoDBContext _context;

        public TodoItemController(TodoDBContext context)
        {
            _context = context;
        }



        #region Get-Methode

        //GET: api/TodoItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItem()
        {
            return await _context.TodoItem.ToListAsync();
        }

        // GET: api/TodoItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            var todoItem = await _context.TodoItem.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        #region Paging
        ////https://localhost:44325/api/ToDoItem?PageSize=2
        //[HttpGet]
        //public ActionResult GetTodoItem([FromQuery] TodoItemParameter todoItemParameter)
        //{
        //    IQueryable<TodoItem> allOpenTodoItems = _context.TodoItem.Where(n => n.IsComplete == todoItemParameter.IsComplete).AsQueryable();

        //    PagedList<TodoItem> pagedList = PagedList<TodoItem>.ToPagedList(allOpenTodoItems,
        //        todoItemParameter.PageNumber,
        //        todoItemParameter.PageSize);


        //    return Ok(pagedList);
        //}
        //public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItem([FromQuery] TodoItemParameter todoItemParameter)
        //{
        //    return await _context.TodoItem.Where(n => n.Name.Contains(todoItemParameter.Name) && n.IsComplete == todoItemParameter.IsComplete).ToListAsync();
        //}
        #endregion

        #endregion


        // PUT: api/TodoItem/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItem
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            
            _context.TodoItem.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItem/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TodoItem>> DeleteTodoItem(long id)
        {
            var todoItem = await _context.TodoItem.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItem.Remove(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }

        private bool TodoItemExists(long id)
        {
            return _context.TodoItem.Any(e => e.Id == id);
        }
    }
}
