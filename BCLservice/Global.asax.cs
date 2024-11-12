using System;

namespace BCLservice
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
//            ServiceStack.Licensing.RegisterLicense(@"wvpkPXGeEvOJ16y2Vd/cOFxgjNXghGwzOrVLJ43Ajp5qvWMxZ1mS0MmWgq4MJStsuGstvsWnj4ZaKfZ0tRtEfa4a15STHsZDAa7Qv950b+nMJGzA7vm/dzrnnctl/v5sHZd9MX7iCrHDW03hPC7/zDGj/I3oOtCyVDQelMCOxvI=");
            new AppHost().Init();
        }
    }
}