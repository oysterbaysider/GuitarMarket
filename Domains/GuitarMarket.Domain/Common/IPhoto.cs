using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Common
{
    public interface IPhoto
    {
        int Id { get; set; }
        string PhotoUrl { get; set; }
    }
}
