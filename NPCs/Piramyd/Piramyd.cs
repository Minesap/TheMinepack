using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.NPCs.Piramyd
{
    public class Piramyd : ModNPC
    {
        public override void SetDefaults()
        {
            npc.name = "Piramyd";
            npc.displayName = "Piramyd";
            npc.damage = 10;
            npc.aiStyle = 3;
            npc.width = 25;
            npc.height = 20;
            npc.defense = 10;
            npc.lifeMax = 60;
            npc.knockBackResist = 0.5f;
            Main.npcFrameCount[npc.type] = 5;
            animationType = 257;
            aiType = NPCID.AnomuraFungus;
            npc.value = Item.buyPrice(0, 0, 3, 0);
            npc.HitSound = SoundID.NPCHit7;
            npc.DeathSound = SoundID.NPCDeath15;
        }

        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            Tile tile = Main.tile[spawnInfo.spawnTileX, spawnInfo.spawnTileY];
            return spawnInfo.player.ZoneDesert && !Main.snowMoon && !Main.pumpkinMoon ? 0.1f : 0f;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.6f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.5f);
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(25) == 0) // 4% Drop chance
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PharaohsAncientSword"));
            }
        }
    }
}