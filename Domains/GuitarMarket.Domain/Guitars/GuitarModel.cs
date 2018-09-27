using GuitarMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Guitars
{
    public class GuitarModel : IEntity
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string ModelIntroduction { get; set; }

        public GuitarBrand Brand { get; set; }
    }
}
