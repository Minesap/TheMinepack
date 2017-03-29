using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Items
{
	public class PlanetCore : ModItem
	{
		public override void SetDefaults()
		{
            // Item Details
			item.name = "Planetary Core";
            AddTooltip("'It's brimming with the energy of a newborn planet'");
            item.width = 10;
			item.height = 10;
            item.rare = 11;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.maxStack = 999;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(183, 11, 11);
                }
            }
        }

        public override DrawAnimation GetAnimation()
        {
            return new DrawAnimationVertical(5, 14);
        }
    }
}
