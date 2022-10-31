using Game.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class NumberRepeatTest
	{
		[TestCase(false)]
		public void LotteryTest_1A2B_裡面數字是否不同(bool expected)
		{
			Lottery lottery = new Lottery();
			int[] items = lottery.GenerateRandomNumber(10, 4);
			NumberRepeat isRepeat = new NumberRepeat();
			bool result = isRepeat.IsRepeatOrNot(items);
			Assert.AreEqual(expected, result);
		}
	}
}
