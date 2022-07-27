using System;
using System.Windows.Forms;

namespace CarrierAppDeleter.Forms {
	class Program {
		[STAThread]
		public static int Main(string[] args) {
			Application.EnableVisualStyles();
			Application.Run(new MainForm());
			return 0;
		}
	}
}
