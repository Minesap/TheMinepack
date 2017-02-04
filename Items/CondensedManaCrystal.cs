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
	public class CondensedManaCrystal : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Condensed Mana Crystal";
            AddTooltip("Increases maximum mana by 40\nCannot use if maximum mana is 180 or higher\n'The crystal lost some of its power during crafting'");
            item.width = 15;
			item.height = 15;
            item.rare = 2;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.maxStack = 999;

            // Item Animation & Sound
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 4;

            // Item Functionality
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.statManaMax >= 180)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override bool UseItem(Player player)
        {
            Main.PlaySound(2, (int)player.position.X, (int)player.position.Y, 29); // item.UseSound = SoundID.Item29;
            player.statManaMax += 40;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ManaCrystal, 3); // 3 Mana Crystals
            // Craftable anywhere
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
