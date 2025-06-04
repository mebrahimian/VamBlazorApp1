using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public  class Amalkard
    {
        public string? Date { get; set; }

        public long? Mandeh { get; set; }
    }
    public  class AmalkardView
    {
        public string Tbl { get; set; } = null!;

        public string? Pcode { get; set; }

        public string? Date { get; set; }

        public long? Bed { get; set; }

        public long? Bes { get; set; }

        public string? Babat { get; set; }

        public int Karmozd { get; set; }
    }

    public  class AmalkardViewGroup
    {
        public string Tbl { get; set; } = null!;

        public string? Pcode { get; set; }

        public int Karmozd { get; set; }

        public string? Date { get; set; }

        public long? Bed { get; set; }

        public long? Bes { get; set; }
    }

}
