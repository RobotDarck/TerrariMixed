using Terraria;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using TerrariMixed.Content.Tiles;

namespace TerrariMixed.Content.Items
{
	public class Item_TM_42 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 7;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(copper: 1);
			Item.ResearchUnlockCount = 99;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(25);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
	public class Item_TM_43 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 7;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(copper: 30);
			Item.ResearchUnlockCount = 99;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(25);
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddIngredient(ItemID.Topaz, 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
	public class Item_TM_44 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 8;
			Item.height = 11;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(silver: 2, copper: 50);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.Lens, 5);
			recipe.AddIngredient(ItemID.Topaz, 1);
			recipe.AddTile(TileID.Solidifier);
			recipe.Register();
		}
	}
	public class Item_TM_45 : ModItem
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
	public class Item_TM_46 : ModItem
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
	public class Item_TM_49 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tile_TM_4>());
			Item.width = 16;
			Item.height = 16;
			Item.SetShopValues(ItemRarityColor.Blue1, Item.buyPrice(silver: 25));
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.Sawmill);
			recipe.Register();
		}
	}
	public class Item_TM_50 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 10;
			Item.height = 9;
			Item.rare = ItemRarityID.Green;
			Item.value = Item.buyPrice(copper: 1500);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddIngredient(ItemID.Sapphire, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	public class Item_TM_51 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 15;
			Item.height = 11;
			Item.rare = ItemRarityID.Green;
			Item.value = Item.buyPrice(copper: 1150);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.FragmentVortex, 1);
			recipe.AddIngredient(ItemID.Topaz, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Item_TM_52 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 9;
			Item.height = 9;
			Item.rare = ItemRarityID.Green;
			Item.value = Item.buyPrice(copper: 350);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(50);
			recipe.AddIngredient(ItemID.CobaltShield, 1);
			recipe.AddIngredient(ItemID.Lens, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	public class Item_TM_53 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles_TM_Banners>(), (int)Tiles_TM_Banners.StyleID.NPC_TM_22);
			Item.width = 10;
			Item.height = 24;
			Item.SetShopValues(ItemRarityColor.Blue1, Item.buyPrice(silver: 10));
		}
	}
	public class Item_TM_54 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles_TM_Banners>(), (int)Tiles_TM_Banners.StyleID.NPC_TM_21);
			Item.width = 10;
			Item.height = 24;
			Item.SetShopValues(ItemRarityColor.Blue1, Item.buyPrice(silver: 10));
		}
	}
	public class Item_TM_55 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 17;
			Item.height = 14;
			Item.rare = ItemRarityID.Green;
			Item.value = Item.buyPrice(copper: 1150);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.FragmentSolar, 1);
			recipe.AddIngredient(ItemID.Topaz, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Item_TM_56 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 15;
			Item.height = 12;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(copper: 1350);
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 9999;
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tile_TM_3>());
		}
		/*public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(1);
			recipe.AddIngredient(ItemID.TinBar, 1);
			recipe.AddIngredient(ItemID.Amethyst, 3);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}*/
	}
	public class Item_TM_57 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 15;
			Item.height = 12;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(copper: 1350);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tile_TM_2>());
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(1);
			recipe.AddIngredient(ItemID.TinBar, 1);
			recipe.AddIngredient(ItemID.Amethyst, 3);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}
	public class Item_TM_58 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.White;
			Item.value = Item.buyPrice(copper: 340);
			Item.ResearchUnlockCount = 25;
			Item.maxStack = 9999;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.CobaltOre, 1);
			recipe.AddTile(TileID.Loom);
			recipe.Register();
		}
	}
	public class Item_TM_59 : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Tile_TM_1>());
			Item.width = 16;
			Item.height = 16;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(silver: 10);
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.RangerEmblem, 1);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.Sawmill);
			recipe.Register();
		}
	}
}