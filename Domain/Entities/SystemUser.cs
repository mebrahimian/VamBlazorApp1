using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class SystemUser
    {
        public string Id { get; set; } = null!;

        public bool Sobh { get; set; }

        public bool Zohr { get; set; }

        public bool Shab { get; set; }

        public bool Vahed1 { get; set; }

        public bool Vahed2 { get; set; }

        public bool? Vahed3 { get; set; }

        public bool Lab { get; set; }

        public bool Tolid { get; set; }

        public bool Control { get; set; }

        public bool Energy { get; set; }

        public bool? Anbar { get; set; }
    }

}
