using Microsoft.Xna.Framework;
using System;
using System.IO;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariMixed.Content.Projectiles
{
	public class Bolt_TM_1 : ModProjectile
	{

		public override void SetDefaults() {
			Projectile.width = 56;
			Projectile.height = 56;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Melee;
			Projectile.timeLeft = 1000;
            Projectile.ignoreWater = true;
            Projectile.light = 2f;
            AIType = ProjectileID.IceBolt;
            Projectile.penetrate = -1;
		}
        

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone) {
			target.AddBuff(BuffID.Frostburn2, 1000);
            Projectile.damage = 33;
		}

		public override void OnKill(int timeLeft) {
			SoundEngine.PlaySound(SoundID.Item51, Projectile.position);
			for (int i = 0; i < 10; i++)
			{
				Dust dust = Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.IceGolem);
				dust.noGravity = true;
				dust.velocity *= 1.5f;
				dust.scale *= 1.5f;
			}
		}
	}
}