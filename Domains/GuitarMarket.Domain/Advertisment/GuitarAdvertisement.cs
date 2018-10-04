using GuitarMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Sales
{
    public class GuitarAdvertisement : IAdvertisement
    {
        public string ObjectId { get; }
        public string Status { get; set; }
        public string ItemCondition { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }

        public int GuitarId { get; set; }

        public int OwnerId { get; set; }
    }
}
