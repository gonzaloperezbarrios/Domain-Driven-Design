using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Example.Presentation.Web.Models
{
    public class CarViewModel : ViewModelBase
    {
        public int? CarId { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Motor")]
        public string Engine { get; set; }
        [StringLength(100)]
        [Display(Name = "Modelo")]
        public string ModelCar { get; set; }
    }
}