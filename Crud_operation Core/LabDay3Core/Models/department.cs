using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LabDay3Core.Models
{
    public class department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string name { get; set; }
        public string loc { get; set; }
        public department()
        {
            Student = new List<student>();
        }
        public virtual List<student> Student { get; set; }
    }
}
