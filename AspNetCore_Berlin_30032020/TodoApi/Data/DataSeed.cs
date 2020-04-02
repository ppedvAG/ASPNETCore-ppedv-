using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace TodoApi.Data
{
    public static class DataSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoDBContext(serviceProvider.GetRequiredService<DbContextOptions<TodoDBContext>>()))
            {
                //Existieren Datensätze in der Tabelle TodoItem
                if (context.TodoItem.Any())
                {
                    //wenn ja, wird return aufgerufen und weitere Testdaten werden nicht hinzugefügt
                    return;
                }

                context.TodoItem.AddRange(
                    new TodoItem
                    {
                        IsComplete = false,
                        Name = "Einkaufen gehen"
                    },
                    new TodoItem
                    {
                        IsComplete = true,
                        Name = "Gassi gehen"
                    },
                    new TodoItem
                    {
                        IsComplete = false,
                        Name = "Essen  kochen"
                    });


                context.SaveChanges();

            }
        }
    }
}
