using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using TerrariMixed.Content.Items;

namespace TerrariMixed.Content.NPCs
{
	public class NPC_Copper_1 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults() {
			NPC.width = 16;
			NPC.height = 12;
			NPC.damage = 11;
			NPC.defense = 3;
			NPC.lifeMax = 38;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 30f;
			NPC.knockBackResist = 0f;
			NPC.aiStyle = NPCAIStyleID.Slime;

			AIType = NPCID.BlueSlime;
			AnimationType = NPCID.BlueSlime;
			Banner  = Type;
			BannerItem = ModContent.ItemType<Items_TM_Banners_3>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items_TM_Copper_2>(), 1, 1, 3));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldDaySlime.Chance * 0.025f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.DayTime,

				new FlavorTextBestiaryInfoElement("Mods.TerrariMixed.Bestiary.NPC_Copper_1")
			]);
		}
	}
	public class NPC_Copper_2 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.DemonEye];
		}

		public override void SetDefaults() {
			NPC.width = 19;
			NPC.height = 12;
			NPC.damage = 27;
			NPC.defense = 3;
			NPC.lifeMax = 80;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 113f;
			NPC.knockBackResist = 0.3f;
			NPC.aiStyle = NPCAIStyleID.DemonEye;

			AIType = NPCID.DemonEye;
			AnimationType = NPCID.DemonEye;
			Banner = Type;
			BannerItem = ModContent.ItemType<Items_TM_Banners_4>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items_TM_Copper_3>(), 3, 1));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNightMonster.Chance * 0.025f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.NightTime,

				new FlavorTextBestiaryInfoElement("Mods.TerrariMixed.Bestiary.NPC_Copper_2")
			]);
		}
	}
		public class NPC_Copper_3 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			NPC.width = 19;
			NPC.height = 24;
			NPC.damage = 21;
			NPC.defense = 9;
			NPC.lifeMax = 80;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath2;
			NPC.value = 90f;
			NPC.knockBackResist = 0.75f;
			NPC.aiStyle = NPCAIStyleID.Fighter;

			AIType = NPCID.Zombie;
			AnimationType = NPCID.Zombie;
			Banner = Type;
			BannerItem = ModContent.ItemType<Items_TM_Banners_5>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			//npcLoot.Add(ItemDropRule.Common(ItemID.Confetti, 100));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNightMonster.Chance * 0.025f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.NightTime,

				new FlavorTextBestiaryInfoElement("Mods.TerrariMixed.Bestiary.NPC_Copper_3")
			]);
		}
	}
}