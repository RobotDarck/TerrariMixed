using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Items
{
	public class Items_TM_Amethyst_1 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 7;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(copper: 16);
			Item.ResearchUnlockCount = 99;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(25);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
	public class Items_TM_Amethyst_2 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 11;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(silver: 1, copper: 75);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.Lens, 5);
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
}