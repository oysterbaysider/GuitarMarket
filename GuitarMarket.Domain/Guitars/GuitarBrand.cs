using GuitarMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Guitars
{
    public class GuitarBrand : IEntity
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public ICollection<GuitarModel> Models { get; set; }

    }
}
