using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarMarket.APIs.GuitarAdvertisements.Models;
using GuitarMarket.APIs.GuitarAdvertisements.Repositories;
using GuitarMarket.Domain.Sales;
using Microsoft.AspNetCore.Http;
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

        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value4", "value5" };
        //}

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new ObjectResult(await _guitarAdvertisementRepository.GetAllAds());
        }

        [HttpPost]
        public async Task<IActionResult> Post(GuitarAD guitarAd)
        {
            await _guitarAdvertisementRepository.CreateAsync(guitarAd);
            return new OkObjectResult(guitarAd);
        }

    }
}