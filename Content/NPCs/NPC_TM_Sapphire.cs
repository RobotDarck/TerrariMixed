using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using TerrariMixed.Content.Items;

namespace TerrariMixed.Content.NPCs
{	
	public class NPC_Sapphire_1 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults() {
			NPC.width = 15;
			NPC.height = 12;
			NPC.damage = 18;
			NPC.defense = 2;
			NPC.lifeMax = 65;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 120f;
			NPC.knockBackResist = 0.5f;
			NPC.aiStyle = NPCAIStyleID.Slime;
			AIType = NPCID.BlueSlime;
			AnimationType = NPCID.BlueSlime;
			Banner = Type;
			BannerItem = ModContent.ItemType<Items_TM_Banners_10>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ItemID.Sapphire, 5, 1, 3));
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items_TM_Sapphire_1>(), 1, 1, 3));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if (spawnInfo.Player.ZoneNormalCaverns && !Main.dayTime)
			{
				return 0.025f;
			}
			else if (spawnInfo.Player.ZoneGemCave)
			{
				return 0.03f;
			}
			return 0f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				new FlavorTextBestiaryInfoElement("Mods.TerrariMixed.Bestiary.NPC_Sapphire_1")
			]);
		}
	}
	public class NPC_Sapphire_2 : ModNPC
	{
	
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.DemonEye];
		}

		public override void SetDefaults() {
			NPC.width = 19;
			NPC.height = 12;
			NPC.damage = 35;
			NPC.defense = 6;
			NPC.lifeMax = 130;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 250f;
			NPC.knockBackResist = 0.45f;
			NPC.aiStyle = NPCAIStyleID.DemonEye;

			AIType = NPCID.DemonEye;
			AnimationType = NPCID.DemonEye;
			Banner = Type;
			BannerItem = ModContent.ItemType<Items_TM_Banners_11>();
			ItemID.Sets.KillsToBanner[BannerItem] = 50;
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ItemID.Sapphire, 5, 1, 3));
			npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items_TM_Sapphire_2>(), 3, 1));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if (spawnInfo.Player.ZoneNormalCaverns && !Main.dayTime)
			{
				return 0.025f;
			}
			else if (spawnInfo.Player.ZoneGemCave)
			{
				return 0.03f;
			}
			return 0f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				new FlavorTextBestiaryInfoElement("Mods.TerrariMixed.Bestiary.NPC_Sapphire_2")
			]);
		}
	}
}