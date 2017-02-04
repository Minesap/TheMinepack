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
	public class AncientDusk : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/AncientDusk";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
            item.name = "Ancient Dusk";
            AddTooltip("'A cursed blade used by the fiends of the underworld'\nRight Click - Enrage yourself!");
            item.width = 50;
            item.height = 50;
            item.rare = 4;
            item.value = Item.sellPrice(0, 15, 0, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 42;
            item.knockBack = 5;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
        }

        // Alt use stuffs
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 4;
                item.UseSound = SoundID.Item119;
                item.useTime = 80;
                item.useAnimation = 80;
                player.AddBuff(mod.BuffType("Enraged"), 600);
            }
            else
            {
                item.useStyle = 1;
                item.UseSound = SoundID.Item1;
                item.useTime = 18;
                item.useAnimation = 18;
            }

            return base.CanUseItem(player);
        }

        // Recipe
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("AncientObsidianSword", 1); // Ancient Obsidian Sword
            recipe.AddIngredient("AncientBoneSword", 1); // Ancient Bone Sword
            recipe.AddIngredient("PharaohsAncientSword", 1); // Pharaoh's Ancient Sword
            recipe.AddTile(TileID.Anvils); // Anvil
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
