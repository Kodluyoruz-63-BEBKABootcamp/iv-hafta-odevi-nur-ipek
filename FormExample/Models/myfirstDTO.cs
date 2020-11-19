using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormExample.Models
{
    public class myfirstDTO
    {
        public Student Student { get; set; }
        public Class Class { get; set; }
        public IEnumerable<Class> Classes { get; set; }
    }
}
