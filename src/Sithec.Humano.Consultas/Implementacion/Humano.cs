using Moq;
using Sithec.Humano.Consultas.Interfaces;
using Sithec.Humano.Dominio.cnContext;
using Sithec.Humano.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Sithec.Humano.Consultas.Implementacion
{
    public class Humano : IHumano
    {
        private readonly HDbContext _context;

        public Humano(HDbContext context )
        {
            _context = context;
        }

        public async Task<HumanoDto[]> obtieneHumanos()
        {
            return await Task.FromResult(this.obtieneArrHumanos());
        }

        public async Task<HumanoDto> obtieneHumanoDB(int Id)
        {
            var humano = (from h in _context.Humanos
                           where h.HumanoId == Id
                           select new HumanoDto
                           {
                               Id = h.HumanoId,
                               Altura = h.Altura,
                               Edad = h.Edad,
                               Nombre = h.Nombre,
                               Peso = h.Peso,
                               Sexo = Convert.ToChar(h.Sexo)
                           }).SingleOrDefault();

            return await Task.FromResult(humano);
        }

        public async Task<List<HumanoDto>> obtieneHumanosDb()
        {
            var humanos = (from h in _context.Humanos
                          select new HumanoDto
                          {
                              Id = h.HumanoId,
                              Altura = h.Altura,
                              Edad = h.Edad,
                              Nombre = h.Nombre,
                              Peso = h.Peso,
                              Sexo = Convert.ToChar(h.Sexo)
                          }).ToList();

            return await Task.FromResult(humanos);
        }

        private HumanoDto[] obtieneArrHumanos()
        {
            HumanoDto[] arrHumanos = { 
                new HumanoDto(1, "Sinuhe Flores Muñoz", 'M', 35, (decimal)1.70, (decimal)72.4),
                new HumanoDto(1, "David Pacheco Venancio", 'M', 42, (decimal)1.80, (decimal)81.4),
                new HumanoDto(1, "Arturo Tellez Meneses", 'M', 44, (decimal)1.75, (decimal)70.4)
            };           

            return arrHumanos;
        }
    }
}
