using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Common
{
    public interface IAdvertisement
    {
        string ObjectId { get; }
        string Status { set; get; }

        string ItemCondition { get; set; }

        DateTime Created { get; set; }

        string Description { get; set; }
    }
}
