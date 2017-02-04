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
	public class AwakenedDragon : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/AwakenedDragon";
            return true;
        }

        public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.DD2SquireBetsySword); // Clones Flying Dragon

            // Item Details
            item.name = "Awakened Dragon";
            AddTooltip("'The blade burns with the hearts energy'");
            item.width = 55;
            item.height = 55;
            item.rare = 10;
            item.value = Item.sellPrice(2, 0, 0, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 180;
            item.knockBack = 5;

            // Item Functionality
            item.shoot = mod.ProjectileType("AwakenedEnergy");
            item.shootSpeed *= 4;
        }

        // Recipe
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DD2SquireBetsySword, 1); // 1 Flying Dragon
            recipe.AddIngredient("AntiMatter", 5); // 5 Antimatter
            recipe.AddIngredient("VoidBar", 3); // 3 Void Bars
            recipe.AddTile(TileID.LunarCraftingStation); // Ancient Manipulator
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
