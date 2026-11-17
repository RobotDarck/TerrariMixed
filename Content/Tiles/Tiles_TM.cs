using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace TerrariMixed.Content.Tiles
{
	public class Tile_TM_1 : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileID.Sets.FramesOnKillWall[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.Width = 3;
			TileObjectData.addTile(Type);

			AddMapEntry(new Color(120, 85, 60), Language.GetText("Painting"));
			DustType = DustID.Paint;
		}
	}
	public class Tile_TM_2 : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileShine[Type] = 1100;
			Main.tileSolid[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);

			VanillaFallbackOnModDeletion = TileID.MetalBars;

			AddMapEntry(new Color(200, 200, 200), Language.GetText("MapObject.TinAmethystBar"));
		}

		public override bool TileFrame(int i, int j, ref bool resetFrame, ref bool noBreak) {
			if (!WorldGen.SolidTileAllowBottomSlope(i, j + 1)) {
				WorldGen.KillTile(i, j);
			}
			return true;
		}
	}
		public class Tile_TM_3 : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileTable[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			Main.tileFrameImportant[Type] = true;
			TileID.Sets.DisableSmartCursor[Type] = true;
			TileID.Sets.IgnoredByNpcStepUp[Type] = true;
			DustType = DustID.Dirt;
			AdjTiles = [TileID.WorkBenches];
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.CoordinateHeights = [18];
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			AddMapEntry(new Color(200, 200, 200), Language.GetText("Gladiator work bench"));
		}
		public override void NumDust(int x, int y, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
	}
	public class Tile_TM_4 : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileID.Sets.FramesOnKillWall[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
			TileObjectData.newTile.Height = 2;
			TileObjectData.newTile.Width = 2;
			TileObjectData.newTile.CoordinateHeights = new int[]{ 16, 16 };
			TileObjectData.addTile(Type);

			AddMapEntry(new Color(120, 85, 60), Language.GetText("Windy space"));
			DustType = DustID.Paint;
		}
	}
}