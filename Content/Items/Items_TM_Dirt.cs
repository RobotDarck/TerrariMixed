using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Items
{
	public class Items_TM_Dirt_1 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tiles_TM_Dirt_1>());

			Item.width = 8;
			Item.height = 16;
			Item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
	public class Items_TM_Dirt_2 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tiles_TM_Dirt_2>());

			Item.width = 8;
			Item.height = 16;
			Item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
	public class Items_TM_Dirt_3 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tiles_TM_Dirt_3>());

			Item.width = 8;
			Item.height = 16;
			Item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.Register();
		}
	}
	public class Items_TM_Dirt_4 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tiles_TM_Dirt_4a>());

			Item.width = 8;
			Item.height = 16;
			Item.rare = ItemRarityID.White;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 6);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}