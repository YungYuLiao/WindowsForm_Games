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
	public partial class Form1 : Form
	{
		private GuessNumber game;
		public Form1()
		{
			InitializeComponent();
			game = new GuessNumber();	
			lblResult.Text = string.Empty;
		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{
		    game.NewGame();
			lblResult.Text = game.Hint;  //偷看答案用
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
			GuessNumber guess = new GuessNumber();
			GuessResult result = guess.Guess(guessnumber);
			if (result.IsSuccess)
			{
				MessageBox.Show("您答對了!");
			}
			else
			{
				MessageBox.Show("您答錯了!");
				lblResult.Text=result.Hint;
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
			answer = lottery.GenerateRandomNumber(0, 10, 4);
			return answer;
		}
		public GuessResult Guess (int[]gnum)
		{
			//答對了
			if (gnum == answer) { return GuessResult.Success(); }
			//答錯了
			//1.位置和數字都一樣
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
			}
			return GuessResult.Failed(this.Hint);
		}
		public string Hint 
		{
			get { return $"{a}a{b - a}b, anwser = {string.Join(string.Empty, answer)}"; }
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
	
    
