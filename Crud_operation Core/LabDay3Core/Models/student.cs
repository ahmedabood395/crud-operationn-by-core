using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabDay3Core.Models
{
    public class student
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        [ForeignKey("Department")]
        public int dept_id { get; set; }
        public virtual department Department { get; set; }
    }
}
