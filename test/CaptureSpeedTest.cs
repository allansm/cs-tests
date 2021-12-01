using System.Drawing.Imaging;

using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System;
using System.Threading;

public class CaptureSpeedTest{
	public static int y = 600;//SystemInformation.VirtualScreen.Height;
	public static int x = 800;//SystemInformation.VirtualScreen.Width;

	public static void capture(){
		Bitmap captureBitmap = new Bitmap(x, y, PixelFormat.Format16bppRgb555);
		Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
		Graphics captureGraphics = Graphics.FromImage(captureBitmap);
		captureGraphics.CopyFromScreen(captureRectangle.Left,captureRectangle.Top,0,0,captureRectangle.Size);
		//captureBitmap.Save(filename+".png",ImageFormat.Png);
		captureGraphics.Dispose();	
	}

	public static long timeToMillis(){
		return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();	
	}

	public static void Main(){
		long start = timeToMillis();
		int i = 0;
		while(timeToMillis()-start < 1000){
			capture();
			i++;
		}
		Console.WriteLine(i);
	}
}
