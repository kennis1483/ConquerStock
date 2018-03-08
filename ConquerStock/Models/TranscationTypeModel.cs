using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConquerStock.Models
{
    public class TranscationTypeModel
    {
        public byte Id { get; set; }

        public string Buy { get; set; }

        public string Sell { get; set; }
        //新股申購
        public string Lot { get; set; }
        //融資
        public string MarginTrading { get; set; }
        //融券
        public string ShortSelling { get; set; }

    }
}