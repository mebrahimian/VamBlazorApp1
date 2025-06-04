using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Sandogh
    {
        public string? Code { get; set; }

        public string? Onvan { get; set; }

        public decimal? Maxetebar { get; set; }

        public decimal Firstqty { get; set; }

        public decimal Curqty { get; set; }

        public decimal? Etebar { get; set; }

        public string? Type { get; set; }
    }

}
