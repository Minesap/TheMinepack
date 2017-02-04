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
	public class TestBossBag : ModItem
	{
		public override void SetDefaults()
		{
            item.name = "Treasure Bag";
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.toolTip = "Right click to open";
            item.expert = true; // Expert
            bossBagNPC = mod.NPCType("TestBoss");
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            player.QuickSpawnItem(mod.ItemType("AntiMatter"), Main.rand.Next(6, 14));
        }
    }
}
