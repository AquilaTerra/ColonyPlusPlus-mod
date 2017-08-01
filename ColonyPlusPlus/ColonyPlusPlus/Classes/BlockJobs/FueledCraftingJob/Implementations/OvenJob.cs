﻿using BlockTypes.Builtin;
using ColonyPlusPlus.Classes.BlockJobs;
using NPC;
using Pipliz;
using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.BlockJobs.FueledCraftingJob.Implementations
{
	public class OvenJob : FueledCraftingJobBase, IBlockJobBase, INPCTypeDefiner
	{
		public override string NPCTypeKey { get { return "pipliz.baker"; } }

		public override float TimeBetweenJobs { get { return 8.3f; } }

		public override List<RecipeFueled> GetPossibleRecipes { get { return RecipeBaking.AllRecipes; } }

		public override int MaxRecipeCraftsPerHaul { get { return 3; } }

		public override void OnLit ()
		{
			ushort litType;
			if (blockType == BuiltinBlocks.OvenUnlitXP) {
				litType = BuiltinBlocks.OvenLitXP;
			} else if (blockType == BuiltinBlocks.OvenUnlitXN) {
				litType = BuiltinBlocks.OvenLitXN;
			} else if (blockType == BuiltinBlocks.OvenUnlitZP) {
				litType = BuiltinBlocks.OvenLitZP;
			} else {
				litType = BuiltinBlocks.OvenLitZN;
			}
			ServerManager.TryChangeBlock(position, litType);
		}

		public override Vector3Int GetPositionNPC (Vector3Int position)
		{
			Vector3Int positionNPC;
			if (blockType == BuiltinBlocks.OvenUnlitXP || blockType == BuiltinBlocks.OvenLitXP) {
				positionNPC = position.Add(1, 0, 0);
			} else if (blockType == BuiltinBlocks.OvenUnlitXN || blockType == BuiltinBlocks.OvenLitXN) {
				positionNPC = position.Add(-1, 0, 0);
			} else if (blockType == BuiltinBlocks.OvenUnlitZP || blockType == BuiltinBlocks.OvenLitZP) {
				positionNPC = position.Add(0, 0, 1);
			} else if (blockType == BuiltinBlocks.OvenUnlitZN || blockType == BuiltinBlocks.OvenLitZN) {
				positionNPC = position.Add(0, 0, -1);
			} else {
				positionNPC = position;
			}
			return positionNPC;
		}

		NPCTypeSettings INPCTypeDefiner.GetNPCTypeDefinition ()
		{
			NPCTypeSettings def = NPCTypeSettings.Default;
			def.keyName = NPCTypeKey;
			def.printName = "Baker";
			def.maskColor1 = new UnityEngine.Color32(192, 160, 117, 255);
			def.type = NPCTypeID.GetNextID();
			return def;
		}
	}
}
