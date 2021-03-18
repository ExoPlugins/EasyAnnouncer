using Rocket.API;

namespace Announcer
{
    public class Config : IRocketPluginConfiguration

    {
        public string MessageTitle { get; set; }

        public void LoadDefaults()
        {
             MessageTitle = "Example Title";
        }
    }
}
