using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Items
{
	public class Weapon_TM_1 : ModItem
    {
        public override void SetDefaults() {
			Item.width = 8;
			Item.height = 16;
			Item.rare = ItemRarityID.Green;
			Item.useTime = 28;
			Item.useAnimation = 28;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.autoReuse = false;
			Item.UseSound = SoundID.Item5;
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 12; 
			Item.knockBack = 0f;
			Item.noMelee = true;
			Item.shootSpeed = 10f;
            Item.useAmmo = AmmoID.Arrow;
            Item.shoot = 1;
		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Item_TM_57>(), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
    }
	public class Weapon_TM_2 : ModItem
	{
		public override void SetDefaults() {
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 2);
			Item.maxStack = 9999;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.consumable = true;		
			Item.damage = 18;
			Item.knockBack = 1.5f;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.DamageType = DamageClass.Ranged;
			Item.shootSpeed = 12f;
			Item.shoot = ModContent.ProjectileType<Projectiles.Knife_TM_1>();
			Item.ResearchUnlockCount = 99;
		}
		public override void AddRecipes() {
			Recipe recipe = CreateRecipe(100);
			recipe.AddIngredient(ItemID.Lens, 100);
			recipe.AddIngredient(ItemID.Katana, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
	public class Weapon_TM_3 : ModItem
	{
		public override void SetDefaults() {
			Item.useTime = 19;
			Item.useAnimation = 19;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.autoReuse = true;
			Item.damage = 66;
			Item.DamageType = DamageClass.Melee;
			Item.width = 35;
			Item.height = 37;
			Item.shoot = ModContent.ProjectileType<Projectiles.Bolt_TM_1>();
			Item.shootSpeed = 8f;
			Item.crit = 2;
		}

		/*public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			Vector2 target = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f) {
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 3; i++) {
				position = player.Center - new Vector2(Main.rand.NextFloat(401) * player.direction, 600f);
				position.Y -= 100 * i;
				Vector2 heading = target - position;

				if (heading.Y < 0f) {
					heading.Y *= -1f;
				}

				if (heading.Y < 20f) {
					heading.Y = 20f;
				}

				heading.Normalize();
				heading *= velocity.Length();
				heading.Y += Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(source, position, heading, type, damage * 2, knockback, player.whoAmI, 0f, ceilingLimit);
			}

			return false;
		}*/

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) {
			target.AddBuff(BuffID.Frostburn2, 1000);
		}
		public override void AddRecipes() {
		}
	}
}