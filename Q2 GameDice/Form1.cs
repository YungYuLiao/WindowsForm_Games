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
	public partial class Form1 : Form
	{
		private DiceNumber game;
		public Form1()
		{
			InitializeComponent();
			game = new DiceNumber();	
		}

		private void btnDice_Click(object sender, EventArgs e)
		{

		}
	}
	public class DiceNumber 
	{
		private int[] answer;
		public int[] NewGame()
		{
			Lottery lottery = new Lottery();
			answer = lottery.GenerateRandomNumber(0, 10, 4);
			return answer;
		}
	}
}
