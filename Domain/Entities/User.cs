using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class User
    {
        public string Id { get; set; } = null!;

        public string? Name { get; set; }

        public string? Password { get; set; }

        public string? Access { get; set; }

        public string? Menu1Option { get; set; }

        public string? Menu2Option { get; set; }

        public string? Menu3Option { get; set; }

        public string? Menu4Option { get; set; }

        public string? SubMenu1 { get; set; }

        public string? SubMenu2 { get; set; }

        public string? SubMenu3 { get; set; }

        public string? SubMenu4 { get; set; }

        public string? ToolBar { get; set; }

        public string? StartTime { get; set; }

        public string? EndTime { get; set; }
    }
}
