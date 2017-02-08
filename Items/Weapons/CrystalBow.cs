using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;
using System.Diagnostics;

namespace TheMinepack.Items.Weapons
{
	public class CrystalBow : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/CrystalBow";
            return true;
        }

        public override void SetDefaults()
        {
            item.name = "Crystal Bow";
            item.damage = 45;
            item.noMelee = true;
            item.ranged = true;
            item.width = 28;
            item.height = 62;
            AddTooltip("Shoots Crystal Arrows that explode into crystal shards on hit");
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = 1;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 8f;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("CrystalArrow"), damage, knockBack, player.whoAmI, 0f, 0f); //This is spawning a projectile of type FrostburnArrow using the original stats
            return false;
        }
    }
}
