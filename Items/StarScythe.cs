using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Minepack.Items;

namespace Minepack.Items.Weapons {
public class StarScythe : ModItem
{

	public override void SetDefaults()
	{
		item.name = "StarScythe";
		item.width = 60;  
		item.damage = 87;  
		item.melee = true;  
		item.useAnimation = 21;
		item.useStyle = 1;
		item.useTime = 21;
		item.useTurn = true;
		item.knockBack = 8f;  
		item.UseSound = SoundID.Item71;
		item.autoReuse = true;  
		item.height = 56;  
		item.maxStack = 1;
		item.toolTip = "Shoots a starry scythe";
		item.value = 1350000;  
		item.rare = 10; 
		item.shoot = mod.ProjectileType("StarScythe");
		item.shootSpeed = 12f;
	}
}}
