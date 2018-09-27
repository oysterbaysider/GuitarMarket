using GuitarMarket.Domain.Common;
using GuitarMarket.Domain.Guitars;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.UserProfiles
{
    public class UserProfile : IEntity
    {
        public int Id { set; get; }

        public string UserName { set; get; }

        public string DisplayName { set; get; }

        public string Description { set; get; }

        //public ICollection<Guitar> Guitars { get; set; }
    }
}
