using System.ComponentModel.DataAnnotations.Schema;
using VamBlazor.Client.Application.CommonFunc;

namespace VamBlazor.Client.Application.Dtos
{
    public class PardarDto
    {
        public string? FullName { set; get; }
        public string? Scode { get; set; }

        public string? Pcode { get; set; }

        public char Action { get; set; }

        public long Mblg { get; set; }
       
        public string? Date { get; set; }

        public string? ReqNo { get; set; }

        public string? Babat { get; set; }

        public string? Khayer { get; set; }

        public long IdDi { get; set; }
        public string? V_ActionDesc { get; set; }
        public int V_Day { get; set; }
        public int V_Month { get; set; }
        public int V_Year { get; set; }

        public long V_HesabNo { get; set; }
        public long Mojodi { get; set; } = (long)0;
        public string? Mellicode { get; set; }

    }
}
