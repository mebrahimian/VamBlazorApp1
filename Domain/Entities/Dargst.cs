using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public  class Dargst
    {
        public int ReqNo { get; set; }

        public byte GstNo { get; set; }

        public string? DateG { get; set; }

        public string? DateP { get; set; }

        public string? Status { get; set; }

        public long Pasandaz { get; set; }

        public long Gstmblg { get; set; }

        public virtual Pvam ReqNoNavigation { get; set; } = null!;
    }

}
