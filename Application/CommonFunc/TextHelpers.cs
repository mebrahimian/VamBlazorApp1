namespace VamBlazor.Client.Application.CommonFunc
{
    public static class TextHelper
    {
        public static string NormalizeSimpleString(string input)
        {
            // تبدیل تمام حروف "ی"  به "ي"
            input = input.Replace('ی', 'ي');  // یا برعکس

            return input;
        }
        public static string NormalizeString(string input)
        {
            // تبدیل تمام حروف "ی"  به "ي"
            input = input.Replace('ی', 'ي');  // یا برعکس
            input = input.Replace('ک', 'ك');  // یا برعکس
            input = input.Replace('ا', 'آ');  // یا برعکس
            input = input.Replace(" ", "");
            return input.Normalize(System.Text.NormalizationForm.FormKD);
        }

        public static bool NormalContain(string source, string findstr)
        {
            if (source == null || findstr == null) return false;
            source = TextHelper.NormalizeString(source);
            findstr = TextHelper.NormalizeString(findstr);
            return source.Contains(findstr);

        }

        // تابع تبدیل اعداد به فارسی

        // تابع تبدیل اعداد به فارسی
       
            // تابع تبدیل عدد به فارسی با جداکننده کاما
            public static string ConvertToPersian(string number, bool isCommaSep = true)
            { 
                bool isNegative = false;
                if (number == "") return "۰";
            if (number.Contains('-')) isNegative = true;
                // ابتدا جداکننده های هزارگان ',' را از رشته حذف می کنیم
                number = number.Replace(",", "");
                number = number.Replace("-", "");
                string[] persianDigits = { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

                // برای هر رقم در عدد ورودی، معادل فارسی آن را برمی‌گرداند
                var persianNumber = number.Select(digit => persianDigits[int.Parse(digit.ToString())])
                                           .Aggregate((current, next) => current + next);

            // بعد از تبدیل به فارسی، جداکننده های هزارگان را دوباره اعمال می کنیم
                string result = isCommaSep ? AddCommaSeparators(persianNumber) : persianNumber;
                if(isNegative)
            {
                result = "(" + result + ")";
            }
                return result;
            }

            // تابع اضافه کردن کاماها به عدد فارسی
            private static string AddCommaSeparators(string number)
            {
                var integerPart = number.Split('.').First(); // قسمت عددی (قبل از اعشاری)
                var decimalPart = number.Contains('.') ? number.Split('.').Last() : string.Empty; // قسمت اعشاری (در صورت وجود)

                // قرار دادن کاماهای هزارگان
                var formattedIntegerPart = string.Join(",", Enumerable.Range(0, (integerPart.Length + 2) / 3)
                    .Select(i => integerPart.Substring(Math.Max(0, integerPart.Length - (i + 1) * 3), Math.Min(3, integerPart.Length - i * 3)))
                    .Reverse());

                // در نهایت، عدد فارسی با کاما را بر می‌گرداند
                return decimalPart.Length > 0 ? $"{formattedIntegerPart}.{decimalPart}" : formattedIntegerPart;
            }

        public static string ConvertNumbersInStringToPersian(string input)
        {
            if (input == null) return "";
            string[] persianDigits = { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };

            // تبدیل هر عدد انگلیسی به معادل فارسی بدون تغییر در فرمت
            var result = string.Concat(input.Select(ch =>
            {
                if (char.IsDigit(ch))
                {
                    return persianDigits[ch - '0'];  // تبدیل عدد انگلیسی به فارسی
                }
                return ch.ToString();  // سایر کاراکترها را دست نخورده نگه می‌دارد
            }));

            return result;
        }

    }
}