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
	public class AncientBoneSword : ModItem
	{
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            texture = "TheMinepack/Items/Weapons/AncientBoneSword";
            return true;
        }

        public override void SetDefaults()
		{
            // Item Details
            item.name = "Ancient Bone Sword";
            AddTooltip("'It once was a blade that was wielded by a skeleton king'");
            item.width = 60;
            item.height = 60;
            item.rare = 3;
            item.value = Item.sellPrice(0, 2, 0, 0);

            // Item Animations & Sounds
            item.UseSound = SoundID.Item1;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 1;

            // Item Stats
            item.melee = true;
            item.damage = 24;
            item.knockBack = 5;

            // Item Functionality
            item.useTurn = true;
            item.autoReuse = true;
        }
    }
}
