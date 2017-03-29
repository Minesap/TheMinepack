using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Items
{
	public class TomeofSupremeHealing : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tome of Supreme Healing";
            AddTooltip("On use you will be inflicted with Potion Sickness for 90 seconds");
            item.width = 20;
			item.height = 20;
            item.useTime = 80;
            item.useAnimation = 80;
            item.useStyle = 5;
            item.UseSound = SoundID.Item8;
            item.rare = 10;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.maxStack = 1;
            item.healLife = 20;
            item.useTurn = true;
            item.autoReuse = true;
            item.mana = 50;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.PotionSickness, 5400); // Inflicts Potion Sickness debuff for 90 seconds
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TomeofGreaterHealing", 1); // 1 Tome of Greater Healing
            recipe.AddIngredient(ItemID.GreaterHealingPotion, 30); // 30 Greater Healing Potions
            recipe.AddIngredient(ItemID.LunarBar, 10); // 10 Luminite Bars
            recipe.AddTile(TileID.Bookcases); // Bookcases
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
