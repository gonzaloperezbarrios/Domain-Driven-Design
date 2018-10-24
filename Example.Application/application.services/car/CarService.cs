using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Transversal.domain.entities.car;
using DomainService = Example.Domain.domain.services.car;
using DomainRepository = Example.Domain.repositories.contracts.car;

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
        // Obtiene el acceso a la logica del dominio
        DomainService.ICarService _domainICarService;
        // Obtiene el acceso a la base de datos indirectamente
        DomainRepository.ICarRepository _domainCarRepository;
        public CarService(DomainService.ICarService domainICarService, DomainRepository.ICarRepository domainCarRepository)
        {
            this._domainICarService = domainICarService;
            this._domainCarRepository = domainCarRepository;
        }

        public void Create(CarEntitie carEntitie)
        {
            _domainCarRepository.Create(carEntitie);
        }

        public List<CarEntitie> GetCars()
        {
            return _domainCarRepository.GetCars();
        }

        public string Turbo()
        {
            return _domainICarService.Turbo();
        }
    }
}
