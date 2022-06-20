using Terraria.tModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace Myfirstproject.Enemies
{

    public class WoodSlime : ModNPC
    {
        public override void SetStaticDefaults(
            DisplayName.SetDefault("Wooden Slime");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[2];
            }

            public override void SetDefaults()
            {
                npc.width = 32;
                npc.height = 15;
                npc.damage = 25;
                npc.defense = 7;
                npc.lifeMax = 60;
                npc.value = 50f;
                npc.aiStyle = 1;
                npc.HitSound = SoundID.NPCHit1;
                npc.DeathSound = SoundID.NPCDeath1;
                aiType = NPCID.GreenSlime;
                animationType = NPCID.GreenSlime;
            }

            public override float SpawnChance(NPCSpawnInfo spawnInfo)
            {
                return SpawnCondition.OverWorldDaySlime.Chance * 0.15f;
            }

            public override void FindFrame(int frameHeight)
            {
                npc.frameCounter++;
                if (npc.frameCounter >= 20)
                {
                    npc.frameCounter = 0;
                }
                npc.frame.Y = (int)npc.frameCounter / 10 * frameHeight;
            }

            public override void NPCLoot()
            {
                Item.NewItem(npc.getRect(),ItemID.Gel,Main.rand.Next(0,9));
                Item.NewItem(npc.getRect(),ItemID.Wood,Main.rand.Next(5,27));
            }
        }
    }