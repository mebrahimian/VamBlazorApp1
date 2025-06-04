using System.ComponentModel.DataAnnotations;

namespace VamBlazor.Client.Domain.Entities
{
    public class tblDate
    {
        public string? HDate { get; set; }
        public DateTime GDate { get; set; }
        public string? HYear { get; set; }
        public string? GYear { get; set; }
        public string? HYrMth { get; set; }
        public string? GYrMth { get; set; }
        public string? HMonthNo { get; set; }
        public string? GMonthNo { get; set; }
        public string? HMonthName { get; set; }
        public string? GMonthName { get; set; }
        public byte? HWeekNo { get; set; }
        public byte? GWeekNo { get; set; }
        public byte? HDay { get; set; }
        public byte? GDay { get; set; }
        public byte? HMonthLen { get; set; }
        public byte? GMonthLen { get; set; }
        public string? HWeekDayName { get; set; }
        public string? GWeekDayName { get; set; }
        public byte? HWeekDayNo { get; set; }
        public byte? GWeekDayNo { get; set; }
        public string? DayName { get; set; }

    }
}
