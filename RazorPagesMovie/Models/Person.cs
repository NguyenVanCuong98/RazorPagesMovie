using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string PersonName { get; set; }
    }
}
