using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Projectiles
{
    public class StarrySkyProjectileLarge : ModProjectile
    {
        public override void SetDefaults()
        {
        	projectile.CloneDefaults(ProjectileID.StarWrath);
            projectile.name = "Large Burning Star";
            projectile.width = 12;
            projectile.height = 30;
            projectile.scale = 2.25f;
			projectile.aiStyle = 5;
            aiType = 503;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 900);
            Projectile.NewProjectile(target.position.X + (float)target.velocity.X, target.position.Y - 500, 0, 20, mod.ProjectileType("StarrySkyProjectileSmall"), 30, 0f, Main.myPlayer, 0f, 1f);
			Projectile.NewProjectile(target.position.X - 20 + (float)target.velocity.X, target.position.Y - 470, 0, 20, mod.ProjectileType("StarrySkyProjectileSmall"), 30, 0f, Main.myPlayer, 0f, 1f);
			Projectile.NewProjectile(target.position.X + 40 + (float)target.velocity.X, target.position.Y - 580, 0, 20, mod.ProjectileType("StarrySkyProjectileSmall"), 30, 0f, Main.myPlayer, 0f, 1f);
        }
    }
}