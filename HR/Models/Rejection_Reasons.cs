﻿using HR.Models.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HR.Models
{
    public class Rejection_Reasons
    {
        [Key]
        public int ID { get; set; }
        [Required]
        //[Index(IsUnique = true)]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public reject_purpose purpose { get; set; } = reject_purpose.Job_experience;
    }
}