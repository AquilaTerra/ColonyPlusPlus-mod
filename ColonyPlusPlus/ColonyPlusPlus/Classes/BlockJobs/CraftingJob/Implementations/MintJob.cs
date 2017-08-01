﻿using ColonyPlusPlus.Classes.BlockJobs;
using ColonyPlusPlus.Classes.BlockJobs.CraftingJob;
using NPC;
using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.BlockJobs.CraftingJob.Implementations
{
	public class MintJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
	{
		public override string NPCTypeKey { get { return "pipliz.minter"; } }

		public override float TimeBetweenJobs { get { return 10f; } }

		public override List<Recipe> GetPossibleRecipes { get { return RecipeMinting.AllRecipes; } }

		public override int MaxRecipeCraftsPerHaul { get { return 2; } }

		NPCTypeSettings INPCTypeDefiner.GetNPCTypeDefinition ()
		{
			NPCTypeSettings def = NPCTypeSettings.Default;
			def.keyName = NPCTypeKey;
			def.printName = "Minter";
			def.maskColor1 = new UnityEngine.Color32(227, 205, 53, 255);
			def.type = NPCTypeID.GetNextID();
			return def;
		}
	}
}
