using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Items.Weapons
{
    public class EmeraldYoyo : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/EmeraldYoyo";
            return true;
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Rally); // Clones Rally

            // Item Details
            item.name = "Emerald Yoyo";
            item.rare = 0;
            item.value = Item.sellPrice(0, 0, 75, 0);

            // Item Animation & Sounds
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;

            // Item Stats
            item.melee = true;
            item.damage = 18;
            item.knockBack = 3;

            // Item Functionality
            item.channel = true;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("EmeraldYoyoProjectile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Emerald, 10); // 10 Emeralds
            recipe.AddIngredient(null, "YoyoString", 1); // 1 Yoyo String
            recipe.AddTile(TileID.Anvils); // Anvils
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}