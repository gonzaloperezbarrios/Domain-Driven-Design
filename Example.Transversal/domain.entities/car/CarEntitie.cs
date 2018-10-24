using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Transversal.domain.entities.car
{
    public class CarEntitie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        public string Engine { get; set; }
        [StringLength(100)]
        public string Model { get; set; }
        public List<CarOwnerEntitie> carOwners { get; set; }
    }
}
