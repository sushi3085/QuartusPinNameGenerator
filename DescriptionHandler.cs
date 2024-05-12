using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartusPinNameGenerator {
	internal class DescriptionHandler {
		private static TextBox? descriptionTextBox;

		private static string startupDesc = """
			使用說明：
			將「變數名稱」填入相對應IO裝置旁的「輸入欄位」。

			按下「確定送出　生成文件」按鈕即可選擇CSV輸出的檔名與位置(預設於桌面)。

			- 藍色區域為位於板子右邊的按鈕(溫馨提醒：按下為0)

			- 琥珀色區域為開關的相關設定，欄位雖上下交錯，但具由左至右的排序。

			- 灰色區域為LED相關設定，欄位順序比照琥珀色(開關)區域。

			- 綠色區域為七段顯示器設定，按下相對應的設定按鈕即可開新視窗設定Pin腳名稱。
			""";

		private static string ledDesc = """
			灰色為 LED 腳位設定區域。
			腳位因為排版限制上下錯開，
			但由左至右為 LED 9 ~ 0。
			""";

		private static string switchesDesc = """
			此區域為開關(switches)的相關設定，欄位雖上下交錯，但具由左至右的排序。
			最左為 switch9 最右為 switch0
			請輸入他們各自相對應的 verilog 變數名稱。
			如： sw[8]、swA、swB、sw0、sws[0]
			""";

		private static string segsDesc = """
			此區域為七段顯示器變數設定區，按下相對應的設定按鈕即可開新視窗設定Pin腳名稱。
			填寫圖片對應的變數名稱，於儲存後會以綠色顯示已有資料。
			若欲消除資料僅需清空欄位後儲存。
			新開視窗中有位置對應的七段光源、右下角的 digital pin 腳。
			""";

		private static string buttonDesc = """
			藍色區域為位於板子右邊的按鈕(溫馨提醒：按下為0)
			溫馨叮嚀：按鈕按下為 0、不按下為 1
			相當不直觀，記得反向。
			記得反向！
			""";

		public static void setDescriptionTextBox(TextBox descTextBox) {
			if (descriptionTextBox != null) return;
			descriptionTextBox = descTextBox;
		}

		public static void displayStartUpHelp() {
			if(descriptionTextBox == null)
				throw new AccessViolationException("忘記 binding textbox 了！");
			descriptionTextBox.Text = startupDesc;
		}

		public static void displayLedHelp() {
			if (descriptionTextBox == null)
				throw new AccessViolationException("忘記 binding textbox 了！");
			descriptionTextBox.Text = ledDesc;
		}

		public static void displaySwitchesHelp() {
			if (descriptionTextBox == null)
				throw new AccessViolationException("forgot to bind your textbos...");
			descriptionTextBox.Text = switchesDesc;
		}

		public static void displaySegsHelp() {
			if (descriptionTextBox == null)
				return;
			descriptionTextBox.Text = segsDesc;
		}

		public static void displayButtonHelp() {
			if (descriptionTextBox == null)
				return;
			descriptionTextBox.Text = buttonDesc;
		}
	}
}
