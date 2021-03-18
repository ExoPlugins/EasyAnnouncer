using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Announcer
{

    public class Announce : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "announce";
        public string Help => "";
        public string Syntax => throw new NotImplementedException();
        public List<string> Aliases => new List<string> { "anunciar" };
        public List<string> Permissions => new List<string> { "an.announce" };

        public void Execute(IRocketPlayer caller, string[] args)
        {
            var name = caller.DisplayName;
            var message = string.Join(" ", args);
            var title = MQSPlugin.Instance.Configuration.Instance.MessageTitle;

            foreach (var player in Provider.clients.Select(UnturnedPlayer.FromSteamPlayer).Where(x => x != null))
            {
                EffectManager.sendUIEffect(12800, 4205, player.CSteamID, true, title, message, name);
            }

        }

    }

}