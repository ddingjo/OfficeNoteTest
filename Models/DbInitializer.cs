using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeNote.Models
{
    public class DbInitializer
    {
        public static void Initialize(OfficeNoteDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            //if (context.Tests.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //var tests = new Test[]
            //{
            //    new Test{ Name = "name"},
            //    new Test{ Name = "sugjo"},
            //};
            //foreach (Test s in tests)
            //{
            //    context.Tests.Add(s);
            //}
            //context.SaveChanges();
            
        }
    }
}
