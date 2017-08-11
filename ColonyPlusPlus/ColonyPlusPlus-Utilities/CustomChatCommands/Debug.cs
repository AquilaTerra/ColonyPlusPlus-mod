﻿using Permissions;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{

    public class Debug : BaseChatCommand
    {
        public Debug() : base("/cppdebug", false, true)
        {

        }

		protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
		{
			return false;
		}




    }

    public class DebugTypes: BaseChatCommand
    {
        public DebugTypes() : base("/cppdebug json") {
            
        }

		override protected bool RunCommand(Players.Player player, string[] args, NetworkID target)
		{
			if (PermissionsManager.CheckAndWarnPermission(player, "debug") && Classes.Managers.ConfigManager.getConfigBoolean("debug.enabled"))
			{
				Helpers.Debug.outputTypes();
                Helpers.Debug.outputRecipes();

				Chat.send(player, "Outputted JSON to Debug Directory", Chat.ChatColour.yellow);
				return true;


			}
			else
			{
				Chat.send(player, "You are unable to use debug commands", Chat.ChatColour.yellow);
				return false;
			}

		}
    }
}

