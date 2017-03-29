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
	public class ZephytePickaxe : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Zephyte Pickaxe.";
            AddTooltip("'It's surprisingly light'");
            item.width = 36;
			item.height = 36;
            item.rare = 1;
            item.value = Item.sellPrice(0, 1, 10, 0);

            // Item Animation & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 20;
            item.knockBack = 3;
            item.pick = 90;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
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

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ZephyteBar", 15); // 15 Zephyte Bars
            recipe.AddTile(TileID.Anvils); // Anvils
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
