using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOMIService.ViewModels
{
    public class CustomerFailureViewModel
    {
        public string UserId { get; set; }
        public int FailureLoggingId { get; set; }

        [Display(Name = "Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool FaultIsFixxed { get; set; } = false;
    }
}
