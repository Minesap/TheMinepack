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
	public class Stellarius : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/Stellarius";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
            item.name = "Stellarius";
            AddTooltip("Fires extremely hot shards of gems at enemies.");
            item.width = 60;
            item.height = 60;
            item.rare = 5;
            item.value = Item.sellPrice(0, 10, 0, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item15;
            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 42;
            item.knockBack = 3;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("StellariusGem");
            item.shootSpeed = 13;
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300); // On Fire! debuff inflicted for 5 seconds
            target.AddBuff(BuffID.CursedInferno, 300); // Cursed Inferno debuff inflicted for 5 seconds
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SwordOfMeteors", 1); // 1 Sword of Meteors
            recipe.AddIngredient(ItemID.Ruby, 3); // 3 Rubies
            recipe.AddIngredient(ItemID.Topaz, 3); // 3 Topaz
            recipe.AddIngredient(ItemID.Sapphire, 3); // 3 Sapphire
            recipe.AddIngredient(ItemID.Amethyst, 3); // 3 Amethyst
            recipe.AddIngredient(null, "CondensedManaCrystal", 1); // 1 Condensed Mana Crystal
            recipe.AddTile(TileID.MythrilAnvil); // Mythril/Orichalcum Anvils
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
