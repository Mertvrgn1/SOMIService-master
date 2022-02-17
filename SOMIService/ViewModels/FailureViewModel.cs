using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOMIService.ViewModels
{
    public class FailureViewModel
    {
        public string UserId { get; set; }
        public string CategoryName { get; set; }
        public string UserName { get; set; }
        public Guid FailureLoggingId { get; set; }
        public Guid CategoryId { get; set; }
        [Display(Name = "Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        public string Location { get; set; }
        [Display(Name = "Arıza Kayıt Zamanı")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
