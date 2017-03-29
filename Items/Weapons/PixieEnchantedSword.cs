using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Items.Weapons {
public class PixieEnchantedSword : ModItem
{
    public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
    {
    	texture = "TheMinepack/Items/Weapons/PixieEnchantedSword";
    	return true;
    }

	public override void SetDefaults()
	{
		    item.name = "Pixie-Enchanted Sword";
            AddTooltip("'Pixies are often a more aggressive fae.\nIt makes great sense that they would provide heroes with swords as fine as this.'");
		    item.width = 54;
            item.height = 54;
            item.damage = 65;
		    item.melee = true;
		    item.useAnimation = 20;
		    item.useTime = 20;
            item.useStyle = 1;
		    item.useTurn = true;
            item.autoReuse = true;
            item.knockBack = 1;
		    item.UseSound = SoundID.Item1;   
		    item.value = Item.sellPrice(0, 10, 0, 0);
		    item.rare = 6;
            item.shoot = ProjectileID.DiamondBolt;
		    item.shootSpeed = 6;
	}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
            int numberProjectiles = 4; // shoots 4 projectiles
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // Projectile Spread
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
    }

        public override void AddRecipes()
    {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Excalibur, 1); // Excalibur
            recipe.AddIngredient(ItemID.PixieDust, 20); // 20 Pixie Dust
            recipe.AddIngredient(ItemID.SoulofMight, 5); // 5 Souls of Might
            recipe.AddTile(TileID.MythrilAnvil); // Mythril Anvil
            recipe.SetResult(this);
            recipe.AddRecipe();
    }
}}