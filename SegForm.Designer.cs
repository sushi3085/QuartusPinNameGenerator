namespace QuartusPinNameGenerator {
	partial class SegForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			pictureBox1 = new PictureBox();
			checkBox1 = new CheckBox();
			segBox0 = new TextBox();
			segBox1 = new TextBox();
			segBox2 = new TextBox();
			segBox3 = new TextBox();
			segBox4 = new TextBox();
			segBox5 = new TextBox();
			segBox6 = new TextBox();
			postfixBtn = new Button();
			segBox7 = new TextBox();
			clearBtn = new Button();
			storeBtn = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.seg7_index;
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(175, 232);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Font = new Font("Iansui 094", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
			checkBox1.Location = new Point(407, 12);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(108, 24);
			checkBox1.TabIndex = 1;
			checkBox1.Text = "同步變數名";
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// segBox0
			// 
			segBox0.Font = new Font("Consolas", 9.75F);
			segBox0.Location = new Point(307, 34);
			segBox0.Name = "segBox0";
			segBox0.Size = new Size(71, 23);
			segBox0.TabIndex = 2;
			segBox0.TextChanged += segBox0_TextChanged;
			// 
			// segBox1
			// 
			segBox1.Font = new Font("Consolas", 9.75F);
			segBox1.Location = new Point(415, 85);
			segBox1.Name = "segBox1";
			segBox1.Size = new Size(71, 23);
			segBox1.TabIndex = 3;
			// 
			// segBox2
			// 
			segBox2.Font = new Font("Consolas", 9.75F);
			segBox2.Location = new Point(415, 169);
			segBox2.Name = "segBox2";
			segBox2.Size = new Size(71, 23);
			segBox2.TabIndex = 4;
			// 
			// segBox3
			// 
			segBox3.Font = new Font("Consolas", 9.75F);
			segBox3.Location = new Point(307, 221);
			segBox3.Name = "segBox3";
			segBox3.Size = new Size(71, 23);
			segBox3.TabIndex = 5;
			// 
			// segBox4
			// 
			segBox4.Font = new Font("Consolas", 9.75F);
			segBox4.Location = new Point(201, 169);
			segBox4.Name = "segBox4";
			segBox4.Size = new Size(71, 23);
			segBox4.TabIndex = 6;
			// 
			// segBox5
			// 
			segBox5.Font = new Font("Consolas", 9.75F);
			segBox5.Location = new Point(201, 85);
			segBox5.Name = "segBox5";
			segBox5.Size = new Size(71, 23);
			segBox5.TabIndex = 7;
			// 
			// segBox6
			// 
			segBox6.Font = new Font("Consolas", 9.75F);
			segBox6.Location = new Point(307, 127);
			segBox6.Name = "segBox6";
			segBox6.Size = new Size(71, 23);
			segBox6.TabIndex = 8;
			// 
			// postfixBtn
			// 
			postfixBtn.BackColor = Color.AliceBlue;
			postfixBtn.FlatStyle = FlatStyle.Popup;
			postfixBtn.Font = new Font("Iansui 094", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
			postfixBtn.Location = new Point(201, 12);
			postfixBtn.Name = "postfixBtn";
			postfixBtn.Size = new Size(87, 31);
			postfixBtn.TabIndex = 9;
			postfixBtn.Text = "自動後綴";
			postfixBtn.UseVisualStyleBackColor = false;
			postfixBtn.Click += postfixBtn_Click;
			// 
			// segBox7
			// 
			segBox7.Font = new Font("Consolas", 9.75F);
			segBox7.Location = new Point(415, 221);
			segBox7.Name = "segBox7";
			segBox7.Size = new Size(100, 23);
			segBox7.TabIndex = 10;
			// 
			// clearBtn
			// 
			clearBtn.BackColor = Color.LightGoldenrodYellow;
			clearBtn.FlatStyle = FlatStyle.Popup;
			clearBtn.Font = new Font("Iansui 094", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
			clearBtn.Location = new Point(201, 214);
			clearBtn.Name = "clearBtn";
			clearBtn.Size = new Size(87, 30);
			clearBtn.TabIndex = 11;
			clearBtn.Text = "清空欄位";
			clearBtn.UseVisualStyleBackColor = false;
			clearBtn.Click += clearBtn_Click;
			// 
			// storeBtn
			// 
			storeBtn.BackColor = Color.PaleGreen;
			storeBtn.FlatStyle = FlatStyle.Popup;
			storeBtn.Font = new Font("Iansui 094", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
			storeBtn.ForeColor = SystemColors.ControlText;
			storeBtn.Location = new Point(201, 49);
			storeBtn.Name = "storeBtn";
			storeBtn.Size = new Size(87, 30);
			storeBtn.TabIndex = 12;
			storeBtn.Text = "儲存";
			storeBtn.UseVisualStyleBackColor = false;
			storeBtn.Click += storeBtn_Click;
			// 
			// SegForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(527, 256);
			Controls.Add(storeBtn);
			Controls.Add(clearBtn);
			Controls.Add(segBox7);
			Controls.Add(postfixBtn);
			Controls.Add(segBox6);
			Controls.Add(segBox5);
			Controls.Add(segBox4);
			Controls.Add(segBox3);
			Controls.Add(segBox2);
			Controls.Add(segBox1);
			Controls.Add(segBox0);
			Controls.Add(checkBox1);
			Controls.Add(pictureBox1);
			Name = "SegForm";
			Text = "SegForm";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private CheckBox checkBox1;
		private TextBox segBox0;
		private TextBox segBox1;
		private TextBox segBox2;
		private TextBox segBox3;
		private TextBox segBox4;
		private TextBox segBox5;
		private TextBox segBox6;
		private Button postfixBtn;
		private TextBox segBox7;
		private Button clearBtn;
		private Button storeBtn;
	}
}