namespace Q1_Game1A2B
{
	partial class Game1A2B
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.lblInfo = new System.Windows.Forms.Label();
			this.txtNumberRecord = new System.Windows.Forms.TextBox();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.txtGuess = new System.Windows.Forms.TextBox();
			this.btnGuess = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInfo.Location = new System.Drawing.Point(219, 35);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(55, 16);
			this.lblInfo.TabIndex = 11;
			this.lblInfo.Text = "猜測記錄";
			// 
			// txtNumberRecord
			// 
			this.txtNumberRecord.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtNumberRecord.Location = new System.Drawing.Point(222, 54);
			this.txtNumberRecord.Multiline = true;
			this.txtNumberRecord.Name = "txtNumberRecord";
			this.txtNumberRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNumberRecord.Size = new System.Drawing.Size(216, 203);
			this.txtNumberRecord.TabIndex = 10;
			// 
			// btnNewGame
			// 
			this.btnNewGame.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnNewGame.Location = new System.Drawing.Point(22, 25);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(75, 23);
			this.btnNewGame.TabIndex = 9;
			this.btnNewGame.Text = "新遊戲";
			this.btnNewGame.UseVisualStyleBackColor = true;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblResult.Location = new System.Drawing.Point(20, 96);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(127, 16);
			this.lblResult.TabIndex = 8;
			this.lblResult.Text = "按下新遊戲，開始遊戲";
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtGuess
			// 
			this.txtGuess.Location = new System.Drawing.Point(22, 54);
			this.txtGuess.MaxLength = 4;
			this.txtGuess.Name = "txtGuess";
			this.txtGuess.Size = new System.Drawing.Size(100, 22);
			this.txtGuess.TabIndex = 7;
			// 
			// btnGuess
			// 
			this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnGuess.Location = new System.Drawing.Point(128, 54);
			this.btnGuess.Name = "btnGuess";
			this.btnGuess.Size = new System.Drawing.Size(75, 23);
			this.btnGuess.TabIndex = 6;
			this.btnGuess.Text = "猜看看";
			this.btnGuess.UseVisualStyleBackColor = true;
			this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 283);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.txtNumberRecord);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txtGuess);
			this.Controls.Add(this.btnGuess);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "1A2B Game";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.TextBox txtNumberRecord;
		private System.Windows.Forms.Button btnNewGame;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.TextBox txtGuess;
		private System.Windows.Forms.Button btnGuess;
	}
}

