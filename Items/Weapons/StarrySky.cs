using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Items.Weapons {
public class StarrySky : ModItem
{
    public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
    {
    	texture = "TheMinepack/Items/Weapons/StarrySky";
    	return true;
    }

	public override void SetDefaults()
	{
		    item.name = "Starry Sky";
            AddTooltip("Fires large stars from the sky that break into more stars\nLarge stars inflict ichor");
		    item.width = 28;
            item.height = 30;
            item.damage = 60;
		    item.magic = true;
            item.mana = 10;
            item.noMelee = true;
		    item.useAnimation = 35;
		    item.useTime = 35;
            item.useStyle = 5;
		    item.useTurn = true;
            item.autoReuse = true;
            item.knockBack = 6f;
		    item.UseSound = SoundID.Item8;   
		    item.value = Item.sellPrice(0, 10, 0, 0);
		    item.rare = 6;
		    item.shoot = mod.ProjectileType("StarrySkyProjectileLarge");
		    item.shootSpeed = 15;
	}

    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
            int numberProjectiles = 3;
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.01f;
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.01f;
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
    }

    public override void AddRecipes()
    {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GalactaniteBar", 10); // 10 Galactanite Bars
            recipe.AddTile(TileID.MythrilAnvil); // Mythril Anvil
            recipe.SetResult(this);
            recipe.AddRecipe();
    }
}}