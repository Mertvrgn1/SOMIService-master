﻿using SOMIService.Models.Base;
using SOMIService.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SOMIService.Models
{
    public class FailureLogging

    {
        [Key]
        public int FailureLoggingId { get; set; }
        public string UserId { get; set; }
        public string TechnicianId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Description{ get; set; }
        public bool TechnicianIsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? TechnicianAssignDate { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public Decimal? TotalPrice { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; }
        [ForeignKey(nameof(TechnicianId))]
        public virtual ApplicationUser Technician { get; set; }


    }
}
