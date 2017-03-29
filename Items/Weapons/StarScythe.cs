using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Items.Weapons {
public class StarScythe : ModItem
{
    public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
    {
    	texture = "TheMinepack/Items/Weapons/StarScythe";
    	return true;
    }

	public override void SetDefaults()
	{
		    item.name = "Star Scythe";
		    item.width = 60;
            item.height = 56;
            item.damage = 70;
		    item.melee = true;
		    item.useAnimation = 16;
		    item.useStyle = 1;
		    item.useTime = 16;
		    item.useTurn = true;
		    item.knockBack = 4f;
		    item.UseSound = SoundID.Item71;
		    item.autoReuse = true;
		    item.toolTip = "Shoots a starry scythe";
		    item.value = Item.sellPrice(0, 10, 0, 0);
		    item.rare = 6;
		    item.shoot = mod.ProjectileType("StarScytheProjectile");
		    item.shootSpeed = 10f;
	}

    public override void AddRecipes()
    {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GalactaniteBar", 12); // 12 Galactanite Bars
            recipe.AddTile(TileID.MythrilAnvil); // Mythril Anvil
            recipe.SetResult(this);
            recipe.AddRecipe();
    }
}}