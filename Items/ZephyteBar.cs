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
	public class ZephyteBar : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Zephyte Bar";
            AddTooltip("'Imbued with the power of wind'");
            item.width = 10;
			item.height = 10;
            item.rare = 2;
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.maxStack = 999;
		}

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(25, 155, 255);
                }
            }
        }

        /*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ZephyteOre", 4); // 4 Zephyte Ore
            recipe.AddTile(TileID.Furnaces); // Solidifier
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
	}
}
