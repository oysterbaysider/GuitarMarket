using GuitarMarket.Domain.Common;
using GuitarMarket.Domain.UserProfiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Guitars
{
    public class Guitar : IEntity
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }


        public GuitarBrand Brand { get; set; }

        public GuitarModel Model { get; set; }

        public GuitarType Type { get; set; }

    }
}
