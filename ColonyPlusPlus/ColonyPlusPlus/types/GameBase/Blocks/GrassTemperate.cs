﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class GrassTemperate : classes.Type
    {
        public GrassTemperate(string name) : base(name)
        {
            this.ParentType = "grass";
            this.NPCLimit = 0;
            this.IsPlaceable = true;

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("grasstemperate",       1,  1.0f),
                new classes.ItemHelper.OnRemove("wheatstage1",          1,  0.1f),
                new classes.ItemHelper.OnRemove("sappling",             1,  0.03f),
                new classes.ItemHelper.OnRemove("flaxstage1",             1,  0.03f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
