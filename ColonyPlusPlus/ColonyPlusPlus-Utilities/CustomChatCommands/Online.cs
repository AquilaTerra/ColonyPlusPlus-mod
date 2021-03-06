﻿using Permissions;
using System;
using System.Collections.Generic;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{

    public class Online : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
    {
        public Online() : base("/online", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "online"))
            {

                List<string> online = new List<string>() ;

                for(int i = 0; i < Players.CountConnected; i++)
                {
                    Players.Player p = Players.GetConnectedByIndex(i);
                    online.Add(p.Name);
                }

                online.Sort();
                
                ColonyAPI.Helpers.Chat.send(ply, String.Format("Players Online ({0}): {1}",Players.CountConnected, String.Join(", ",online.ToArray())), ColonyAPI.Helpers.Chat.ChatColour.white, ColonyAPI.Helpers.Chat.ChatStyle.normal ,Pipliz.Chatting.ChatSenderType.Server);
            }
            
            return true;
        }
    }
}

