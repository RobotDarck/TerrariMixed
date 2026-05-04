using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using TerrariMixed.Content.Items;

namespace TerrariMixed.Content.NPCs
{
	public class NPC_Topaz_1 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults() {
			NPC.width = 15;
			NPC.height = 12;
			NPC.damage = 20;
			NPC.defense = 3;
			NPC.lifeMax = 60;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 120f;
			NPC.knockBackResist = 0.5f;
			NPC.aiStyle = NPCAIStyleID.Slime;
			AIType = NPCID.BlueSlime;
			AnimationType = NPCID.BlueSlime;
			Banner = Type;
			BannerItem = ModContent.ItemType<Items_TM_Banners_15>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ItemID.Topaz, 5, 1, 3));
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items_TM_Topaz_1>(), 1, 1, 3));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.Cavern.Chance * 0.025f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				new FlavorTextBestiaryInfoElement("He is shiny, but cheap."),
			]);
		}
	}
	
	public class NPC_Topaz_2 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.DemonEye];
		}

		public override void SetDefaults() {
			NPC.width = 19;
			NPC.height = 12;
			NPC.damage = 30;
			NPC.defense = 4;
			NPC.lifeMax = 120;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 150f;
			NPC.knockBackResist = 0.45f;
			NPC.aiStyle = NPCAIStyleID.DemonEye;

			AIType = NPCID.DemonEye;
			AnimationType = NPCID.DemonEye;
			Banner = Type;
			BannerItem = ModContent.ItemType<Items_TM_Banners_16>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ItemID.Topaz, 5, 1, 3));
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items_TM_Topaz_2>(), 3, 1));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.Cavern.Chance * 0.025f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				new FlavorTextBestiaryInfoElement("He is shiny, but cheap."),
			]);
		}
	}
}