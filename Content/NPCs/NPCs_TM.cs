using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using TerrariMixed.Content.Items;

namespace TerrariMixed.Content.NPCs
{
	public class NPC_TM_21 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = 2;
		}

		public override void SetDefaults() {
			NPC.scale = 0.75f;
			NPC.width = 38;
			NPC.height = 20;
			NPC.damage = 30;
			NPC.defense = 10;
			NPC.lifeMax = 70;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 250f;
			NPC.knockBackResist = 0.6f;
			NPC.aiStyle = NPCAIStyleID.DemonEye;

			AIType = NPCID.DemonEye; 	
			AnimationType = NPCID.DemonEye;
			Banner = Type;
			BannerItem = ModContent.ItemType<Item_TM_54>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ItemID.GladiatorHelmet, 21, 1));
			npcLoot.Add(ItemDropRule.Common(ItemID.GladiatorBreastplate, 21, 1));
			npcLoot.Add(ItemDropRule.Common(ItemID.GladiatorLeggings, 21, 1));
			npcLoot.Add(ItemDropRule.Common(ItemID.Pizza, 50, 1));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if (spawnInfo.Player.ZoneMarble && !Main.dayTime)
			{
				return 0.25f;
			}
			return 0f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Marble,

				new FlavorTextBestiaryInfoElement("Mods.TerrariMixed.Bestiary.NPC_TM_21")
			]);
		}
	}
	public class NPC_TM_22 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.DemonEye];
		}

		public override void SetDefaults() {
			NPC.width = 19;
			NPC.height = 12;
			NPC.damage = 35;
			NPC.defense = 8;
			NPC.lifeMax = 75;
			NPC.HitSound = SoundID.NPCHit4;
			NPC.DeathSound = SoundID.NPCDeath6;
			NPC.value = 175f;
			NPC.knockBackResist = 0.6f;
			NPC.aiStyle = NPCAIStyleID.DemonEye;

			AIType = NPCID.DemonEye;
			AnimationType = NPCID.DemonEye;
			Banner = Type;
			BannerItem = ModContent.ItemType<Item_TM_53>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ItemID.TinBar, 35, 1, 3));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if (!Main.dayTime && spawnInfo.Player.ZoneNormalCaverns)
			{
				return 0.05f;
			}
			return 0f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				new FlavorTextBestiaryInfoElement("Mods.TerrariMixed.Bestiary.NPC_TM_22")
			]);
		}
	}
}