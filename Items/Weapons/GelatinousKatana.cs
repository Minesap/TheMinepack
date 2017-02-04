using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Items.Weapons
{
	public class GelatinousKatana : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/GelatinousKatana";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
            item.name = "Gelatinous Katana";
            AddTooltip("'How can you even swing this when it's so slippery!'");
            item.width = 34;
            item.height = 36;
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 10, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 18;
            item.knockBack = 2;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GelatinousBar", 12); // 12 Gelatinous Bars
			recipe.AddTile(TileID.Solidifier); // Anvils
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
