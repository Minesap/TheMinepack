using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Projectiles
{
    public class SlimyYoyoProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Code1);
            projectile.name = "Slimy Yoyo";
            projectile.width = 16;
            projectile.scale = 1.05f;
            projectile.height = 16;
            projectile.penetrate = 10;
            projectile.extraUpdates = 1;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 4;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
            aiType = ProjectileID.Code1;
        }
        public override void AI()
        {
        	if (Main.rand.Next(15) == 0)
        	{
            	Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0f, 0f, 406, projectile.damage, projectile.knockBack, projectile.owner, 0f, 0f);
        	}
        }

    }
}
