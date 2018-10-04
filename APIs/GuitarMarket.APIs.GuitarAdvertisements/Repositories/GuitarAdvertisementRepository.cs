using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarMarket.APIs.GuitarAdvertisements.Models;
using GuitarMarket.Domain.Sales;
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
            //await _context.Games.InsertOneAsync(game);
        }

        public async Task<IEnumerable<GuitarAD>> GetAllAds()
        {
           
            return await _context
                            .GuitarAdvertisements.Find(_ => true)
                            .ToListAsync();
        }
    }
}
