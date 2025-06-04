using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class UsersLog
    {
        public string? Id { get; set; }

        public string? Status { get; set; }

        public string? ActionDate { get; set; }

        public string? ActionTime { get; set; }

        public string? Station { get; set; }

        public string? System { get; set; }
    }

}
