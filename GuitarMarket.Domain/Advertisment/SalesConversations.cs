using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarMarket.Domain.Advertisment
{
    public class SalesConversations
    {
        public int AdvertisementId { get; set; }
        public int RequestorId { get; set; }

        public string Comment { get; set; }

        public DateTime ConversationDt { get; set; }
    }
}
