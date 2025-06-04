using MudBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MudBlazor.Colors;
using VamBlazor.Client.Domain.Enum;
using VamBlazor.Client.Application.CommonFunc;

namespace VamBlazor.Client.Domain.Entities
{
    public partial class Person
    {
        public string Code { get; set; } = null!;

        public string? Family { get; set; }

        public string? Name { get; set; }

        public string? Father { get; set; }

        public Char? Sex { get; set; } = '1';

        public string? IssueNo { get; set; }

        public string? Tel { get; set; }

        public string? Address { get; set; }

        public Char? City { get; set; } = '1';

        public string? Mellicode { get; set; }

        public long IdDi { get; set; }

        public string Status { get; set; } = "1";

        public string? CardBank { get; set; }

        public int? BankType { get; set; }

        public string? HesabBank { get; set; }
        [NotMapped]
        public string FullName => $"{Family?.Trim()} {Name?.Trim()}" +
                              (string.IsNullOrEmpty(Father) ? "" : $" ({Father?.Trim()})");
        [NotMapped]
        public string? V_CityDesc => CodeToStringFunctions.GetCityDesc(City ?? '1');
    
    }
}
