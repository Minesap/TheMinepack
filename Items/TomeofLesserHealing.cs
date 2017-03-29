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
	public class TomeofLesserHealing : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Tome of Lesser Healing";
            AddTooltip("On use you will be inflicted with Potion Sickness for 45 seconds");
            item.width = 20;
			item.height = 20;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.UseSound = SoundID.Item8;
            item.rare = 4;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.maxStack = 1;
            item.healLife = 5;
            item.useTurn = true;
            item.autoReuse = true;
            item.mana = 20;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.PotionSickness, 2700); // Inflicts Potion Sickness debuff for 45 seconds
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpellTome, 1); // 1 Spell Tome
            recipe.AddIngredient(ItemID.LesserHealingPotion, 30); // 30 Lesser Healing Potions
            recipe.AddTile(TileID.Bookcases); // Bookcases
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
