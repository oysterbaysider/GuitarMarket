using GuitarMarket.Domain.Common;
using GuitarMarket.Domain.UserProfiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Guitars
{
    public class Guitar : IEntity
    {

        private string _model;
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }


        public GuitarBrand Brand { get; set; }

        public GuitarType Type { get; set; }

        public int UserId { get; set; }


        public string Model
        {
            get => _model;
            set { _model = value; }
        }

        public void GenerateModelString(GuitarModel gm)
        {
            _model = gm.Model;

        }

    }
}
