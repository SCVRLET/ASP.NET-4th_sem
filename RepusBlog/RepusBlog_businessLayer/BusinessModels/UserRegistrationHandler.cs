using RepusBlog_dataLayer.Database;
using RepusBlog_dataLayer.Entities;
using RepusBlog_businessLayer.DTO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace RepusBlog_businessLayer.BusinessModels
{
    //Мб эксепшены потом можно будет добавить и их возвращать вместо false
    class UserRegistrationHandler
    {
        private AppDbContext _context;
        private UserManager<User> _userManager;
        private User _user;
        private SignInManager<User> _signInManager;

        public UserRegistrationHandler(AppDbContext context, UserDTO user, UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _context = context;
            _user = new User { Id = user.Id, Login = user.Login, Password_hash = GetPasswordHash(user.Password_hash), Email = user.Email,
                             Country = user.Country, Name = user.Name, SurName = user.SurName, Type = (UserType)user.Type};
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> SignUp()
        {
            var result = await _userManager.CreateAsync(_user, _user.Password_hash);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(_user, false);
                return true;
            }

            return false;
        }

        public async Task<bool> SignIn()
        {
            var expected_user = await _userManager.FindByNameAsync(_user.Login);

            if (expected_user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(expected_user, _user.Password_hash, false, false);

                if (result.Succeeded)
                    return true;
            }

            return false;
        }

        public async void LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        private string GetPasswordHash(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
    }
}
