using Sithec.Humano.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sithec.Humano.Consultas.Interfaces
{
    public interface IHumano
    {
        public Task<HumanoDto[]> obtieneHumanos();

        public Task<List<HumanoDto>> obtieneHumanosDb();

        public Task<HumanoDto> obtieneHumanoDB(int Id);
    }
}
