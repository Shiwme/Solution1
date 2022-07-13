
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
    public class Summoner : ModNPC
    {
        public bool SpawnedMinions
        {
            get => NPC.localAI[0] == 1f;
            set => NPC.localAI[0] = value ? 1f : 0f;
        }

        public static int MinionType()
        {
            return ModContent.NPCType<SeaSlime>();
        }

        public static int MinionCount()
        {
            int Count = 5;

            if (Main.expertMode)
            {
                Count += 5;
            }

            if (Main.getGoodWorld)
            {
                Count += 5;
            }

            return Count;
        }
        public int Timer;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Summoner");
            Main.npcFrameCount[NPC.type] = 4;
        }

        public override void SetDefaults()
        {
            NPC.scale = 1.25f;
            NPC.width = 72;
            NPC.height = 96;
            NPC.damage = 48;
            NPC.defense = 9;
            NPC.lifeMax = 110;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.value = 60f;
            NPC.knockBackResist = 0.5f;
            NPC.aiStyle = 0;
            NPC.noTileCollide = false;
            NPC.noGravity = false;
            AIType = 0;
            //aiType = 86;
            //animationType = 3;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.021f;
        }

        public override void FindFrame(int frameHeight)
        {
        }

        public override void AI()
        {
            Timer++;
            if (Timer > 500)
            {
                if (NPC.target < 0 || NPC.target == 255 || Main.player[NPC.target].dead || !Main.player[NPC.target].active)
                {
                    NPC.TargetClosest();
                }
                Player player = Main.player[NPC.target];
                {
                    SpawnMinions();
                }
                Timer = 0;
            }
        }

        private void SpawnMinions()
        {
            if (SpawnedMinions)
            {
                return;
            }
            SpawnedMinions = true;
            if (Main.netMode == NetmodeID.MultiplayerClient)
            {
                return;
            }
            int count = 5;
            var entitySource = NPC.GetSource_FromAI();

            for (int i = 0; i < count; i++)
            {
                int index = NPC.NewNPC(entitySource, (int)NPC.Center.X, (int)NPC.Center.Y, ModContent.NPCType<SeaSlime>(), NPC.whoAmI);
                NPC minionNPC = Main.npc[index];
            }
        }
    }
}