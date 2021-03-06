﻿using ColonyPlusPlusCore.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.GameBase.Blocks
{
    class StoneBlock : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public StoneBlock() : base()
        {
            this.TypeName = "stoneblock";
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("stoneblock",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;

            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.DestructionTime = 600;
            this.IsPlaceable = true;
            this.MaxStackSize = 100;
            this.Register();
        }

        
    }
}
