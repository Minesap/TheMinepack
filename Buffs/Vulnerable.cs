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
	public class Vulnerable : ModBuff
	{
		public override void SetDefaults()
		{
            Main.buffNoTimeDisplay[this.Type] = false;
            Main.buffName[this.Type] = "Vulnerable";
            Main.buffTip[this.Type] = "You no longer have invincibility frames";
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.immune)
            {
                player.immune = false;
            }
        }
    }
}
