using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VamBlazor.Client.Pages.FormMudSample;
using VamBlazor.Client.Application.CommonFunc;
using VamBlazor.Client.Application.Services;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Pardar
    {
        public string? Scode { get; set; }

        public string? Pcode { get; set; }

        public char Action { get; set; }

        public long Mblg { get; set; }

        public string? Date { get; set; }

        public string? ReqNo { get; set; }

        public string? Babat { get; set; }

        public string? Khayer { get; set; }

        public long IdDi { get; set; }
        [NotMapped]
        public string? V_ActionDesc => CodeToStringFunctions.GetActionDesc(Action);
        [NotMapped]
        public int V_Day => DateService.GetHDay(Date);
        [NotMapped]
        public int V_Month => DateService.GetHMonth(Date);
        [NotMapped]
        public int V_Year => DateService.GetHYear(Date);
    }

}
