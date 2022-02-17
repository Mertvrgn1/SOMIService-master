using SOMIService.Models.Base;
using SOMIService.Models.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SOMIService.Models
{
    public class FailureLoggingDetail:BaseEntity
    {  
        public Guid FailureLoggingId { get; set; }
        public string OperatorId { get; set; }
        [Display(Name = "Operator İşlem Zamanı")]
        public DateTime? OperatorProcessTime { get; set; }
        public bool OperatorIsAccepted { get; set; } = false;
        [Display(Name = "Operator Açıklaması")]
        public string OperatorDescription { get; set; }
        public string TechnicianId { get; set; }
        [Display(Name = "Teknisyen Raporu")]
        public string TechnicianReport { get; set; }
        public decimal? Price { get; set; }
        [Display(Name = "Bitiş Zamanı")]
        public DateTime? Deadline { get; set; }

        [ForeignKey(nameof(FailureLoggingId))]
        public virtual FailureLogging FailureLogging { get; set; }
      
    }
}
