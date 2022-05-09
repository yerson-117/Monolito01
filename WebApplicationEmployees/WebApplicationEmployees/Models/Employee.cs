﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEmployees.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre Empleado")]
        public string Name { get; set; }
        [Display(Name = "Cargo")]
        public string Designation { get; set; }
        [DataType(DataType.MultilineText)]
        public string Adress { get; set; }
        public DateTime? RecordCreation { get; set; }




    }
}
