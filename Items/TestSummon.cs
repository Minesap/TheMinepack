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
	public class TestSummon : ModItem
	{
		public override void SetDefaults()
		{
			item.name = "Test Summon Item";
			item.width = 20;
			item.height = 20;
			item.toolTip = "Summons a ball?";
			item.value = 0; // No Value
			item.rare = 11; // Rarity 10
            item.maxStack = 999;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
		}

        public override bool CanUseItem(Player player)
        {
            return NPC.CountNPCS(mod.NPCType("TestBoss")) < 3;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("TestBoss"));
            Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
            return true;
        }

        // Recipe for Test Summon
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10); // 10 Luminite Bar
            recipe.AddIngredient(ItemID.Ectoplasm, 30); // 30 Ectoplasm
            recipe.AddTile(TileID.LunarCraftingStation); // Ancient Manipulator
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
