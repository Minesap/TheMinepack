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
	public class GelatinousHammer : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Gelatinous Hammer";
            item.width = 35;
			item.height = 35;
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 10, 0);

            // Item Animation & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 20;
            item.useAnimation = 25;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 16;
            item.knockBack = 5;
            item.hammer = 65;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GelatinousBar", 12); // 12 Gelatinous Bars
            recipe.AddTile(TileID.Solidifier); // Solidifier
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
