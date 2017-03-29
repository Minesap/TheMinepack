using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Items.Weapons {
public class GalaxyBreaker : ModItem
{
    public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
    {
    	texture = "TheMinepack/Items/Weapons/GalaxyBreaker";
    	return true;
    }

	public override void SetDefaults()
	{
		    item.name = "Galaxy Breaker";
            AddTooltip("Fires homing nebula stars.");
		    item.width = 62;
            item.height = 72;
            item.damage = 150;
		    item.melee = true;
		    item.useAnimation = 12;
		    item.useTime = 12;
            item.useStyle = 1;
		    item.useTurn = true;
            item.autoReuse = true;
            item.knockBack = 6.5f;
		    item.UseSound = SoundID.Item8;   
		    item.value = Item.sellPrice(0, 10, 0, 0);
		    item.rare = 10;
		    item.shoot = mod.ProjectileType("GalaxyBreakerProjectile");
		    item.shootSpeed = 5;
	}

        // Custom Rarity
        /*public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(0, 0, 0);
                }
            }
        }*/

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
            int numberProjectiles = Main.rand.Next(4, 8); // shoots 4 to 7 projectiles
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20)); // Projectile Spread
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
    }

        public override void AddRecipes()
    {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StarWrath, 1); // Star Wrath
            recipe.AddIngredient(null, "MoonHeart", 1); // Heart of the Cosmos
            recipe.AddTile(TileID.LunarCraftingStation); // Ancient Manipulator
            recipe.SetResult(this);
            recipe.AddRecipe();
    }
}}