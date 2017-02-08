using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace YourModName.Items.Weapons
{
    public class BowName : ModItem
    {

        public override void SetDefaults()
        {
            item.name = "Crystal Bow";
            item.damage = 9999999999;
            item.noMelee = true;
            item.ranged = true;
            item.width = 69;
            item.height = 40;
            item.toolTip = "Shoots crystal arrows";
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = 1;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 11;
            item.useSound = 5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("CrystalArrow"), damage, knockBack, player.whoAmI, 0f, 0f); //This is spawning a projectile of type FrostburnArrow using the original stats
            return false; 
        }
    }
}