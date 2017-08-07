﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class QuiverT2 : Classes.Type
    {
        public QuiverT2(string name) : base(name)
        {
            this.NPCLimit = 0;
            this.SideAll = "quiverarrow";
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.MaxStackSize = 400;
            this.IsAutoRotatable = true;
            this.NeedsBase = true;
            this.IsSolid = false;
            this.IsPlaceable = true;
            this.RotatableXPlus = "quiverx+";
            this.RotatableXMinus = "quiverx-";
            this.RotatableZPlus = "quiverz+";
            this.RotatableZMinus = "quiverz-";
            this.Register();
        }
    }

    class QuiverT2xPlus : Classes.Type
    {
        public QuiverT2xPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx+";
            this.Register();
        }
    }
    class QuiverT2xMinus : Classes.Type
    {
        public QuiverT2xMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx-";
            this.Register();
        }
    }
    class QuiverT2zPlus : Classes.Type
    {
        public QuiverT2zPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz+";
            this.Register();
        }
    }
    class QuiverT2zMinus : Classes.Type
    {
        public QuiverT2zMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz-";
            this.Register();
        }
    }
}
