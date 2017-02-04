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
	public class AntiMatter : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Antimatter";
            AddTooltip("'An anomaly of the universe'");
            item.width = 10;
			item.height = 10;
            item.rare = 10;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.maxStack = 999;
        }
	}
}
