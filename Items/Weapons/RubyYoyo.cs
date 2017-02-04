using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Items.Weapons
{
    public class RubyYoyo : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/RubyYoyo";
            return true;
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Rally); // Clones Rally

            // Item Details
            item.name = "Ruby Yoyo";
            item.rare = 0;
            item.value = Item.sellPrice(0, 1, 0, 0);

            // Item Animation & Sounds
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;

            // Item Stats
            item.melee = true;
            item.damage = 19;
            item.knockBack = 3;

            // Item Functionality
            item.channel = true;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("RubyYoyoProjectile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ruby, 10); // 10 Rubies
            recipe.AddIngredient(null, "YoyoString", 1); // 1 Yoyo String
            recipe.AddTile(TileID.Anvils); // Anvils
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}