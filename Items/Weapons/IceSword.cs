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
	public class IceSword : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/IceSword";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
            item.name = "Ice Sword";
            item.width = 40;
            item.height = 40;
            item.rare = 0;
            item.value = Item.sellPrice(0, 0, 0, 75);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 22;
            item.useAnimation = 22;
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
			recipe.AddIngredient(ItemID.IceBlock, 30); // 30 Ice Blocks
			recipe.AddTile(TileID.Anvils); // Anvils
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
