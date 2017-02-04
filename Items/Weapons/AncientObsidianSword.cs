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
	public class AncientObsidianSword : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/AncientObsidianSword";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
            item.name = "Ancient Obsidian Sword";
            AddTooltip("'A blade forged in the depths of hell'\nRight Click - Imbues you with ichor and rage");
            item.width = 50;
            item.height = 50;
            item.rare = 3;
            item.value = Item.sellPrice(0, 3, 0, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 30;
            item.knockBack = 3;

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
                item.useTime = 90;
                item.useAnimation = 90;
                item.UseSound = SoundID.Item119;

                player.AddBuff(BuffID.WeaponImbueIchor, 600); // Weapon-Imbue Ichor for 10 Seconds
                player.AddBuff(BuffID.Rage, 600); // Rage for 10 Seconds
            }
            else
            {
                item.useStyle = 1;
                item.useTime = 15;
                item.useAnimation = 15;
                item.UseSound = SoundID.Item1;
            }
            return base.CanUseItem(player);
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 600); // On Fire! for 10 Seconds
        }

    }
}
