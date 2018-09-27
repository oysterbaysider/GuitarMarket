using GuitarMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Photos
{
    public class ProfilePhotos : IPhoto
    {
        public int Id { set; get; }
        public string PhotoUrl { set; get; }

        public int ProfileId { get; set; }
    }
}
