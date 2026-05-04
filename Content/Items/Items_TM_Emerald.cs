using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Items
{
	public class Items_TM_Emerald_1 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 7;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(copper: 60);
			Item.ResearchUnlockCount = 99;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(25);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddIngredient(ItemID.Emerald, 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
	public class Items_TM_Emerald_2 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 11;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(silver: 4);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.Lens, 5);
			recipe.AddIngredient(ItemID.Emerald, 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
}