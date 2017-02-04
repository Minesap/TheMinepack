using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.Buffs
{
	public class Enraged : ModBuff
	{
		public override void SetDefaults()
		{
            Main.buffName[this.Type] = "Enraged";
            Main.buffTip[this.Type] = "The curse strengthens your weapons and weakens your body";
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            // Damage multiplied by 0.2 of weapons base damage
            player.meleeDamage += 0.2f;
            player.magicDamage += 0.2f;
            player.rangedDamage += 0.2f;
            player.thrownDamage += 0.2f;
            player.minionDamage += 0.2f;

            // Crit chance increased by 10
            player.meleeCrit += 10;
            player.magicCrit += 10;
            player.rangedCrit += 10;
            player.thrownCrit += 10;

            // Defense lowered by 5
            player.statDefense -= 5;
        }
    }
}
