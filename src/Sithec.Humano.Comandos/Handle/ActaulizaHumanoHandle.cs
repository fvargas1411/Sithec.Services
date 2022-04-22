using MediatR;
using Sithec.Humano.Comandos.Comandos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Sithec.Humano.Dominio.cnContext;
using System.Threading.Tasks;
using System.Threading;

namespace Sithec.Humano.Comandos.Handle
{
    public class ActaulizaHumanoHandle : INotificationHandler<ActualizarHumanoCommand>
    {
        private readonly HDbContext _context;

        public ActaulizaHumanoHandle(HDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ActualizarHumanoCommand cmd, CancellationToken cancellationToken)
        {            
                var oHumano = (from h in _context.Humanos
                               where h.HumanoId == cmd.Humano.Id                                       
                                       select h
                                  ).SingleOrDefault();

                if (oHumano != null)
                {
                    oHumano.Altura = cmd.Humano.Altura;
                    oHumano.Edad = cmd.Humano.Edad;
                    oHumano.Nombre = cmd.Humano.Nombre;
                    oHumano.Peso = cmd.Humano.Peso;
                    oHumano.Sexo = Convert.ToString(cmd.Humano.Sexo);

                    await _context.SaveChangesAsync();
                }
        }
    }
}
