using GuitarMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Guitars
{
    public class GuitarPhoto : IEntity
    {
        public int Id { get; set; }

        public string PhotoUrl { get; set; }


    }
}
