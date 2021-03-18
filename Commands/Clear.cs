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

    public class ClearAnnounces : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "CA";
        public string Help => "";
        public string Syntax => throw new NotImplementedException();
        public List<string> Aliases => new List<string>() { "clearannounces" };
        public List<string> Permissions => new List<string> { "ca.usage" };
        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer playerid = UnturnedPlayer.FromName(caller.ToString());

            EffectManager.askEffectClearByID(12800, playerid.CSteamID);

        }
    }
}