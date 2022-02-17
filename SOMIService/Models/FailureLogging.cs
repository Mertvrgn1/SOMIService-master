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
    public class FailureLogging:BaseEntity

    {
        [Display(Name = "Adres")]
        public string Address { get; set; }
        public string UserId { get; set; }
        public Guid CategoryId { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        public string Location { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; }
        public List<FailureLoggingDetail> FailureLoggingDetail { get; set; } = new List<FailureLoggingDetail>();
    }
}
