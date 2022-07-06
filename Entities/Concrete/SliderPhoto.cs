﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SliderPhoto : IEntity
    {
        public int Id { get; set; }
        public string PhotoURL { get; set; }
    }
}
