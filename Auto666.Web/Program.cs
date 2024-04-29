using Auto666.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using Auto666.Web.Services.Contracts;
using Auto666.Web.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Auto666.Web.Pages;
using System.Security.Cryptography.X509Certificates;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7233/") });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IManageProductsLocalStorageService, ManageProductsLocalStorageService>();

builder.Services.AddScoped<AuthenticationStateProvider, TokenAuthenticationStateProvider>();
builder.Services.AddScoped<Auto666.Web.Services.Contracts.ILocalStorageService, LocalStorageService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();

public class TokenAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly Auto666.Web.Services.Contracts.ILocalStorageService _localStorageService;
    public TokenAuthenticationStateProvider(Auto666.Web.Services.Contracts.ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        AuthenticationState CreateAnonymous()
        {
            var anonymousIdentity = new ClaimsIdentity();
            var anonymousPrincipal = new ClaimsPrincipal(anonymousIdentity);
            return new AuthenticationState(anonymousPrincipal);
        }
        var token = await _localStorageService.GetAsync<SecurityToken>(nameof(SecurityToken));

        if (token == null)
        {
            return CreateAnonymous();
        }
        if (string.IsNullOrEmpty(token.AccessToken))
        {
            return CreateAnonymous();
        }
        // create real user state
        var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Country, "Ukraine"),
            new Claim(ClaimTypes.Name, token.UserName),
            new Claim(ClaimTypes.Role, "Manager"),
            new Claim(ClaimTypes.Role, "Admin"), 
            new Claim("1", "1"),
            new Claim("Äלטענמ", "1")
        };


        var identity = new ClaimsIdentity(claims, "Token");
        var principal = new ClaimsPrincipal(identity);
        return new AuthenticationState(principal);      
    }
    public void MakeUserAnonymous()
    {
        _localStorageService.RemoveAsync(nameof(SecurityToken));

        var anonymousIdentity = new ClaimsIdentity();
        var anonymousPrincipal = new ClaimsPrincipal(anonymousIdentity);
        var authState = Task.FromResult(new AuthenticationState(anonymousPrincipal));
        NotifyAuthenticationStateChanged(authState);
    }
}