using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMinepack.NPCs
{
    public class TheMinepackGlobalNPC : GlobalNPC
    {
        // formula because im dumb
        // 1/# * 100 to give drop chance in %

        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.FireImp) // FIRE IMP
            {
                if (Main.rand.Next(20) == 0) // 5% Drop chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AncientObsidianSword"));
                }
            }      
                  
            if (npc.type == NPCID.Plantera && Main.expertMode) // PLANTERA (Expert Drops)
            {
                if (Main.rand.Next(0) == 0) // 100% Drop chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ChlorophyteOre, Main.rand.Next(60, 80));
                }
            }

            if (npc.type == NPCID.MoonLordCore && Main.expertMode) // MOON LORD (Expert Drops)
            {
                if (Main.rand.Next(0) == 0) // 100% Drop chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MoonHeart"));
                }
            }

            if (npc.type == NPCID.AngryBones || // DUNGEON ENEMIES
                npc.type == NPCID.AngryBonesBig || 
                npc.type == NPCID.AngryBonesBigHelmet || 
                npc.type == NPCID.AngryBonesBigMuscle || 
                npc.type == NPCID.DarkCaster || 
                npc.type == NPCID.CursedSkull)
            {
                if (Main.rand.Next(100) == 0) // 1% Drop chance
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("AncientBoneSword"));
                }
            }
        }
    }
}