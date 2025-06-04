using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class MojodiMandehVam
    {
        public string Code { get; set; } = null!;

        public string? Fam { get; set; }

        public string? Sex { get; set; }

        public long? HesabNo { get; set; }

        public string? StartDate { get; set; }

        public long? MandehVam { get; set; }

        public decimal Mojodi { get; set; }
    }

}
