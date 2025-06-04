using Microsoft.CodeAnalysis.CSharp.Syntax;
using VamBlazor.Client.Application.Dtos;
using VamBlazor.Client.Domain.Entities;

namespace VamBlazor.Client.Application.Dto_Utilities
{
    public class DtoComparer
    {
        public List<string> CompareDtos(object newDto, object oldDto)
        {
            //  isDiff اگر true باشد فقط تفاوتها را برمی گرداند
            //  isDiff اگر false باشد همه مقادیر قدیمی و جدید را برمی گرداند 
            //
            List<string> differences = new List<string>();

            if (newDto == null || oldDto == null)
            {
                differences.Add("یک یا هردوی Dto ها خالی هستند");
                return differences;
            }

            // دریافت ویژگی‌های هر DTO
            var properties = newDto.GetType().GetProperties();

            foreach (var prop in properties)
            {
                // گرفتن مقادیر هر ویژگی از دو شیء
                var value1 = prop.GetValue(newDto);
                var value2 = prop.GetValue(oldDto);

                // مقایسه مقادیر ویژگی‌ها
                if (!object.Equals(value1, value2))
                {
                    differences.Add($"Property '{prop.Name}' is different: '{value1}' vs '{value2}'");
                }
                else
                {
                    differences.Add($"Property '{prop.Name}' is the same: '{value1}'");
                }
            }

            return differences;
        }
        public List<string> FindDiffItems(object newDto, object oldDto)
        {

            List<string> differences = new List<string>();

            if (newDto == null || oldDto == null)
            {
                differences.Add("یک یا هردوی Dto ها خالی هستند");
                return differences;
            }

            // دریافت ویژگی‌های هر DTO
            var properties = newDto.GetType().GetProperties();

            foreach (var prop in properties)
            {
                // گرفتن مقادیر هر ویژگی از دو شیء
                var value1 = prop.GetValue(newDto);
                var value2 = prop.GetValue(oldDto);

                // مقایسه مقادیر ویژگی‌ها
                if (!object.Equals(value1, value2))
                {
                    differences.Add($"'{prop.Name}'");
                }
            }

            return differences;
        }


        public bool isChangedPardarInfo(PersonAccountDto newDto, Hesab oldDb)
        {

            if (newDto == null || oldDb == null)
            {
                return false;
            }

            if (newDto.HesabNo != oldDb.HesabNo || newDto.Firstqty != oldDb.Firstqty || newDto.V_Year != oldDb.V_Year || 
                newDto.V_Month != oldDb.V_Month || newDto.V_Day != oldDb.V_Day) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
