using GuitarMarket.Domain.Sales;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarMarket.APIs.GuitarAdvertisements.Models
{
    public class GuitarAD: GuitarAdvertisement
    {
        [BsonId]
        public ObjectId GuitarADId { get; set; }

    }
}
