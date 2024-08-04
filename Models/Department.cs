using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2_DepDsgEmp_1147.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}