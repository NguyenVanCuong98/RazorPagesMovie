using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Lecture
    {
        [Key]
        public int Lecture_ID { get; set; }
        public string Lecture_Name { get; set; }
    }
}
