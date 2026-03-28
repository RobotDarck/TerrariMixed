using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using TerrariMixed.Content.Items;

namespace TerrariMixed.Content.Tiles
{
	public class Tiles_TM_Dirt_1 : ModTile
	{
		public const int NextStyleHeight = 40;
		public override void SetStaticDefaults() {
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileID.Sets.HasOutlines[Type] = true;
			TileID.Sets.CanBeSatOnForNPCs[Type] = true;
			TileID.Sets.CanBeSatOnForPlayers[Type] = true;
			TileID.Sets.DisableSmartCursor[Type] = true;AddToArray(ref TileID.Sets.RoomNeeds.CountsAsChair);

			DustType = DustID.Dirt;
			AdjTiles = [TileID.Chairs];
			VanillaFallbackOnModDeletion = TileID.Chairs;

			AddMapEntry(new Color(200, 200, 200), Language.GetText("Dirt chair"));

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
			TileObjectData.newTile.CoordinateHeights = [16, 18];
			TileObjectData.newTile.CoordinatePaddingFix = new Point16(0, 2);
			TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
			TileObjectData.newTile.StyleWrapLimit = 2;
			TileObjectData.newTile.StyleMultiplier = 2;
			TileObjectData.newTile.StyleHorizontal = true;

			TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
			TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
			TileObjectData.addAlternate(1);
			TileObjectData.addTile(Type);
		}
		public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings) {
			return settings.player.IsWithinSnappngRangeToTile(i, j, PlayerSittingHelper.ChairSittingMaxDistance);
		}
		public override void ModifySittingTargetInfo(int i, int j, ref TileRestingInfo info) {
			Tile tile = Framing.GetTileSafely(i, j);

			info.TargetDirection = -1;
			if (tile.TileFrameX != 0) {
				info.TargetDirection = 1;
			}

			info.AnchorTilePosition.X = i;
			info.AnchorTilePosition.Y = j;

			if (tile.TileFrameY % NextStyleHeight == 0) {
				info.AnchorTilePosition.Y++;
			}
		}
		public override bool RightClick(int i, int j) {
			Player player = Main.LocalPlayer;

			if (player.IsWithinSnappngRangeToTile(i, j, PlayerSittingHelper.ChairSittingMaxDistance)) {
				player.GamepadEnableGrappleCooldown();
				player.sitting.SitDown(player, i, j);
			}

			return true;
		}
		public override void MouseOver(int i, int j) {
			Player player = Main.LocalPlayer;

			if (!player.IsWithinSnappngRangeToTile(i, j, PlayerSittingHelper.ChairSittingMaxDistance)) {
				return;
			}

			player.noThrow = 2;
			player.cursorItemIconEnabled = true;
			player.cursorItemIconID = ModContent.ItemType<Items.Items_TM_Dirt_1>();

			if (Main.tile[i, j].TileFrameX / 18 < 1) {
				player.cursorItemIconReversed = true;
			}
		}
	}
	public class Tiles_TM_Dirt_2 : ModTile
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
			AdjTiles = [TileID.Tables];

			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.CoordinateHeights = [16, 18];
			TileObjectData.addTile(Type);

			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);

			AddMapEntry(new Color(200, 200, 200), Language.GetText("Dirt table"));
		}

		public override void NumDust(int x, int y, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
	}
	public class Tiles_TM_Dirt_3 : ModTile
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
			AddMapEntry(new Color(200, 200, 200), Language.GetText("Dirt work bench"));
		}
		public override void NumDust(int x, int y, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
	}
	public class Tiles_TM_Dirt_4a : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileFrameImportant[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileID.Sets.NotReallySolid[Type] = true;
			TileID.Sets.DrawsWalls[Type] = true;
			TileID.Sets.HasOutlines[Type] = true;
			TileID.Sets.DisableSmartCursor[Type] = true;
			TileID.Sets.OpenDoorID[Type] = ModContent.TileType<Tiles_TM_Dirt_4b>();
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
			DustType = DustID.Dirt;
			AdjTiles = [TileID.ClosedDoor];
			AddMapEntry(new Color(200, 200, 200), Language.GetText("Dirt door"));
			TileObjectData.newTile.CopyFrom(TileObjectData.GetTileData(TileID.ClosedDoor, 0));
			TileObjectData.addTile(Type);
		}
		public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings) {
			return true;
		}
		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = 1;
		}
		public override void MouseOver(int i, int j) {
			Player player = Main.LocalPlayer;
			player.noThrow = 2;
			player.cursorItemIconEnabled = true;
			player.cursorItemIconID = ModContent.ItemType<Items_TM_Dirt_4>();
		}
	}
}