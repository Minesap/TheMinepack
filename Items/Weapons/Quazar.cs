using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMindepack.Items.Weapons {
public class Quazar : ModItem
{
	
	
    public override void SetDefaults()
    {
        item.name = "Quazar";
        item.damage = 190;
        item.magic = true;
        item.mana = 13;
        item.width = 48;
        item.height = 48;
        item.useTime = 9;
        item.useAnimation = 18;
        item.useStyle = 5;
        Item.staff[item.type] = true;
        item.toolTip = "todo i guess";
        item.noMelee = true; //so the item's animation doesn't do damage
        item.knockBack = 2.25f;
        item.value = 50000;
        item.rare = 2;
        item.UseSound = SoundID.Item66;
        item.autoReuse = true;
        item.shoot = 645;
        item.shootSpeed = 8f;
    }
    
   
    
    public override bool Shoot(Player player, ref Microsoft.Xna.Framework.Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
    	int i = Main.myPlayer;
		float num72 = item.shootSpeed;
		int num73 = damage;
		float num74 = knockBack;
    	num74 = player.GetWeaponKnockback(item, num74);
    	player.itemTime = item.useTime;
    	Vector2 vector2 = player.RotatedRelativePoint(player.MountedCenter, true);
		Vector2 value = Vector2.UnitX.RotatedBy((double)player.fullRotation, default(Vector2));
		Vector2 vector3 = Main.MouseWorld - vector2;
    	float num78 = (float)Main.mouseX + Main.screenPosition.X - vector2.X;
		float num79 = (float)Main.mouseY + Main.screenPosition.Y - vector2.Y;
		if (player.gravDir == -1f)
		{
			num79 = Main.screenPosition.Y + (float)Main.screenHeight - (float)Main.mouseY - vector2.Y;
		}
		float num80 = (float)Math.Sqrt((double)(num78 * num78 + num79 * num79));
		float num81 = num80;
		if ((float.IsNaN(num78) && float.IsNaN(num79)) || (num78 == 0f && num79 == 0f))
		{
			num78 = (float)player.direction;
			num79 = 0f;
			num80 = num72;
		}
		else
		{
			num80 = num72 / num80;
		}
    	num78 *= num80;
		num79 *= num80;
		int num107 = 10;
		for (int num108 = 0; num108 < num107; num108++)
		{
			vector2 = new Vector2(player.position.X + (float)player.width * 0.5f + (float)(Main.rand.Next(201) * -(float)player.direction) + ((float)Main.mouseX + Main.screenPosition.X - player.position.X), player.MountedCenter.Y - 600f);
			vector2.X = (vector2.X + player.Center.X) / 2f + (float)Main.rand.Next(-200, 201);
			vector2.Y -= (float)(100 * num108);
			num78 = (float)Main.mouseX + Main.screenPosition.X - vector2.X;
			num79 = (float)Main.mouseY + Main.screenPosition.Y - vector2.Y;
			if (num79 < 0f)
			{
				num79 *= -1f;
			}
			if (num79 < 20f)
			{
				num79 = 20f;
			}
			num80 = (float)Math.Sqrt((double)(num78 * num78 + num79 * num79));
			num80 = num72 / num80;
			num78 *= num80;
			num79 *= num80;
			float speedX4 = num78 + (float)Main.rand.Next(-120, 121) * 0.02f;
			float speedY5 = num79 + (float)Main.rand.Next(-120, 121) * 0.02f;
			Projectile.NewProjectile(vector2.X, vector2.Y, speedX4, speedY5, ProjectileID.LunarFlare, num73, num74, i, 0f, (float)Main.rand.Next(10));
		}
		return false;
	}
}}