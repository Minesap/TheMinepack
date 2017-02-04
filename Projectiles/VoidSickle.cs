using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Projectiles
{
    public class VoidSickle : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.DeathSickle);
            projectile.name = "Void Sickle";
            aiType = ProjectileID.DeathSickle;
            projectile.penetrate = 12;
        }

    }
}