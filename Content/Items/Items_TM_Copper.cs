using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Items
{
	public class Items_TM_Copper_1 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tiles_TM_Copper_1>());

			Item.width = 16;
			Item.height = 16;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(copper: 50);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CopperCoin, 100);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.Register();
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.SilverCoin, 1);
			recipe2.AddTile(TileID.HeavyWorkBench);
			recipe2.Register();
		}
	}
	public class Items_TM_Copper_2 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 7;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(copper: 2);
			Item.ResearchUnlockCount = 99;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Gel, 1);
			recipe.AddIngredient(ItemID.CopperCoin, 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
	public class Items_TM_Copper_3 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 11;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(silver: 1, copper: 25);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.Lens, 1);
			recipe.AddIngredient(ItemID.CopperCoin, 25);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.Register();
		}
	}
}