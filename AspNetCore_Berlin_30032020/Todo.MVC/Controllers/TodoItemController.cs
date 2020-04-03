using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Todo.Domain.Entities;

namespace Todo.MVC.Controllers
{
    public class TodoItemController : Controller
    {
        public TodoItemController()
        {
        }

        
        // GET: TodoItem
        public async Task<IActionResult> Index()
        {
            List<TodoItem> todoItems = null;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44325/api/TodoItem"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    todoItems = JsonConvert.DeserializeObject<List<TodoItem>>(apiResponse);
                }
            }

            if (todoItems == null)
            {
                //Error Page
            }

            return View(todoItems);
        }

        // GET: TodoItem/Details/5
        public async Task<IActionResult> Details(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            TodoItem todoItem = null;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44325/api/TodoItem/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    todoItem = JsonConvert.DeserializeObject<TodoItem>(apiResponse);
                }
            }

            if (todoItem == null)
            {
                return NotFound();
            }

            return View(todoItem);
        }

        #region Create
        // GET: TodoItem/Create
        public IActionResult Create()
        {
            return View();
        }
        
        // POST: TodoItem/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,IsComplete")] TodoItem todoItem)
        {
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(todoItem);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var url = "https://localhost:44325/api/TodoItem";
                using var client = new HttpClient();

                var response = await client.PostAsync(url, data);

                string result = response.Content.ReadAsStringAsync().Result;

                return RedirectToAction(nameof(Index));
            }
            return View(todoItem);
        }
        #endregion

        #region
        // GET: TodoItem/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TodoItem todoItem = null;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44325/api/TodoItem/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    todoItem = JsonConvert.DeserializeObject<TodoItem>(apiResponse);
                }
            }

            if (todoItem == null)
            {
                return NotFound();
            }

            return View(todoItem);
        }

        // POST: TodoItem/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,IsComplete")] TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var json = JsonConvert.SerializeObject(todoItem);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    var url = "https://localhost:44325/api/TodoItem/" + todoItem.Id;
                    using var client = new HttpClient();

                    var response = await client.PutAsync(url, data); //api/Aufgabens/5

                    string result = response.Content.ReadAsStringAsync().Result;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoItemExists(todoItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(todoItem);
        }
        #endregion

        #region Delete
        // GET: TodoItem/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TodoItem todoItem = null;
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44325/api/TodoItem/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    todoItem = JsonConvert.DeserializeObject<TodoItem>(apiResponse);
                }
            }

            if (todoItem == null)
            {
                return NotFound();
            }

            return View(todoItem);
        }

        // POST: TodoItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            //var todoItem = await _context.TodoItem.FindAsync(id);
            //_context.TodoItem.Remove(todoItem);
            //await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        #endregion
        private bool TodoItemExists(long id)
        {
            //return _context.TodoItem.Any(e => e.Id == id);
            return true; // Mock
        }
    }
}
