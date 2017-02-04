using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.Items
{
    public class WornGodMode : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Worn God Mode";
            item.width = 10;
            item.height = 14;
            item.toolTip = "Now you can wear god mode too!";
            item.value = 0; // No Value
            item.expert = true; // Expert
            item.accessory = true;
            item.defense = 10000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaImmune = true;
            player.iceSkate = true;
            player.noFallDmg = true;
            player.moveSpeed += 10.75f;
            player.statManaMax2 += 400;
            player.manaCost -= 0.99f;
            player.lifeRegen = 200;
        }
    }
}