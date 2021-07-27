using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;
using System.Threading;

//using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
//using System.Windows.Forms;


public class ShowImageTest{
	public static void Main(String[]args){		
		PictureBox pb1 = new PictureBox();            
		pb1.ImageLocation = args[0];
		pb1.SizeMode = PictureBoxSizeMode.AutoSize;

		Form frm = new Form();
		pb1.Visible = true;
		frm.Controls.Add(pb1);
		frm.ShowDialog();
	}
}
