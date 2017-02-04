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
	public class GelatinousPickaxe : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Gelatinous Pickaxe";
            AddTooltip("Can somehow mine Meteorite");
            item.width = 40;
			item.height = 40;
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 10, 0);

            // Item Animation & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 10;
            item.knockBack = 2;
            item.pick = 55;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GelatinousBar", 15); // 15 Gelatinous Bars
            recipe.AddTile(TileID.Solidifier); // Solidifier
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
