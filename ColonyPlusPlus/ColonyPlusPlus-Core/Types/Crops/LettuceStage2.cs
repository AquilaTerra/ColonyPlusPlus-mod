﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Crops
{
    class LettuceStage2 : GrowableType
    {
        public LettuceStage2(string name) : base(name, true)
        {
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("lettucestage1",   1,  0.8f)
            };
            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.AllowCreative = false;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage2";
            this.maxGrowth = 12f;
            this.IsBaseBlock = false;



            TypeManager.registerCrop(this);
            CropManager.addCropStage(name, "lettucestage3");
            CropManager.CropTypes.Add("lettucestage2", this);

            this.Register();
        }

        
    }
}
