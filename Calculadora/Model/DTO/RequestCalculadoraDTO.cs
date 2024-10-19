using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCS.Model.DTO
{
    public class RequestCalculadoraDTO
    {
        private string idCalculadora;

        public RequestCalculadoraDTO(String idCalculadora)
        {
            this.idCalculadora = idCalculadora;
        }

        public string IdCalculadora { get { return idCalculadora; } }
    }
}
