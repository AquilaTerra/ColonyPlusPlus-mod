﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.GameBase.Blocks
{
    class GrassTundra : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public GrassTundra() : base()
        {
            this.TypeName = "grasstundra";
            this.ParentType = "grass";
            this.IsPlaceable = true;

            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("grasstundra",   1,  1.0f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
