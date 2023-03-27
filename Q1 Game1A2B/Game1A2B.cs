using Game.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_Game1A2B
{
	public partial class Game1A2B : Form
	{
		private GuessNumber game;
		public Game1A2B()
		{
			InitializeComponent();
			game = new GuessNumber();
			btnGuess.Enabled = false;
		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{
		    game.NewGame();
			txtGuess.Text = string.Empty;
			txtNumberRecord.Text = string.Empty;	
			lblResult.Text = "請輸入四個不同數字";
			btnGuess.Enabled = true;
		}

		private void btnGuess_Click(object sender, EventArgs e)
		{
			
			
			//取得輸入數字
			int[] guessnumber;	
			try
			{
			   guessnumber = GetInput();
			}
			catch (Exception ex)
			{
			    MessageBox.Show(ex.Message,"警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			//檢查答案是否正確並給出提示
			GuessResult result = game.Guess(guessnumber);
			if (result.IsSuccess)
			{
				MessageBox.Show("恭喜您答對了!");
			}
			else
			{
				MessageBox.Show("您答錯了!");
				lblResult.Text=result.Hint;
				txtNumberRecord.Text += result.Hint;
			}
		}
		public int[] GetInput()
		{
			TextBox txt = this.txtGuess;
			StringSplit stringSplit = new StringSplit();
			NumberRepeat numberRepeat = new NumberRepeat();
			string input = txt.Text;
			//沒輸入
			if (string.IsNullOrEmpty(input))
			{ throw new Exception("您沒輸入，請輸入四個數字後再試一次"); }
			//輸入值非數字
			bool isInt = int.TryParse(input, out int value);
			if (isInt == false){ throw new Exception("請輸入數字"); }
			//輸入數字必須不同
			int[] gnum = stringSplit.Split(input);
			bool isRepeat = numberRepeat.IsRepeatOrNot(gnum);
			if (isRepeat) throw new Exception("四個數字必須不同");
			return gnum;
		}
	}
	public class GuessNumber
	{
		private int[] answer; //這次遊戲的答案
		private int a = 0;
		private int b = 0;
		public int[] NewGame()
		{
			Lottery lottery = new Lottery();
			answer = lottery.GenerateRandomNumber(0,10, 4);
			a = 0;
			b = 0;
			return answer;
		}
		public GuessResult Guess (int[]gnum)
		{    a = 0;
			 b = 0;
			//答錯了
			for (int i = 0; i < answer.Length; i++)
			{
				if (gnum[i] == answer[i])
				{
					a++;
				}
				else if (Array.IndexOf(gnum, answer[i]) >= 0)
				{
					b++;
				}
				if (a==4) { return GuessResult.Success(); }
			}
			return GuessResult.Failed(Hint(gnum));
		}
		public string Hint(int[]gnum) 
		{
			return $"{a.ToString()}A{b.ToString()}B,guessnumber={string.Join(string.Empty, gnum)}\r\n";
		}
		}
	}
	public class GuessResult 
	{
	public static GuessResult Success()
	{
		return new GuessResult { IsSuccess = true, Hint = string.Empty };
	}
	public static GuessResult Failed(string msg)
	{
		return new GuessResult {IsSuccess = false , Hint = msg };
	}
	public bool IsSuccess { get; set; }
	public bool IsFailure => !IsSuccess;
	public string Hint { get; set; }
    }
	
    
