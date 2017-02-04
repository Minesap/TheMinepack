using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Minepack.Items;

namespace Minepack.Items.Weapons {
public class SlimyYoyo : ModItem
{
    public override void SetDefaults()
    {
    	item.CloneDefaults(ItemID.Valor);
        item.name = "Slimy Yoyo";
        item.damage = 12;
        item.channel = true;
        item.melee = true;
        item.knockBack = 4;
        item.value = 50000;
        item.rare = 3;
        item.autoReuse = false;
        item.shoot = mod.ProjectileType("SlimyYoyoProjectile");
    }
    
    public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(null, "GelatinousBar", 10);
		recipe.AddIngredient(null, "YoyoString", 1);
        recipe.AddTile(TileID.Solidifier);
        recipe.SetResult(this);
        recipe.AddRecipe();
	}
}}
