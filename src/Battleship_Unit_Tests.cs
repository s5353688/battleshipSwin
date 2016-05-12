using NUnit.Framework;
using System;
using SwinGameSDK;

namespace Application
{
	[TestFixture ()]
	public class Battleship_Unit_Tests
	{
		[Test ()]
		public void TestCase ()
		{
			Point2D moos = default(Point2D);

			moos = SwinGame.PointAt (1, 1);

			int rows = 0;
			int col = 0;
			rows = Convert.ToInt32(Math.Floor((moos.Y - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
			col = Convert.ToInt32(Math.Floor((moos.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));

			Assert.IsTrue (rows < 0);
			Assert.IsTrue (col < 0);
		}

		[Test ()]
		public void TestCase2 ()
		{
			Point2D mouse = default(Point2D);

			mouse = SwinGame.PointAt (400, 1);

			int row = 0;
			int col = 0;
			row = Convert.ToInt32(Math.Floor((mouse.Y  - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
			col = Convert.ToInt32(Math.Floor((mouse.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));

			Assert.IsTrue (row < 0);
			Assert.AreEqual (col, 1);
		}

		[Test ()]
		public void TestCase3 ()
		{
			Point2D mouse = default(Point2D);

			mouse = SwinGame.PointAt (1, 180);

			int row = 0;
			int col = 0;
			row = Convert.ToInt32(Math.Floor((mouse.Y  - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
			col = Convert.ToInt32(Math.Floor((mouse.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));

			Assert.AreEqual (row, 1);
			Assert.IsTrue (col < 0);
		}

		[Test ()]
		public void PointInCubeRow1Col1 ()
		{
			Point2D mouse = default(Point2D);

			mouse = SwinGame.PointAt (400, 180);

			int row = 0;
			int col = 0;
			row = Convert.ToInt32(Math.Floor((mouse.Y  - UtilityFunctions.FIELD_TOP) / (UtilityFunctions.CELL_HEIGHT + UtilityFunctions.CELL_GAP)));
			col = Convert.ToInt32(Math.Floor((mouse.X - UtilityFunctions.FIELD_LEFT) / (UtilityFunctions.CELL_WIDTH + UtilityFunctions.CELL_GAP)));

			Assert.AreEqual (row, 1);
			Assert.AreEqual (col, 1);
		}
	}
}

