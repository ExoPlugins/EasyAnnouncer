using Rocket.API;
using Rocket.API.Collections;
using Rocket.API.Serialisation;
using Rocket.Core.Plugins;
using SDG.Unturned;
using Logger = Rocket.Core.Logging.Logger;

namespace Announcer
{
    public class MQSPlugin : RocketPlugin<Config>

    {
        public static MQSPlugin Instance;

        protected override void Load()
        {
            MQSPlugin.Instance = this;
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been loaded! ");
            Logger.LogWarning("Dev: MQS#7816");
            Logger.LogWarning("Join this Discord for Support: https://discord.gg/Ssbpd9cvgp");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            EffectManager.onEffectButtonClicked += OnEffectButtonClicked;
        }

        private void OnEffectButtonClicked(Player player, string buttonName)
        {
            if (buttonName == "CloseAnnounce")
            {
                EffectManager.askEffectClearByID(12800, player.channel.owner.playerID.steamID);
            }
        }

        protected override void Unload()
        {
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            Logger.LogWarning($"[{Name}] has been unloaded! ");
            Logger.LogWarning("++++++++++++++++++++++++++++++++++++++");
            EffectManager.onEffectButtonClicked -= OnEffectButtonClicked;
        }
    }
}
