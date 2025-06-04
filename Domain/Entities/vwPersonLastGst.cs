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
    public partial class vwPersonLastGst
    {
        public string Code { get; set; } = null!;
        public string? FullName { get; set; }
        public char? Sex { get; set; } = '1';
        public char? City { get; set; } = '1';
        public string? CityDesc { get; set; } = "";
        public long? HesabNo { get; set; }
        public string StartDate { get; set; }
        public long? Moaref { get; set; }
        public long MonthQty { get; set; } = 0;
        public long Mojodi { get; set; } = 0;
        public int? ReqNo { get; set; }
        public char Type { get; set; }
        public string? DateD { get; set; }
        public long MblgVam { get; set; } = 0;
        public int? PKarmozd { get; set; }
        public int? MKarmozd { get; set; }
        public byte? GstNo { get; set; }
        public int? GstPay { get; set; }
        public string? LastDate { get; set; }
        public long PaidVam { get; set; } = 0;
        public byte? CurrentGstNo { get; set; }
        public string? CurrentGstDate { get; set; }
        public string? CurrentPaidDate {  get; set; }
        public long CurrentGstMblg { get; set; } = 0;
        public string? MelliCode { get; set; }
        

    }
}
