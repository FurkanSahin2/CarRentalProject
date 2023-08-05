using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Carlmage : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string? ImagesPath { get; set; }
        public DateTime Date { get; set; }

    }
}