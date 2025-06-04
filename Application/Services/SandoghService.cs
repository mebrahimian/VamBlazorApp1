using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

public class SandoghService
{
    private readonly DatabaseContext _dbContext;
    private readonly IMemoryCache _cache;
    private const string SandoghNameCacheKey = "SandoghName"; // کلید کش برای نام شرکت
    private string _SandoghName; // متغیر برای ذخیره نام شرکت

    public SandoghService(DatabaseContext dbContext, IMemoryCache memoryCache)
    {
        _dbContext = dbContext;
        _cache = memoryCache;
    }

    // متد برای دریافت نام شرکت (فقط یک‌بار از دیتابیس خوانده می‌شود)
    public string  GetSandoghName()
    {
        if (_SandoghName == null)
        {
            // اگر نام شرکت در کش نباشد، از دیتابیس می‌خوانیم و در کش قرار می‌دهیم
#pragma warning disable CS8601 // Possible null reference assignment.
            _SandoghName = _dbContext.Sandoghs
                                           .Where(c => c.Code == "01") // یا هر شرطی که برای انتخاب شرکت دارید
                                           .Select(c => c.Onvan)
                                           .FirstOrDefault();
#pragma warning restore CS8601 // Possible null reference assignment.
        }

        return _SandoghName.PadRight(150);
    }

    // متد برای دریافت فروش لحظه‌ای از دیتابیس
    public long GetCurrentSandogh()
    {
        // خواندن مقدار فروش لحظه‌ای از دیتابیس
        var currentSandogh =  _dbContext.Sandoghs
                                           .Where(c => c.Code == "01") // یا هر شرطی که برای انتخاب شرکت دارید
                                           .FirstOrDefault();

        return (long)(currentSandogh.Firstqty+ currentSandogh.Curqty);
    }
}

