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
	public class SwordOfMeteors : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/SwordOfMeteors";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
			item.name = "Sword of Meteors";
            AddTooltip("Fires meteor waves at foes");
            item.width = 50;
            item.height = 50;
            item.rare = 4;
            item.value = Item.sellPrice(0, 5, 0, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item15;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;

            // Item Stats
			item.melee = true;
            item.damage = 30;
            item.knockBack = 2;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("MeteorSlash");
            item.shootSpeed = 10;
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300); // Inflicts On Fire! Debuff for 5 seconds
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 20); // 20 Meteorite Bars
            recipe.AddIngredient(ItemID.Obsidian, 10); // 10 Obsidian
            recipe.AddIngredient(ItemID.FallenStar, 5); // 5 Fallen Stars
            recipe.AddIngredient(ItemID.MagmaStone, 1); // 1 Magma Stone
			recipe.AddTile(TileID.Anvils); // Anvils
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
