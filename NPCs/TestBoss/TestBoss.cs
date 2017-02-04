using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheMinepack.Items;

namespace TheMinepack.NPCs.TestBoss
{
	public class TestBoss : ModNPC
	{
        public override void SetDefaults()
        {
            npc.name = "TestBoss";
            npc.displayName = "Ball"; // Really?
            npc.npcSlots = 10f;
            npc.damage = 500;
            npc.width = 256;
            npc.height = 256;
            npc.defense = 200;
            npc.lifeMax = 1000000; // 1,000,000
            npc.knockBackResist = 0f;
            npc.aiStyle = 51; // Flying AI (I think...)
            Main.npcFrameCount[npc.type] = 2;
            npc.value = Item.buyPrice(1, 0, 0, 0);
            npc.boss = true;
            npc.buffImmune[189] = true; // Daybroken
            npc.buffImmune[153] = true; // Shadowflame
            npc.buffImmune[70] = true; // Venom
            npc.buffImmune[69] = true;  // Ichor
            npc.buffImmune[47] = true; // Frozen
            npc.buffImmune[46] = true; // Chilled
            npc.buffImmune[44] = true; // Frostburn
            npc.buffImmune[39] = true; // Cursed Inferno
            npc.buffImmune[31] = true; // Confused
            npc.buffImmune[24] = true; // On Fire!
            npc.buffImmune[20] = true; // Poison
            npc.timeLeft = NPC.activeTime * 30;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.netAlways = true;
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/joke");
            npc.HitSound = SoundID.NPCHit56;
            npc.DeathSound = SoundID.NPCDeath10;
            bossBag = mod.ItemType("TestBossBag");
        }

        // Boss texture on mini map
        public override void AutoloadHead(ref string headTexture, ref string bossHeadTexture)
        {
            bossHeadTexture = "TheMinepack/NPCs/TestBoss/TestBoss_Head_Boss_";
        }

        // Boss loot
        public override void BossLoot(ref string name, ref int potionType)
        {
            name = npc.displayName;
            potionType = ItemID.GreaterHealingPotion;
        }

        // Treasure Bag Stuff
        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                npc.DropBossBags();
            }
            else
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AntiMatter"), Main.rand.Next(4, 10));
            }
        }
        // Expert stats
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.6f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
        }

        // Checks if players are dead or not
        public override bool CheckActive()
        {
            for (int i = 0; i < 255; ++i)
            {
                if (Main.player[i].active && !Main.player[i].dead) return false;
            }
            return true;
        }

        // Inflicts Vulnerable debuff while boss is alive
        public override bool PreAI()
        {
            Player player = Main.player[npc.target];
            player.AddBuff(mod.BuffType("Vulnerable"), 2);
            return true;
        }

    }
}
