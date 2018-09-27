using GuitarMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Photos
{
    public class GuitarPhotos : IPhoto
    {
        public int Id { set; get; }
        public string PhotoUrl { set; get; }

        public int GuitarId { get; set; }
    }
}
