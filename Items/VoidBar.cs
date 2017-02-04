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
	public class VoidBar : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Void Bar";
            AddTooltip("'You feel your sanity drain...'");
            item.width = 10;
			item.height = 10;
            item.rare = 11;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.maxStack = 999;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 1); // 1 Luminite Bar
            recipe.AddIngredient(null, "AntiMatter", 2); // 2 Antimatter
            recipe.AddTile(TileID.LunarCraftingStation); // Ancient Manipulator
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
