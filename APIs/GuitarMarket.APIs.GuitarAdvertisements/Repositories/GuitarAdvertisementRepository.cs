using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarMarket.APIs.GuitarAdvertisements.Models;
using GuitarMarket.Domain.Sales;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GuitarMarket.APIs.GuitarAdvertisements.Repositories
{
    public class GuitarAdvertisementRepository : IGuitarAdvertisementRepository     
    {
        private readonly IGuitarAdvertisementContext _context;

        public GuitarAdvertisementRepository(IGuitarAdvertisementContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(GuitarAD guitarAd)
        {
            await _context.GuitarAdvertisements.InsertOneAsync(guitarAd);
        }

        public Task<bool> Delete(string GuitarADId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<GuitarAD>> GetAllAds()
        {
           
            return await _context
                            .GuitarAdvertisements.Find(_ => true)
                            .ToListAsync();
        }

        public Task<GuitarAD> GetGuitarAD(string GuitarADId)
        {
            FilterDefinition<GuitarAD> filter = Builders<GuitarAD>.Filter.Eq(m => m.GuitarADId, ObjectId.Parse(GuitarADId));
            return _context
                    .GuitarAdvertisements
                    .Find(filter)
                    .FirstOrDefaultAsync();
        }

        public async Task<bool> Update(GuitarAD guitarAD)
        {
            ReplaceOneResult updateResult =
            await _context
                    .GuitarAdvertisements
                    .ReplaceOneAsync(
                        filter: g => g.GuitarADId== guitarAD.GuitarADId,
                        replacement: guitarAD);
            return updateResult.IsAcknowledged
                    && updateResult.ModifiedCount > 0;
        }
    }
}
