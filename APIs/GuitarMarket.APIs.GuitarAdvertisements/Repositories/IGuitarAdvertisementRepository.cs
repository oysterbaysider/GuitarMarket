using GuitarMarket.APIs.GuitarAdvertisements.Models;
using GuitarMarket.Domain.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarMarket.APIs.GuitarAdvertisements.Repositories
{
    public interface IGuitarAdvertisementRepository
    {
        Task CreateAsync(GuitarAD guitarAd);

        Task<IEnumerable<GuitarAD>> GetAllAds();

        Task<GuitarAD> GetGuitarAD(string GuitarADId);

        Task<bool> Update(GuitarAD game);
        Task<bool> Delete(string GuitarADId);
    }
}
