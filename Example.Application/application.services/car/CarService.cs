using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainService=Example.Domain.domain.services.car;

namespace Example.Application.application.services.car
{
    /// <summary>
    /// La idea es que tenga metodos que conecte la logica del dominio
    /// Pero si la logica no tiene reglas de negocio:
    ///     Es decir se quiere solo hacer CRUD en base de datos,
    ///     puede usar en el constructor el repository del dominio. 
    /// </summary>
    public class CarService : ICarService
    {
        DomainService.ICarService _domainICarService;
        // Si agrego en el constructor el repository del dominio, tendria acceso a la base de datos indirectamente
        public CarService(DomainService.ICarService domainICarService)
        {
            this._domainICarService = domainICarService;
        }

        public string Turbo()
        {
            return _domainICarService.Turbo();
        }
    }
}
