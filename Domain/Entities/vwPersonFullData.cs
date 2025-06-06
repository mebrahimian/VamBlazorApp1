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
    public partial class vwPersonFullData
    {
        public string Code { get; set; } = null!;
        public string? FullName { get; set; }
        public string? MelliCode { get; set; }
        public char? Sex { get; set; } = '1';
        public string? SexDesc { get; set; }
        public char? City { get; set; } = '1';
        public string? CityDesc { get; set; } 
        public char Status { get; set; } = '1';
        public string? StatusDesc { get; set; }
        public string? Pcode { get; set; }
        public long? HesabNo { get; set; }
        public long FirstQty { get; set; }
        public string? HDate { get; set; }
        public long CurQty { get; set; }
        public long? MonthQty { get; set; }
        public long Mojodi { get; set; }
        public long? Moaref { get; set; }
        public int? QReqNo { get; set; }
        public string? QStatus { get; set; }
        public long Mblg { get; set; } = 0;
        public string? QDate { get; set; }
        public string? QSabtDate { get; set; }
        public char QType { get; set; }
        public string? QTypeDesc { get; set; }
        public int? PReqNo { get; set; }
        public long MblgVam { get; set; } = 0;  
        public long? Gst1 { get; set; }
        public long? Gst2 { get; set; }
        public byte? PGstNo { get; set; }
        public string? DateD { get; set; }
        public string? PDateG { get; set; }
        public int? PGstPay { get; set; }
        public char? PStatus { get; set; } = '1';
        public string? PSabtDate { get; set; }
        public int? PKarmozd { get; set; }
        public int? MKarmozd { get; set; }
        public char? PType { get; set; } = '1';
        public int? MblgMain { get; set; }
        public int? DReqNo { get; set; }
        public byte? DGstNo { get; set; }
        public string? DDateG { get; set; }
        public string? DDateP { get; set; }
        public string? DStatus { get; set; }
        public long? Pasandaz { get; set; }
        public string? GstMblg { get; set; }
        
        
    }
}
