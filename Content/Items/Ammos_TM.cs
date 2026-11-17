using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Items
{
    public class Ammo_TM_1 : ModItem
    {
		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 36;
			Item.damage = 12;
			Item.DamageType = DamageClass.Ranged;
			Item.maxStack = Item.CommonMaxStack;
			Item.consumable = true;
			Item.knockBack = 1.5f;
			Item.value = Item.sellPrice(copper: 270);
			Item.shoot = ModContent.ProjectileType<Projectiles.Arrow_TM_1>();
			Item.shootSpeed = 3f;
			Item.ammo = AmmoID.Arrow;
			Item.ResearchUnlockCount = 99;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(25);
			recipe.AddIngredient(ModContent.ItemType<Item_TM_57>(), 5);
			recipe.AddIngredient(ItemID.WoodenArrow, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
    }
}