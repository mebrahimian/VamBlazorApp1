using Microsoft.Data.SqlClient;
using System.Configuration;
using Dapper;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using VamBlazor.Client.Application.Dtos;
using System.Drawing.Text;
using VamBlazor.Client.Domain.Entities;

namespace VamBlazor.Client.Application.Services
{
    public class PersonServices
    {
        private IConfiguration _configuration;
        public PersonServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // تابع برای ساخت مسیر تصویر
        public string GetPersonPictureAddress(string personCode)
        {
            if (string.IsNullOrEmpty(personCode))
            {
                // در صورتی که PersonCode مقدار ندارد
                return "";  // یا می‌توانید یک مسیر پیش‌فرض بازگردانید
            }
            var HesabNo = GetHesabNo(personCode).ToString(); 
            
            string[] extensions = { ".jpg", ".Jpeg", ".png", ".gif" };
            foreach (var ext in extensions)
            {
                string imagePath = Path.Combine("wwwroot/Images", HesabNo + ext);

                if (File.Exists(imagePath))  // اگر فایل با این مسیر وجود داشته باشد
                {
                    return imagePath.Substring(8);  // مسیر صحیح تصویر را باز می‌گردانیم
                }
            }

            return Path.Combine("Images", "sun1.Jpeg");
        }

        public string GetPersonPlaceDesc(string personCode)
        {
            return "";
        }

        public long GetHesabNo(string cPcode)
        {
            if (string.IsNullOrEmpty(cPcode)) return Convert.ToInt64(0);
            var ExistCommand = "SELECT Hesab_No AS HesabNo FROM Hesab WHERE Pcode = @Pcode";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();  // باز کردن اتصال به پایگاه داده به صورت همزمان

                // اجرای کوئری به صورت همزمان
                var result = connection.ExecuteScalar<long>(ExistCommand, new { Pcode = cPcode });

                // اگر نتیجه صفر یا منفی باشد
                if (result <= 0)
                {
                    return 0; // حساب ندارد
                }

                // بازگشت نتیجه به عنوان long
                return result; // تبدیل نتیجه به long (در صورت نیاز)
            }
        }
        public long GetMojodiHesab(string cPcode)
        {
            if (string.IsNullOrEmpty(cPcode)) return Convert.ToInt64(0);
            var ExistCommand = "SELECT FirstQty + CurQty AS Mojidi FROM Hesab WHERE Pcode = @Pcode";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();  // باز کردن اتصال به پایگاه داده به صورت همزمان

                // اجرای کوئری به صورت همزمان
                var result = connection.ExecuteScalar<long>(ExistCommand, new { Pcode = cPcode });

                // اگر نتیجه صفر یا منفی باشد
                if (result <= 0)
                {
                    return 0; // مقدار دلخواه در صورت وجود مانده منفی یا صفر
                }

                // بازگشت نتیجه به عنوان long
                return result; // تبدیل نتیجه به long (در صورت نیاز)
            }
        }
        public long GetRemainVam(int? ReqNoInput)            
        {
            if (ReqNoInput == null) return Convert.ToInt64(0);
            var ExistCommand = @"SELECT mblgvam - ISNULL((SELECT SUM(gstmblg) AS Paid
                                                          FROM DARGST
                                                          WHERE (req_no = PVAM.req_no)), 0) AS Remain
                                 FROM PVAM WHERE (req_no = @ReqNoQuery)";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();  // باز کردن اتصال به پایگاه داده به صورت همزمان

                // اجرای کوئری به صورت همزمان
                var result = connection.ExecuteScalar<long>(ExistCommand, new { ReqNoQuery = ReqNoInput });

                // اگر نتیجه صفر یا منفی باشد
                if (result <= 0)
                {
                    return 0; // مقدار دلخواه در صورت وجود مانده منفی یا صفر
                }

                // بازگشت نتیجه به عنوان long
                return result; // تبدیل نتیجه به long (در صورت نیاز)
            }
        }
        public AccountInfoDto GetAccountInfo(string PCode = null, long HesabNo = 0)
        {
            var AccInfo = new vwPersonLastGst();
            if (!string.IsNullOrEmpty(PCode))
            {
                // دریافت اطلاعات بر اساس personCode
                var ExistCommand = @"SELECT * FROM vwPersonLastGst WHERE (Code = @PersonCode)";
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();  // باز کردن اتصال به پایگاه داده به صورت همزمان

                    // اجرای کوئری به صورت همزمان
                    var result = connection.QueryFirst<vwPersonLastGst>(ExistCommand, new { PersonCode = PCode });

                    // اگر نتیجه صفر یا منفی باشد
                    if (result.HesabNo == 0)
                    {
                        return new AccountInfoDto { Pcode = PCode, HesabNo = HesabNo }; // مقدار دلخواه در صورت وجود مانده منفی یا صفر
                    }
                    AccInfo = result;
                }
            }
            else if (HesabNo != 0)
            {
                // دریافت اطلاعات بر اساس accountNumber
                var ExistCommand = @"SELECT * FROM vwPersonLastGst WHERE (HesabNo = @HesabNoSql)";
                using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    connection.Open();  // باز کردن اتصال به پایگاه داده به صورت همزمان

                    // اجرای کوئری به صورت همزمان
                    var result = connection.QueryFirst<vwPersonLastGst>(ExistCommand, new { HesabNoSql = HesabNo });

                    // اگر نتیجه صفر یا منفی باشد
                    if (result.HesabNo == 0)
                    {
                        return new AccountInfoDto { Pcode = PCode, HesabNo = HesabNo }; // مقدار دلخواه در صورت وجود مانده منفی یا صفر
                    }
                    AccInfo = result;
                }
            }
            else
            {
                // مدیریت حالت زمانی که هیچ پارامتری ارسال نشده است
                return new AccountInfoDto { Pcode = PCode, HesabNo = HesabNo };
            }

            return new AccountInfoDto
                           { 
                              Pcode = AccInfo.Code,
                              HesabNo = AccInfo.HesabNo,
                              Moaref = AccInfo.Moaref,
                              FullName = AccInfo.FullName,
                              CityDesc = AccInfo.CityDesc,
                              StartDate = AccInfo.StartDate,
                              LastMojodi = AccInfo.Mojodi,
                              LastReqNo = AccInfo.ReqNo,
                              LastReqDate = AccInfo.DateD,
                              LastMblgVam = AccInfo.MblgVam,
                              LastRemain = AccInfo.MblgVam - AccInfo.PaidVam,
                              PictureAddress = GetPersonPictureAddress(AccInfo.Code)
                          };
        }
    }
}
    
