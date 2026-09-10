using DoorX.Services;

namespace DoorX;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        builder.Services.AddSingleton<DoorXApi>();
        builder.Services.AddSingleton<SessionService>();
        return builder.Build();
    }
}
