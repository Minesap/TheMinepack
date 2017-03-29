using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Projectiles
{
    public class GalaxyBreakerProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
        	projectile.CloneDefaults(ProjectileID.StarWrath);
            projectile.name = "Galactic Star";
            projectile.width = 17;
            projectile.height = 45;
            projectile.tileCollide = false;
			projectile.aiStyle = 1;
            aiType = 634;
        }

        public override void AI()
        {
            //this make that the projectile faces the right way 
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            projectile.alpha = (int)projectile.localAI[0] * 2;

            if (projectile.localAI[0] > 600f) //projectile time left before it disappears
            {
                projectile.Kill();
            }

        }
    }
}