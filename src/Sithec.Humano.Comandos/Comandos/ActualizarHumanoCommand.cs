using MediatR;
using Sithec.Humano.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sithec.Humano.Comandos.Comandos
{
    public class ActualizarHumanoCommand : INotification
    {
        public HumanoDto Humano { get; set; }
    }
}
