using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

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
			Banner = Item.NPCtoBanner(NPCID.BlueSlime);
			BannerItem = Item.BannerToItem(Banner);
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			//npcLoot.Add(ItemDropRule.Common(ItemID.Confetti, 100));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldDaySlime.Chance * 0.025f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.DayTime,

				new FlavorTextBestiaryInfoElement("He is shiny, but cheap."),
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
			Banner = Item.NPCtoBanner(NPCID.DemonEye);
			BannerItem = Item.BannerToItem(Banner);
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

				new FlavorTextBestiaryInfoElement("He is shiny, but cheap."),
			]);
		}
	}
		public class NPC_Copper_3 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.ZombieXmas];
		}

		public override void SetDefaults() {
			NPC.width = 19;
			NPC.height = 24;
			NPC.damage = 21;
			NPC.defense = 9;
			NPC.lifeMax = 100;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath2;
			NPC.value = 90f;
			NPC.knockBackResist = 0.75f;
			NPC.aiStyle = NPCAIStyleID.Fighter;

			AIType = NPCID.Zombie;
			AnimationType = NPCID.Zombie;
			Banner = Item.NPCtoBanner(NPCID.Zombie);
			BannerItem = Item.BannerToItem(Banner);
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

				new FlavorTextBestiaryInfoElement("He is shiny, but cheap."),
			]);
		}
	}
}