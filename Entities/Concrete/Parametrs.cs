using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Parametrs : IEntity
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Ekran { get; set; }
        public string RAM { get; set; }
        public string ROM { get; set; }
        public string Processor { get; set; }
        public string Kamera { get; set; }
        public string Ceki { get; set; } 

    }
}
