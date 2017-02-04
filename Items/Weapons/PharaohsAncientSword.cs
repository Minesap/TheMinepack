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
	public class PharaohsAncientSword : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/PharaohsAncientSword";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
            item.name = "Pharaoh's Ancient Sword";
            AddTooltip("'It used to be the favorite sword of the Pharaoh...'");
            item.width = 60;
            item.height = 60;
            item.rare = 3;
            item.value = Item.sellPrice(0, 1, 0, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 20;
            item.knockBack = 3;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
        }
    }
}
