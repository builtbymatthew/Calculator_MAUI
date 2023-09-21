using Microsoft.Extensions.Logging;

namespace CaclulatorMAUI
{

    public static class MauiProgram //new class for MauiProgram
    {
        public static MauiApp CreateMauiApp() //initialize a new function call CreateMauiApp
        {
            var builder = MauiApp.CreateBuilder(); //initializes a new instance of MauiAppBuilder. 
            builder
                .UseMauiApp<App>() //use the MauiApp extenstion for the framwork of our GUI
                .ConfigureFonts(fonts => //use the configure fonts function to include other types of fonts for our GUI
                {
                    //add these two fonts to our font library
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); 
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug(); //create a debug logger named debug
#endif

            return builder.Build(); //build the MauiApp
        }
    }
}