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
	public class ZephyteHamaxe : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Zephyte Hamaxe";
            AddTooltip("'It's surprisingly light'");
            item.width = 42;
			item.height = 40;
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 90, 0);

            // Item Animation & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 25;
            item.knockBack = 4;
            item.axe = 22;
            item.hammer = 95;

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
            recipe.AddIngredient(null, "ZephyteBar", 13); // 13 Zephyte Bars
            recipe.AddTile(TileID.Anvils); // Anvils
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
