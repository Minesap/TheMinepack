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
		item.width = 60;  //The width of the .png file in pixels divided by 2.
		item.damage = 87;  //Keep this reasonable please.
		item.melee = true;  //Dictates whether this is a melee-class weapon.
		item.useAnimation = 21;
		item.useStyle = 1;
		item.useTime = 21;
		item.useTurn = true;
		item.knockBack = 8f;  //Ranges from 1 to 9.
		item.UseSound = SoundID.Item71;
		item.autoReuse = true;  //Dictates whether the weapon can be "auto-fired".
		item.height = 56;  //The height of the .png file in pixels divided by 2.
		item.maxStack = 1;
		item.toolTip = "Shoots a starry scythe";
		item.value = 1350000;  //Value is calculated in copper coins.
		item.rare = 10;  //Ranges from 1 to 11.
		item.shoot = mod.ProjectileType("StarScythe");
		item.shootSpeed = 12f;
	}
}}
