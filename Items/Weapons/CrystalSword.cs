using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Items.Weapons
{
	public class CrystalSword : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/CrystalSword";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
            item.name = "Crystal Sword";
            AddTooltip("Shoots out crystal shards");
            item.width = 55;
            item.height = 55;
            item.rare = 5;
            item.value = Item.sellPrice(0, 5, 0, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 40;
            item.knockBack = 6;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
            item.shoot = ProjectileID.CrystalStorm;
            item.shootSpeed = 15;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = Main.rand.Next(1, 4); // shoots 1 to 3 projectiles
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // Projectile Spread
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
		{
            // Recipe 1
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrystalShard, 10); // 10 Crystal Shards
            recipe.AddIngredient(ItemID.Pearlwood, 20); // 20 Pearlwood
            recipe.AddIngredient(ItemID.CobaltBar, 5); // 5 Cobalt Bars
			recipe.AddTile(TileID.Anvils); // Anvils
			recipe.SetResult(this);
			recipe.AddRecipe();

            // Recipe 2
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrystalShard, 10); // 10 Crystal Shards
            recipe.AddIngredient(ItemID.Pearlwood, 20); // 20 Pearlwood
            recipe.AddIngredient(ItemID.PalladiumBar, 5); // 5 Palladium Bars
            recipe.AddTile(TileID.Anvils); // Anvils
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
	}
}
