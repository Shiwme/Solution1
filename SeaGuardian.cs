
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Personalities;
using Terraria.DataStructures;
using Myfirstproject.Projectiles;
using Terraria.ModLoader.Utilities;
using Terraria.Localization;
using Terraria.GameContent.Creative;
using Myfirstproject.Items.Tiles;
using Myfirstproject.Items.Weapons;
using System.IO;

namespace Myfirstproject.Enemies.OverWorldNPC
{
    public class SeaGuardian : ModNPC
    {
        public int Damage = 40;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sea Guardian");
            Main.npcFrameCount[NPC.type] = 4;
        }

        public override void SetDefaults()
        {
            NPC.width = 80;
            NPC.height = 100;
            NPC.damage = 48;
            NPC.defense = 9;
            NPC.lifeMax = 110;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.value = 60f;
            NPC.knockBackResist = 0.5f;
            NPC.aiStyle = 0;
            AnimationType = 10;
            AIType = 156;
            //aiType = 86;
            //animationType = 3;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Ocean.Chance * 0.039f;
        }

        public override void FindFrame(int frameHeight)
        {
            // This makes the sprite flip horizontally in conjunction with the NPC.direction.
            NPC.spriteDirection = NPC.direction;
            NPC.frameCounter++;
            if (NPC.frameCounter < 10)
            {
                NPC.frame.Y = 0 * frameHeight;
            }
            else if (NPC.frameCounter < 20)
            {
                NPC.frame.Y = 1 * frameHeight;
            }
            else if (NPC.frameCounter < 30)
            {
                NPC.frame.Y = 2 * frameHeight;
            }
            else if (NPC.frameCounter < 40)
            {
                NPC.frame.Y = 3 * frameHeight;
            }
            else
            {
                NPC.frameCounter = 0;
            }
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SeaOre>(), 1, 1, 7));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DefenderTrident>(), 15, 1));
        }

        private int attackCounter;
        public override void SendExtraAI(BinaryWriter writer)
        {
            base.SendExtraAI(writer);
        }
    }
}