using Auto666.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Auto666.Web.Pages
{
    public class LoginBase:ComponentBase
    {
        [Inject]
        public ILocalStorageService LocalStorageService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public LoginBase()
        {
            LoginData = new LoginViewModel();
            LoginData.Mypass = "1";
        }
        public LoginViewModel LoginData { get; set; }
        protected async Task LoginAsync()
        {


                var token = new SecurityToken
                {
                    AccessToken = LoginData.Password,
                    UserName = LoginData.UserName
                };
                await LocalStorageService.SetAsync(nameof(SecurityToken), token);

                NavigationManager.NavigateTo("/#", true);
        }
    }
    public class MyUsers
    {
        public string Name { get; set; }
        public string Pass { get; set; }
        public MyUsers(string name, string pass)
        {
            Name = name;
            Pass = pass;
        }
    }
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле з логіном повинно бути заповненим!")]
        [StringLength(15, ErrorMessage = "Логін не повинен перевущувати 15 символів!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Поле з паролем повинно бути заповненим!")]
        public string Password { get; set; }
        public MyUsers user1 = new MyUsers("1", "1");
        [Compare("Password", ErrorMessage = "Невірний логін або пароль")]
        public string Mypass { get; set; }
    }
    public class SecurityToken 
    {
        public string UserName { get; set; }
        public string AccessToken { get; set; }
    }
}
