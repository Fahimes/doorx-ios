using DoorX.Services;
namespace DoorX;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(Views.LoginPage), typeof(Views.LoginPage));
        Routing.RegisterRoute(nameof(Views.HomePage), typeof(Views.HomePage));
        Routing.RegisterRoute(nameof(Views.ProfilePage), typeof(Views.ProfilePage));
        Routing.RegisterRoute(nameof(Views.SettingsPage), typeof(Views.SettingsPage));
        Routing.RegisterRoute(nameof(Views.LogsPage), typeof(Views.LogsPage));
        Routing.RegisterRoute(nameof(Views.UsersPage), typeof(Views.UsersPage));
        Routing.RegisterRoute(nameof(Views.SecurityPage), typeof(Views.SecurityPage));
        Routing.RegisterRoute(nameof(Views.ChangePasswordPage), typeof(Views.ChangePasswordPage));
        UpdateMenu();
    }
    public void UpdateMenu()
    {
        var session = new SessionService();
        var role = session.Role;
        var admin = role == "admin";
        foreach (var item in Items)
            item.IsVisible = item.Route is not ("Users" or "Security" or "Logs") || admin;
    }
}
