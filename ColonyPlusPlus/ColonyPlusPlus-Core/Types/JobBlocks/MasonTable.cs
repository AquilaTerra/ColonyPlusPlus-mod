﻿using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.JobBlocks
{
    class MasonTable : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public MasonTable() : base()
        {
            this.TypeName = "masontable";
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.SideAll = "stonebricks";
            this.SideYPlus = "masontable";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.AllowPlayerCraft = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtemperate", 1),
                    RecipeManager.Item("planks", 4),
                    RecipeManager.Item("stonebricks", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("masontable", 1)
                },
                0.0f, true, true);
        }
    }
}