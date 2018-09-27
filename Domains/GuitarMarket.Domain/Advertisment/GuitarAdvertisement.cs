using GuitarMarket.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Sales
{
    public class GuitarAdvertisement : IAdvertisement
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string ItemCondition { get; set; }
        public DateTime Created { get; set; }
        public string PaymentMethod { get; set; }

        public int GuitarId { get; set; }

        public int OwnerId { get; set; }
    }
}
