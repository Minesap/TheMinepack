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
	public class GelatinousBar : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Gelatinous Bar";
            AddTooltip("'You can see right through it!'");
            item.width = 10;
			item.height = 10;
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.maxStack = 999;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 4); // 4 Gel
            recipe.AddTile(TileID.Solidifier); // Solidifier
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
