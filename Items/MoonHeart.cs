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
	public class MoonHeart : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Heart of the Cosmos";
            AddTooltip("'The destroyed core of a celestial horror'");
            item.width = 10;
			item.height = 10;
            item.rare = 11;
            item.expert = true;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.maxStack = 999;
		}

	}
}
