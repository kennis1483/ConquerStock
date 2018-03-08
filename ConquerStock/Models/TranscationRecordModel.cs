using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConquerStock.Models
{
    public class TranscationRecordModel
    {
        public DateTime TranscationDate { get; set; }

        public TranscationTypeModel TransactionType { get; set; }

        public byte PricePerShare { get; set; }

        public byte NumbersOfStock { get; set; }



    }
}