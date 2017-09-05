using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Example_2908CodeToDb
{
    public class Dapartment
    {
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string AddURL { get; set; }
    }
}
