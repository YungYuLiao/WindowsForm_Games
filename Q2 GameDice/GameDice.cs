using Game.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_GameDice
{
	public partial class GameDice : Form
	{
		private DiceNumber game;
		public GameDice()
		{
			InitializeComponent();
			game = new DiceNumber();	
		}

		private void btnDice_Click(object sender, EventArgs e)
		{
			int [] dicenumber = game.NewGame();
			lblDiceNumber1.Text = string.Join(string.Empty, dicenumber);
			int? result = game.Result;
			if (result.HasValue) { lblResult.Text = result.ToString(); }
			else {lblResult.Text = "請繼續投擲，\r\n直到有重複數字為止"; }
		}
	}
	public class DiceNumber 
	{
		private int[] number;
		public int[] NewGame()
		{
			Lottery lottery = new Lottery();
			number = lottery.GenerateRandomDice(1,6, 4);
			return number;
		}
		public int? Result 
		{
			get
			{
				Array.Sort(number);
				int? result;
				if (number[0] == number[1])
				{
					result = number[2] + number[3];
					return result;
				}
				else if (number[1] == number[2])
				{
					result = number[0] + number[3];
					return result;
				}
				else if (number[2] == number[3])
				{
					result = number[0] + number[1];
					return result;
				}
				return null;
			}
		}

	}
}
