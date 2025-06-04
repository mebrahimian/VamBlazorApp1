
namespace VamBlazor.Client.Application.CommonFunc
{
    public static class CodeToStringFunctions
    {
        public static string GetCityDesc(Char? input)
        {  if (input != null)
            {
                if (input == '1') return "شاهرود";
                if (input == '2') return "گرگان";
                if (input == '3') return "تهران";
                if (input == '4') return "سایـر";
            }
            return "شاهرود";
        }
        public static string GetSex(Char input)
        {
            
            if (input == '1') return "مرد";
            if (input == '2') return "زن";
            return "مرد";
        }
        public static string GetTypeVamDesc(char input)
        {
            
            if (input == '1') return "عـادی";
            if (input == '2') return "ضروری";
            return "عـادی";
        }

        public static string GetTasvibDesc(bool Editable)
        {
            if (!Editable) return "تصویب شده";
            return "";
        }
        public static string GetPardakhtDesc(bool Editable)
        {
            if (!Editable) return "پرداخت شده";
            return "";
        }
        public static string GetActionDesc(char input)
        {
           
            if (input == '1') return "واریـز";
            if (input == '2') return "برداشت";
            if (input == '3') return "افتتاح";
            return "واریـز";
        }
    }
}
