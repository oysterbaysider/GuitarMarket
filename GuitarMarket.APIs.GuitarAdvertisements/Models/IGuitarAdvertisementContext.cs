using GuitarMarket.Domain.Sales;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarMarket.APIs.GuitarAdvertisements.Models
{
    public interface IGuitarAdvertisementContext
    {
        IMongoCollection<GuitarAdvertisement> GuitarAdvertisements { get; }
    }
}
