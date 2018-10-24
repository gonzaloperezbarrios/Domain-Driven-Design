using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Transversal.domain.entities.car
{
    public class CarOwnerEntitie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public int CarId { get; set; }
        [ForeignKey("CarId")]
        public CarEntitie Car { get; set; }
    }
}
