﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class FurnaceLit : ColonyAPI.Classes.Type
    {
        public FurnaceLit(string name) : base(name)
        {
            this.ParentType = "furnace";
            this.IsAutoRotatable = true;
            this.DestructionTime = 1250;
            this.RotatableXPlus = "furnacelitx+";
            this.RotatableXMinus = "furnacelitx-";
            this.RotatableZPlus = "furnacelitz+";
            this.RotatableZMinus = "furnacelitz-";
            this.AllowCreative = false;
            this.Register();
        }
    }
    class FurnancelitxPlus : ColonyAPI.Classes.Type
    {
        public FurnancelitxPlus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideAll = "furnaceside";
            this.SideXPlus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.Register();
        }
    }
    class FurnancelitxMinus : ColonyAPI.Classes.Type
    {
        public FurnancelitxMinus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideAll = "furnaceside";
            this.SideXMinus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.Register();
        }
    }
    class FurnancelitzPlus : ColonyAPI.Classes.Type
    {
        public FurnancelitzPlus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideAll = "furnaceside";
            this.SideZPlus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.Register();
        }
    }
    class FurnancelitzMinus : ColonyAPI.Classes.Type
    {
        public FurnancelitzMinus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideAll = "furnaceside";
            this.SideZMinus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.Register();
        }
    }
}
