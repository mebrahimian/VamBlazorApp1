using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class TotalAghsat
    {
        public string? Pcode { get; set; }

        public string? DateG { get; set; }

        public long? Gstmblg { get; set; }

        public int ReqNo { get; set; }

        public string? DateP { get; set; }

        public long HesabNo { get; set; }
    }

}
