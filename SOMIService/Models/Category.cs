using SOMIService.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOMIService.Models
{
    public class Category:BaseEntity
    {
       
        [Required]
        [StringLength(100)]
        [Display(Name = "Kategori Adı")]
        public string CategoryName { get; set; }
        [StringLength(200)]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        public List<FailureLogging> FailureLogging { get; set; } = new List<FailureLogging>();
    }
}
