using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class TotalVam
    {
        public string? Pcode { get; set; }

        public int ReqNo { get; set; }

        public long? MblgReq { get; set; }

        public string? DateReq { get; set; }

        public long? Mblgvam { get; set; }

        public string? DateD { get; set; }

        public string? DateG { get; set; }

        public string? Type { get; set; }

        public long? Gst1 { get; set; }

        public long? Gst2 { get; set; }

        public byte? GstNo { get; set; }

        public int? GstPay { get; set; }

        public int? Pkarmozd { get; set; }

        public int? Mkarmozd { get; set; }

        public int? Mblgmain { get; set; }

        public long? MblgPaid { get; set; }
    }
}
