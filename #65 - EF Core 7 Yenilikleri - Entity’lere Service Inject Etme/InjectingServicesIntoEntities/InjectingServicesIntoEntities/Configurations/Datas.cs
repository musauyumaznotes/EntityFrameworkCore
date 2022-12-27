﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectingServicesIntoEntities.Configurations
{
    public class PersonData : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(new Person[]
            {
              new(){ PersonId  = 1, Name = "Ayşe" },
              new(){ PersonId  = 2, Name = "Hilmi" },
              new(){ PersonId  = 3, Name = "Raziye" },
              new(){ PersonId  = 4, Name = "Süleyman" },
              new(){ PersonId  = 5, Name = "Fadime" },
              new(){ PersonId  = 6, Name = "Şuayip" },
              new(){ PersonId  = 7, Name = "Lale" },
              new(){ PersonId  = 8, Name = "Jale" },
              new(){ PersonId  = 9, Name = "Rıfkı" },
              new(){ PersonId  = 10, Name = "Muaviye" },
            });
        }
    }
}
