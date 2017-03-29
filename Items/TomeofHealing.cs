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
	public class TomeofHealing : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tome of Healing";
            AddTooltip("On use you will be inflicted with Potion Sickness for 60 seconds");
            item.width = 20;
			item.height = 20;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 5;
            item.UseSound = SoundID.Item8;
            item.rare = 6;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.maxStack = 1;
            item.healLife = 10;
            item.useTurn = true;
            item.autoReuse = true;
            item.mana = 30;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.PotionSickness, 3600); // Inflicts Potion Sickness debuff for 60 seconds
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TomeofLesserHealing", 1); // 1 Tome of Lesser Healing
            recipe.AddIngredient(ItemID.HealingPotion, 30); // 30 Healing Potions
            recipe.AddIngredient(ItemID.HallowedBar, 10); // 10 Hallowed Bars
            recipe.AddTile(TileID.Bookcases); // Bookcases
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
