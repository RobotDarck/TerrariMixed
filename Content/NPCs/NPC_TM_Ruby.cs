using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace TerrariMixed.Content.NPCs
{
	public class NPC_Ruby_2 : ModNPC
	{
		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.DemonEye];
		}

		public override void SetDefaults() {
			NPC.width = 19;
			NPC.height = 12;
			NPC.damage = 40;
			NPC.defense = 6;
			NPC.lifeMax = 100;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.value = 250f;
			NPC.knockBackResist = 0.45f;
			NPC.aiStyle = NPCAIStyleID.DemonEye;

			AIType = NPCID.DemonEye;
			AnimationType = NPCID.DemonEye;
			Banner = Item.NPCtoBanner(NPCID.DemonEye);
			BannerItem = Item.BannerToItem(Banner);
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
			npcLoot.Add(ItemDropRule.Common(ItemID.Ruby, 5, 1, 3));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.Cavern.Chance * 0.05f;
		}
		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			bestiaryEntry.Info.AddRange([
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Caverns,

				new FlavorTextBestiaryInfoElement("He is shiny, but cheap."),
			]);
		}
	}
}