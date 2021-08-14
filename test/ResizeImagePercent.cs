using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class ResizeImagePercent{
	public static void Main(string[]args){
		Image imgToResize = Image.FromFile(args[0]);
		
		  
		int sourceWidth = imgToResize.Width;  
		
		int sourceHeight = imgToResize.Height;
		int p1 = sourceWidth-((int)(sourceWidth*0.25f));
		int p2 = sourceHeight-((int)(sourceHeight*0.25f));

		Size size = new Size(p1,p2);

		float nPercent = 0;  
		float nPercentW = 0;  
		float nPercentH = 0;  
		 
		nPercentW = ((float)size.Width / (float)sourceWidth);  
		
		nPercentH = ((float)size.Height / (float)sourceHeight);  
		if (nPercentH < nPercentW)  
		nPercent = nPercentH;  
		else  
		nPercent = nPercentW;  
		
		int destWidth = (int)(sourceWidth * nPercent);  
		  
		int destHeight = (int)(sourceHeight * nPercent);  
		Bitmap b = new Bitmap(destWidth, destHeight);  
		Graphics g = Graphics.FromImage((System.Drawing.Image)b);  
		g.InterpolationMode = InterpolationMode.HighQualityBicubic;  
		  
		g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);  
		g.Dispose();  
		Image resized = (Image)b;
		resized.Save(args[1],System.Drawing.Imaging.ImageFormat.Png);
	}
}
