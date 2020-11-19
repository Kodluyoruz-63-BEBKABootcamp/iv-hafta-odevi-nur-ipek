using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormExample.Models
{
    public class Class
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
