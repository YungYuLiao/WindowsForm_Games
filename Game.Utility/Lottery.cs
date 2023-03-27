using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Utility
{
    public class Lottery
    {
		/// <summary>
		/// 取亂數(洗牌法)
		/// </summary>
		/// <param name="startnumber">開始數字</param>
		/// <param name="totalnumber">結束數字</param>
		/// <param name="targetnumber">要取幾個數字</param>
		/// <returns></returns>

		public int[] GenerateRandomNumber(int startnumber, int totalnumber, int targetnumber)
        {
			//1.產生一原始陣列
			int[] original = new int[totalnumber];
			for (int i = 0; i < original.Length; i++) 
			{
				original[i] = i;
			}
			//2.洗牌
			for (int i = 0; i < original.Length; i++)
			{
				int seed = Guid.NewGuid().GetHashCode();
				var random = new Random(seed);
				int position = random.Next(startnumber, totalnumber); //和哪個位子換數字
				int temp;
				temp = original[i];
				original[i] = original[position];	
				original[position] = temp;	
			}
			//3.輸出結果
			int[]result = new int[targetnumber];
			Array.Copy(original, result, targetnumber);
			return result;
		}
		/// <summary>
		/// 取亂數(洗牌法)
		/// </summary>
		/// <param name="startnumber">結束數字</param>
		/// <param name="totalnumber">結束數字</param>
		/// <param name="targetnumber">要取幾個數字</param>
		/// <returns></returns>
		public int[] GenerateRandomDice(int startnumber,int totalnumber,int targetnumber)
		{

			int[] result = new int[targetnumber];
			for (int i = 0; i < targetnumber ; i++)
			{
				int seed = Guid.NewGuid().GetHashCode();
				var random = new Random(seed);
				int number = random.Next(1, totalnumber+1);
				result[i] = number;	
			}
			return result;
		}
	}
	public class NumberRepeat
	{
		/// <summary>
		/// 判斷陣列中數值是否有重複
		/// </summary>
		/// <param name="items">欲判斷陣列</param>
		/// <returns></returns>
		public bool IsRepeatOrNot(int[] items)
		{
			Dictionary<int, int> dict = new Dictionary<int, int>();
			for (int i = 0; i < items.Length; i++)
			{
				if (dict.ContainsKey(items[i]))
				{
					return true;
				}
				else
				{
					dict.Add(items[i], items[i]);
				}
			}
			return false;
		}
	}
	public class StringSplit 
	{
		/// <summary>
		/// 分割字串成數字陣列
		/// </summary>
		/// <param name="value">欲分割字串</param>
		/// <returns></returns>
		public int[]  Split(string value) 
		{
			int[] number = new int[value.Length];
			for (int i = 0; i < value.Length; i++)
			{
				number[i] += Convert.ToInt32(value.Substring(i, 1));
			}
			return number;
		} 
	}
}
