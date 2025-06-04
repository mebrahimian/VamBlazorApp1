using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public class PersonStatusView

    {
        public string? Pcode { get; set; }

        public string? Date { get; set; }

        public decimal? Vam { get; set; }

        public decimal? GstPaid { get; set; }

        public decimal? Pasandaz { get; set; }

        public int? Karmozd { get; set; }

        public string? Fam { get; set; }

        public string? Sex { get; set; }

        public string SexTitle { get; set; } = null!;

        public long? HesabNo { get; set; }

        public string? Babat { get; set; }
    }
}
