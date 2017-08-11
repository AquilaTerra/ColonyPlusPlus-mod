﻿using Permissions;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{

    public class Creative : BaseChatCommand
    {
        public Creative() : base("/creative", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "cheats.creative"))
            {
                // get their stockpile
                Stockpile s =  Stockpile.GetStockPile(ply);

                foreach(string itemname in ColonyAPI.Managers.TypeManager.CreativeAddedTypes)
                {
                    ushort i = ItemTypes.IndexLookup.GetIndex(itemname);
                    s.Add(i, 10000);
                }

                Helpers.Chat.sendSilent(ply, "Enabled Creative Mode", Helpers.Chat.ChatColour.lime);
            }
            Utilities.WriteLog(ply.Name + " attempted to use /creative");
            
            return true;
        }
    }
}

