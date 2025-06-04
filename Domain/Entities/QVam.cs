using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VamBlazor.Client.Application.CommonFunc;
using VamBlazor.Client.Application.Services;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Qvam
    {
        public int ReqNo { get; set; }
        [Required]
        public string? Pcode { get; set; }

        public char Status { get; set; } = '0'; 

        public long Mblg { get; set; } = 0;

        public string? Date { get; set; }

        public string? Sabtdate { get; set; }

        public char Type { get; set; }

        public virtual Pvam? Pvam { get; set; }

        [NotMapped]
        public int V_Day => DateService.GetHDay(Date);
        [NotMapped]
        public int V_Month => DateService.GetHMonth(Date);
        [NotMapped]
        public int V_Year => DateService.GetHYear(Date);
        [NotMapped]
        public string? V_TypeVamDesc => CodeToStringFunctions.GetTypeVamDesc(Type);
        [NotMapped]
        public string? FullName { get; set; }
    }
}
