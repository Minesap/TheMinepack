using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Projectiles
{
    public class StarScytheProjectile2 : ModProjectile
    {
        public override void SetDefaults()
        {
        	projectile.CloneDefaults(ProjectileID.Starfury);
            projectile.name = "Small Star";
            projectile.width = 22;
            projectile.height = 22;
			projectile.aiStyle = 5;
			aiType = 9;
        }
    }
}