using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuartusPinNameGenerator {
	public partial class SegForm : Form {

		TextBox[] segBoxes;
		string[] remoteVariableNameData;
		Button triggerBtn;
		SegForm? existedSegForm;

		public SegForm(string formTitle, ref string[] varNames, Button triggerBtn) {
			InitializeComponent();
			// segBox7 is for digit point
			segBoxes = new TextBox[] {
				segBox0, segBox1, segBox2, segBox3, segBox4, segBox5, segBox6, segBox7
			};

			// TODO: receive the data and restore the textboxes
			this.Text = formTitle;
			remoteVariableNameData = varNames;
			for (int i = 0; i < segBoxes.Length; i++) {
				segBoxes[i].Text = varNames[i];
			}

			this.triggerBtn = triggerBtn;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			// sync the variable name in textboxes
			if (checkBox1.Checked) {
				// read only without digit point
				for (int i = 1; i < segBoxes.Length - 1; i++) {
					segBoxes[i].ReadOnly = true;
					segBoxes[i].ForeColor = Color.Green;
					segBoxes[i].Text = segBox0.Text;
				}
			} else {
				for (int i = 1; i < segBoxes.Length - 1; i++) {
					segBoxes[i].ReadOnly = false;
					segBoxes[i].ForeColor = Color.Black;
				}
			}
		}

		private void postfixBtn_Click(object sender, EventArgs e) {
			checkBox1.Checked = false;
			for (int i = 0; i < segBoxes.Length - 1; i++) {
				segBoxes[i].Text += $"[{i}]";
			}
		}

		private void segBox0_TextChanged(object sender, EventArgs e) {
			if (checkBox1.Checked) { // sync the field
				for (int i = 1; i < segBoxes.Length - 1; i++) {
					segBoxes[i].Text = segBox0.Text;
				}
			}
		}

		private void clearBtn_Click(object sender, EventArgs e) {
			foreach (TextBox box in segBoxes) {
				box.Text = "";
			}
		}

		private void storeBtn_Click(object sender, EventArgs e) {
			bool hasData = false;
			for (int i = 0; i < segBoxes.Length; i++) {
				remoteVariableNameData[i] = segBoxes[i].Text;
				hasData = hasData || remoteVariableNameData[i] != "";
			}

			if (hasData) { // Update main form setting button to green by calling update function
				this.triggerBtn.BackColor = Color.Green;
				this.triggerBtn.ForeColor = Color.White;
			} else {
				this.triggerBtn.BackColor = Color.Gainsboro;
				this.triggerBtn.ForeColor = Color.Black;
			}

			if (MessageBox.Show("儲存成功！你超讚的！\r\n按 OK 一併關掉設定視窗。", "系統通知", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK) {
				this.Close();
			}
		}

	}
}
