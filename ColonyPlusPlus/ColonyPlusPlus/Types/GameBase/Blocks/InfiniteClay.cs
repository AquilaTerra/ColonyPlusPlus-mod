﻿using ColonyPlusPlus.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class InfiniteClay : ColonyAPI.Classes.Type
    {
        public InfiniteClay(string name) : base(name)
        {
            this.OnRemoveAudio = "stoneDelete";
            this.DestructionTime = 1250;
            this.IsDestructible = false;

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("clay",   1,  1.0f),
            };
            this.OnRemove = onRemoveNode;

            CustomDataItem[] customData = {
                new CustomDataItem("minerIsMineable", true),
                new CustomDataItem("minerMiningTime", 8.0f)

            };
            CustomDataHelper c = new CustomDataHelper(customData);
            this.CustomData = c.customDataNode;

            this.Register();
        }
    }
}
