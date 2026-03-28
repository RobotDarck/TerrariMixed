using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Items
{
	public class Items_TM_Gladiator_1 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 23;
			Item.height = 28;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(silver: 90,copper: 50);
			Item.defense = 8;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.noKnockback = true;
			player.endurance = 1f - (0.1f * (1f - player.endurance));
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.GladiatorHelmet, 1);
			recipe.AddIngredient(ItemID.GladiatorBreastplate, 1);
			recipe.AddIngredient(ItemID.GladiatorLeggings, 1);
			recipe.AddIngredient(ItemID.Marble, 75);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}