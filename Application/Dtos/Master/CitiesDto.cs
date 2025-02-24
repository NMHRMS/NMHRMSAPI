﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Master
{
    public class CitiesDto
    {
        public int CityId { get; set; }

        public string Name { get; set; } = null!;

        public string ShortName { get; set; } = null!;

        public int StateId { get; set; }
    }
}
