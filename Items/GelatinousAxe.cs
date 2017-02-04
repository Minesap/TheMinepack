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
	public class GelatinousAxe : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Gelatinous Axe";
            item.width = 30;
			item.height = 30;
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 15, 0);

            // Item Animation & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 13;
            item.knockBack = 3;
            item.axe = 12;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GelatinousBar", 13); // 13 Gelatinous Bars
            recipe.AddTile(TileID.Solidifier); // Solidifier
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
