using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Myfirstproject.Dusts;

namespace Myfirstproject.Items.Bars
{
    public class SeaOre : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileSpelunker[Type] = true;

            DustType = ModContent.DustType<SeaDust>();
            HitSound = SoundID.Tink; 

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Sea Ore");
            AddMapEntry(new Color(102, 143, 204), name);

            ItemDrop = ItemType<SeaOre>();

            MinPick = 65;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0.5f;
            b = 0.5f;
        }
    }
}