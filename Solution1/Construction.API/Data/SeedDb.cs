using Construction.API.Helpers;
using Construction.Shared.Entidades;
using Construction.Shared.Enums;

namespace Construction.API.Data
{
    public class SeedDb
    {

        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        
        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            //await checkpettype?
            await CheckRolesAsync();

            await CheckUserAsync("SuperAdmin", "Calle 10 #19-23", "correo123@gmail.com", UserType.Admin);
        }
        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }
        private async Task<User> CheckUserAsync(string nombre, string address, string email, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    Nombre = nombre,
                    Ubicacion = address,
                    UserName = email,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }
            //await _context.SaveChangesAsync();
            return user;

        }

    }
}
