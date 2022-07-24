using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using FazzorMod.Items.Furniture;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace FazzorMod.Items.Furniture
{
    public class tungestnfoundryT : ModTile
    {
		public override void SetStaticDefaults()
		{
			Main.tileTable[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			Main.tileFrameImportant[Type] = true;
			TileID.Sets.DisableSmartCursor[Type] = true;
			TileID.Sets.IgnoredByNpcStepUp[Type] = true;

			TileObjectData.newTile.Height = 82;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			TileObjectData.newTile.CoordinateHeights = new int[] { 82, 48 };
			TileObjectData.addTile(Type);
			AdjTiles = new int[] { TileID.Furnaces };
			AnimationFrameHeight = 6;
		}

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
		{
			Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 166, 48, 32, ModContent.ItemType<tungestnfoundry>());
		}
	}
}