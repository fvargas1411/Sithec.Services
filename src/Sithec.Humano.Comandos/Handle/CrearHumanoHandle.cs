using MediatR;
using Sithec.Humano.Comandos.Comandos;
using Sithec.Humano.Dominio.cnContext;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sithec.Humano.Comandos.Handle
{
    public class CrearHumanoHandle : INotificationHandler<CrearHumanoCommand>
    {
        private readonly HDbContext _context;

        public CrearHumanoHandle(HDbContext context)
        {
            _context = context;
        }

        public async Task Handle(CrearHumanoCommand cmd, CancellationToken cancellationToken)
        {                        
            using (var tran = await _context.Database.BeginTransactionAsync())
            {
                await _context.Humanos.AddAsync(new Dominio.cnContext.Humano { 
                       Altura = cmd.Humano.Altura,
                       Edad = cmd.Humano.Edad,
                       Nombre = cmd.Humano.Nombre,
                       Peso = cmd.Humano.Peso,
                       Sexo = Convert.ToString(cmd.Humano.Sexo)
                });                

                await _context.SaveChangesAsync();
                await tran.CommitAsync();
            }            

        }
    }
}
