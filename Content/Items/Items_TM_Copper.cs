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
}