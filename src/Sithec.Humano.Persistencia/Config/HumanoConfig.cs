using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sithec.Humano.Persistencia.Config
{
    public class HumanoConfig
    {
        public HumanoConfig(EntityTypeBuilder<Sithec.Humano.Persistencia.Models.Humano> entityBuilder) 
        {
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(70);
            entityBuilder.Property(x => x.Sexo).IsRequired();
            entityBuilder.Property(x => x.Edad).IsRequired();
        }
    }
}
