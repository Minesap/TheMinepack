using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Items
{
	public class GalactaniteBar : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Galactanite Bar";
            AddTooltip("...");
            item.width = 10;
			item.height = 10;
            item.rare = 8;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.maxStack = 999;
		}

        public override DrawAnimation GetAnimation()
        {
            return new DrawAnimationVertical(7, 6);
        }
    }
}
