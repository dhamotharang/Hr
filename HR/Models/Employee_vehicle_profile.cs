﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HR.Models.Infra;
namespace HR.Models
{
    public class Employee_vehicle_profile
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Employee No.")]
        public string Employee_ProfileId { get; set; }
        public virtual Employee_Profile Employee_Profile { get; set; }
        [Required]
        [Display(Name = "Vehicle profile No.")]
        public string Code { get; set; }
        [Display(Name = "Vehicle model")]
        public string Vehicle_model { get; set; }
        [Display(Name = "Vehicle plate number ")]
        public string Vehicle_plate_number { get; set; }
        [Display(Name = "From date")]
        public DateTime From_date { get; set; }
        [Display(Name = "To date")]
        public DateTime To_date { get; set; }
        public string Comments { get; set; }
    }
}