using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.Domain.repositories.contracts.car;

namespace Example.Infrastructure.repositories.car
{
    /// <summary>
    /// Implementa la interfaz del dominio 
    /// La idea es que este conectado con una base de datos en la caperta persistence
    /// La carpeta persistence, tiene conexion a base de datos; ya sea entity framework o DAO
    /// </summary>
    public class CarRepository : ICarRepository
    {
        public string GetEngine()
        {
            return "V8";
        }
    }
}
