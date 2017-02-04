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
	public class YoyoString : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Yoyo String";
            AddTooltip("Used to craft most yoyos");
            item.width = 20;
			item.height = 20;
            item.rare = 0;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.maxStack = 999;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cobweb, 10); // 10 Cobweb
            recipe.AddTile(TileID.WorkBenches); // Workbenches
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
