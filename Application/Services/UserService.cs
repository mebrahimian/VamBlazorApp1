using DAL;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VamBlazor.Client.Domain.Entities;

public interface IUserService
{
    Task<User> ValidateUserAsync(string username, string password);
}

public class UserService : IUserService
{
    private readonly DatabaseContext _context;

    public UserService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<User> ValidateUserAsync(string username, string password)
    {
        // در دنیای واقعی باید رمز عبور را هش کنید و سپس مقایسه کنید.
        
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == username && u.Password == password);  // ممکن است null باشد
    }
}
