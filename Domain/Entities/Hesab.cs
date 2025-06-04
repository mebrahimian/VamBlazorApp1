using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamBlazor.Client.Application.CommonFunc;
using VamBlazor.Client.Application.Services;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Hesab
    {
        public string? Scode { get; set; }

        public string? Pcode { get; set; }

        public long HesabNo { get; set; }

        public long Firstqty { get; set; } = 0;

        public string? Date { get; set; }

        public long Curqty { get; set; } = 0;

        public long? Monthqty { get; set; }

        public long? P { get; set; }

        public long? P1 { get; set; }

        public long? IdDi { get; set; }
        [NotMapped]
        public int V_Day => DateService.GetHDay(Date);
        [NotMapped]
        public int V_Month => DateService.GetHMonth(Date) ;
        [NotMapped]
        public int V_Year => DateService.GetHYear(Date);
        [NotMapped]
        public long V_Mojodi
        {
            get
            {
                return Firstqty + Curqty; // مجموع یا محاسبه دلخواه
            }
        }
    }
}   


