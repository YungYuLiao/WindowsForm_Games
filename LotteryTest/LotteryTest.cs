using Game.Utility;
using System.Collections;

namespace LotteryTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(true)]
		public void LotteryTest_1A2B_長度是否為4 (bool expected)
		{
			Lottery lottery = new Lottery();
			int[]items =lottery.GenerateRandomNumber(0,10,4);
			bool actual;
			if (items.Length == 4)
			{
				actual = true;
			}
			else actual = false;
			Assert.AreEqual(expected,actual);
		}
	}
}