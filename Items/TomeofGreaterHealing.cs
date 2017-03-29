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
	public class TomeofGreaterHealing : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tome of Greater Healing";
            AddTooltip("On use you will be inflicted with Potion Sickness for 90 seconds");
            item.width = 20;
			item.height = 20;
            item.useTime = 70;
            item.useAnimation = 70;
            item.useStyle = 5;
            item.UseSound = SoundID.Item8;
            item.rare = 8;
            item.value = Item.sellPrice(0, 25, 0, 0);
            item.maxStack = 1;
            item.healLife = 15;
            item.useTurn = true;
            item.autoReuse = true;
            item.mana = 40;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.PotionSickness, 5400); // Inflicts Potion Sickness debuff for 90 seconds
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TomeofHealing", 1); // 1 Tome of Healing
            recipe.AddIngredient(ItemID.GreaterHealingPotion, 30); // 30 Greater Healing Potions
            recipe.AddIngredient(ItemID.LifeFruit, 5); // 5 Life Fruits
            recipe.AddTile(TileID.Bookcases); // Bookcases
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
