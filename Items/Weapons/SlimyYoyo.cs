using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Items.Weapons {
public class SlimyYoyo : ModItem
{
    public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
    {
    	texture = "TheMinepack/Items/Weapons/SlimyYoyo";
    	return true;
    }

    public override void SetDefaults()
    {
    	item.CloneDefaults(ItemID.Code1);
        item.name = "Slimy Yoyo";
        item.damage = 20;
	item.useTime = 22;
	item.useAnimation = 22;
	item.useStyle = 5;
        item.channel = true;
        item.melee = true;
        item.knockBack = 2;
        item.value = Item.sellPrice(0, 0, 50, 0);
        item.rare = 1;
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
