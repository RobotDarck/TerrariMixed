using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Items
{
	public class Accessories_TM_1 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 5);
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Melee) += 15 / 100f;
			player.GetAttackSpeed(DamageClass.Melee) += 50 / 100f;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Accessories_TM_2 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 5);
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Ranged) += 25 / 100f;
			player.GetAttackSpeed(DamageClass.Ranged) += 50 / 100f;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.RangerEmblem, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Accessories_TM_3 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 5);
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Magic) += 15 / 100f;
			player.GetAttackSpeed(DamageClass.Magic) += 50 / 100f;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SorcererEmblem, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Accessories_TM_4 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 5);
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Summon) += 15 / 100f;
			player.GetAttackSpeed(DamageClass.SummonMeleeSpeed) += 50 / 100f;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SummonerEmblem, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Accessories_TM_5 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 5);
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Melee) += 15 / 100f;
			player.statLifeMax2 += 25;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Accessories_TM_6 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 5);
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Ranged) += 15 / 100f;
			player.statLifeMax2 += 25;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.RangerEmblem, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Accessories_TM_7 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 5);
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Magic) += 15 / 100f;
			player.statLifeMax2 += 25;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SorcererEmblem, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
	public class Accessories_TM_8 : ModItem
	{
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 14;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.buyPrice(gold: 5);
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Summon) += 25 / 100f;
			player.statLifeMax2 += 25;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SummonerEmblem, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
}