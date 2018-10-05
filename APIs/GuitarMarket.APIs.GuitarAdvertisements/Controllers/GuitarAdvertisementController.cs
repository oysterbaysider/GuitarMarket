using System.Threading.Tasks;
using GuitarMarket.APIs.GuitarAdvertisements.Models;
using GuitarMarket.APIs.GuitarAdvertisements.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GuitarMarket.APIs.GuitarAdvertisements.Controllers
{
    [Produces("application/json")]
    [Route("api/GuitarAdvertisement")]
    public class GuitarAdvertisementController : Controller
    {

        private readonly IGuitarAdvertisementRepository _guitarAdvertisementRepository;

        public GuitarAdvertisementController(IGuitarAdvertisementRepository guitarAdvertisementRepository)
        {
            _guitarAdvertisementRepository = guitarAdvertisementRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _guitarAdvertisementRepository.GetAllAds());
        }


        [HttpGet("{GuitarADId}", Name = "Get")]
        public async Task<IActionResult> Get(string guitarADId)
        {
            var guitarAdFromDb = await _guitarAdvertisementRepository.GetGuitarAD(guitarADId);
            if (guitarAdFromDb == null)
                return new NotFoundResult();
            return new ObjectResult(guitarAdFromDb);
        }

        [HttpPost]
        public async Task<IActionResult> Post(GuitarAD guitarAd)
        {
            await _guitarAdvertisementRepository.CreateAsync(guitarAd);
            return new OkObjectResult(guitarAd);
        }


        // PUT: api/Game/5
        [HttpPut("{GuitarADId}")]
        public async Task<IActionResult> Put(string guitarADId, [FromBody]GuitarAD guitarAd)
        {
            var guitarAdFromDb = await _guitarAdvertisementRepository.GetGuitarAD(guitarADId);
            if (guitarAdFromDb == null)
                return new NotFoundResult();
            guitarAd.GuitarADId = guitarAdFromDb.GuitarADId;
            await _guitarAdvertisementRepository.Update(guitarAd);
            return new OkObjectResult(guitarAd);
        }

        [HttpDelete("{GuitarADId}")]
        public async Task<IActionResult> Delete(string guitarADId)
        {
            var guitarAdFromDb = await _guitarAdvertisementRepository.GetGuitarAD(guitarADId);
            if (guitarAdFromDb == null)
                return new NotFoundResult();
            await _guitarAdvertisementRepository.Delete(guitarADId);
            return new OkResult();
        }

    }
}