using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Items.Weapons
{
    public class CactusYoyo : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/CactusYoyo";
            return true;
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodYoyo); // Clones Wooden Yoyo

            // Item Details
            item.name = "Cactus Yoyo";
            item.rare = 0;
            item.value = Item.sellPrice(0, 0, 0, 30);

            // Item Animation & Sounds
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 5;

            // Item Stats
            item.melee = true;
            item.damage = 12;
            item.knockBack = 2;

            // Item Functionality
            item.channel = true;
            item.autoReuse = false;
            item.shoot = mod.ProjectileType("CactusYoyoProjectile");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cactus, 20); // 20 Cacti
            recipe.AddIngredient(ItemID.Cobweb, 10); // 10 Cobweb
            recipe.AddTile(TileID.WorkBenches); // Workbenches
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}