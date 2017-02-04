using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Projectiles
{
    public class AwakenedEnergy : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.DD2SquireSonicBoom);
            projectile.name = "Awakened Energy";
            aiType = ProjectileID.DD2SquireSonicBoom;
            projectile.penetrate = 50;
        }

    }
}