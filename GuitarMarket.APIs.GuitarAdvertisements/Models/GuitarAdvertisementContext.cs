using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarMarket.Domain.Sales;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace GuitarMarket.APIs.GuitarAdvertisements.Models
{
    public class GuitarAdvertisementContext : IGuitarAdvertisementContext
    {
        private readonly IMongoDatabase _db;

        public GuitarAdvertisementContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<GuitarAdvertisement> GuitarAdvertisements => _db.GetCollection<GuitarAdvertisement>("GuitarAdvertisements");
    }
}
