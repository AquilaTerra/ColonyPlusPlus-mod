﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.GameBase.Blocks
{
    class LogTemperate : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogTemperate() : base()
        {
            this.TypeName = "logtemperate";
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("logtemperate",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "log";
            this.Mesh = "log";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
