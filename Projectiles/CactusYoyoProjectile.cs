using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Projectiles
{
    public class CactusYoyoProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WoodYoyo);
            projectile.name = "Cactus Yoyo";
            projectile.width = 16;
            projectile.scale = 1.05f;
            projectile.height = 16;
            projectile.penetrate = 6;
            projectile.extraUpdates = 1;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 4;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
            aiType = ProjectileID.WoodYoyo;
        }

    }
}