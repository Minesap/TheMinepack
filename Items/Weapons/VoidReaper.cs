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
	public class VoidReaper : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/VoidReaper";
            return true;
        }

        public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.DeathSickle); // Clones Death Sickle

            // Item Details
			item.name = "Void Reaper";
            AddTooltip("Imbued with the madness of the void");
            item.width = 80;
            item.height = 80;
            item.rare = 11;
            item.value = Item.sellPrice(2, 0, 0, 0);

            // Item Animation & Sounds
			item.useTime = 10;
			item.useAnimation = 10;

            // Item Stats
            item.damage = 235;

            // Item Functionality
            item.shoot = mod.ProjectileType("VoidSickle");
            item.shootSpeed *= 3;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 2; // This defines how many projectiles to shoot
            float rotation = MathHelper.ToRadians(10);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 10f; //this defines the distance of the projectiles from the player when the projectile spawns
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .5f; // This defines the projectile rotation and speed. .5f = projectile speed
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DeathSickle, 1); // 1 Death Sickle
            recipe.AddIngredient(null, "VoidBar", 12); // 12 Void Bars
            recipe.AddIngredient(ItemID.FragmentVortex, 5); // 5 Vortex Fragments
            recipe.AddTile(TileID.LunarCraftingStation); // Ancient Manipulator
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
