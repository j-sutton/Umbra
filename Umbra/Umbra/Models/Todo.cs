using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Umbra.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public DateTime Date { get; set; }
        public bool Completed { get; set; }
    }
}
