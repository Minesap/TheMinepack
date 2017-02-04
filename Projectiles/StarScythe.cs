using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Minepack.Projectiles
{
    public class StarScythe : ModProjectile
    {
    	
        public override void SetDefaults()
        {
        	projectile.CloneDefaults(ProjectileID.IceSickle);
            projectile.name = "Starry Scythe";
            projectile.width = 32;
            projectile.scale = 1.15f;
            projectile.height = 32;
			projectile.aiStyle = 18;
			aiType = 274;
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Projectile.NewProjectile(target.position.X + (float)target.velocity.X, target.position.Y - 500, 0, 20, ProjectileID.Starfury, 30, 0f, Main.myPlayer, 0f, 1f);
			Projectile.NewProjectile(target.position.X - 20 + (float)target.velocity.X, target.position.Y - 470, 0, 20, ProjectileID.Starfury, 30, 0f, Main.myPlayer, 0f, 1f);
			Projectile.NewProjectile(target.position.X + 40 + (float)target.velocity.X, target.position.Y - 580, 0, 20, ProjectileID.Starfury, 30, 0f, Main.myPlayer, 0f, 1f);
			
        }
        
        
       
    }
}