using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Items.Weapons
{
    public class SlimyYoyo : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/SlimyYoyo";
            return true;
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Code1); // Clones Code 1

            // Item Details
            item.name = "Slimy Yoyo";
            item.rare = 1;
            item.value = Item.sellPrice(0, 0, 50, 0);

            // Item Animation & Sounds
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;

            // Item Stats
            item.melee = true;
            item.damage = 20;
            item.knockBack = 1;

            // Item Functionality
            item.channel = true;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("SlimyYoyoProjectile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GelatinousBar", 10); // 10 Gelatinous Bars
            recipe.AddIngredient(null, "YoyoString", 1); // 1 Yoyo String
            recipe.AddTile(TileID.Solidifier); // Solidifer
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}