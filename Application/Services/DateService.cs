using DAL;
using Dapper;
using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using VamBlazor.Client.Application.Dtos;
using VamBlazor.Client.Domain.Entities;
using System.Data;

namespace VamBlazor.Client.Application.Services
{
    public class DateService 
    {
        private readonly string _connectionString;
        private readonly IMapper _mapper;

        public  List<tblDate> TblDate { get; private set; }

        public DateService(IConfiguration configuration, IMapper mapper)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _mapper = mapper;
            LoadData();
        }

        private void LoadData()
        {
            // استفاده از SqlConnection برای بارگذاری داده‌ها از پایگاه داده
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // اجرای یک کوئری ساده برای دریافت داده‌ها
                var query = "SELECT * FROM tblDate10";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {                        
                        TblDate = new List<tblDate>();
                        // خواندن رکوردها و اضافه کردن به لیست TblDate
                        while (reader.Read())
                        {
                            var dateread = _mapper.Map<tblDate>(reader);  // استفاده از AutoMapper برای نگاشت
                            TblDate.Add(dateread);
                        }
                    }
                }
            }
        }
        public bool isDateValid(string Hdate)
        {
            return TblDate.Any(d => d.HDate == Hdate);
        }
        public  string? TodayHDate()
        {
            // تاریخ امروز
            DateTime today = DateTime.Today;

            // جستجو در جدول برای تاریخ میلادی که با تاریخ امروز برابر است
            var todayGDate = TblDate.FirstOrDefault(date => date.GDate.Date == today.Date);

            // اگر تاریخ یافت شد، آن را برمی‌گرداند
            return todayGDate?.HDate;
        }
        public string? TodayHDateString()
        {
            // تاریخ امروز
            DateTime today = DateTime.Today;

            // جستجو در جدول برای تاریخ میلادی که با تاریخ امروز برابر است
            var todayGDate = TblDate.FirstOrDefault(date => date.GDate.Date == today.Date);

            var HDateStr = todayGDate.DayName + " " + todayGDate.HMonthName + " " + todayGDate.HYear;
            // اگر تاریخ یافت شد، آن را برمی‌گرداند
            return HDateStr;
        }
        public static byte GetHDay(string? input)
        {
            if (input != null)
            {
                if (input.Length < 10) return 1;
                var Day = input.Substring(8, 2);
                if (!Day.All(char.IsDigit)) Day = "01";

                return byte.Parse(Day);
            }
            else
            {
                return 1;
            }
        }
        public static byte GetHMonth(string? input)
        {
            if (input != null)
            {
                if (input.Length < 10) return 1;
                var Month = input.Substring(5, 2);
                return byte.Parse(Month);
            }
            else
            {
                { return 1; }
            }
        }
        public static int GetHYear(string? input)
        {
            if (input != null)
            {
                if (input.Length < 10) return 1;
                var Year = input.Substring(0, 4);
                return int.Parse(Year);
            }
            else
            {
                return int.Parse("1400");
            }
        }
        public string DateShamsiFormat(int Year, int Month, int Day)
        {
            var cYear = Year.ToString();
            var cMonth = Month.ToString();
            var cDay = Day.ToString();
            if (cMonth.Length == 1) cMonth = "0" + cMonth;
            if (cDay.Length == 1) cDay = "0" + cDay;
            var cDate = TblDate.FirstOrDefault(date => date.HDate == cYear + "/" + cMonth + "/" + cDay).HDate;
            return cDate ?? " ";
        }
        public string YrMthShamsiFormat(int Year, int Month)
        {
            var cYear = Year.ToString();
            var cMonth = Month.ToString();
            
            if (cMonth.Length == 1) cMonth = "0" + cMonth;
            
            var cYrMth = TblDate.FirstOrDefault(date => date.HDate == cYear + "/" + cMonth + "/01").HDate;
            return cYrMth.Substring(0,7) ?? " ";
        }
        public string DateNextMonthShamsi(string InputDate)
        {
            var nYear = GetHYear(InputDate);
            var nMonth = GetHMonth(InputDate);
            var nDay = GetHDay(InputDate);

            nMonth++;
            if (nMonth == 13)
            {
                nMonth = 1;
                nYear++;
            }
            if (nDay == 31 && nMonth > 6) nDay = 30;

            return DateShamsiFormat(nYear, nMonth, nDay);
        }
        public string DateEndMonthShamsi(string InputDate)
        {
            var cDay = TblDate.FirstOrDefault(date => date.HDate == InputDate)?.HMonthLen;
            return InputDate.Substring(0, 8) + cDay;
        }
        public string DateBeginOfYearShamsi(string InputDate)
        {
            var nYear = GetHYear(InputDate);
            var nMonth = GetHMonth(InputDate);
            var nDay = GetHDay(InputDate);
            nDay = 1;
            nMonth = 1;
                
            return DateShamsiFormat(nYear, nMonth, nDay);
        }
    }
}