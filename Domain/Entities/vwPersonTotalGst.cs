using MudBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MudBlazor.Colors;
using VamBlazor.Client.Domain.Enum;
using VamBlazor.Client.Application.CommonFunc;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class vwPersonTotalGst
    {
        public string Code { get; set; } = null!;
        public string? FullName { get; set; }
        public long? HesabNo { get; set; }
        public long MonthQty { get; set; } = 0;
        public long? Moaref { get; set; }
        public long Mojodi { get; set; } = 0;
        public int? ReqNo { get; set; }
        public char Type { get; set; }
        public string? DateD { get; set; }
        public long MblgVam { get; set; } = 0;
        public byte? GstNo { get; set; }
        public string? GstDate { get; set; }
        public string? PaidDate {  get; set; }
        public long GstMblg { get; set; } = 0;
        public long Pasandaz { get; set; } = 0;


    }
}
