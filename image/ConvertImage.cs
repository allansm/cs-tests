using System;
using System.Drawing;

public class ConvertImage{
	public static void Main(string[]args){
		Image img = Image.FromFile(args[0]);

		switch (args[2]){
		     case "bmp":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Bmp);
			 break;
		     case "jpg":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Jpeg);
			 break;
		     case "gif":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Gif);
			 break;
		     case "png":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Png);
			 break;
		     case "emf":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Emf);
			 break;
		     case "exif":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Exif);
			 break;
		     case "ico":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Icon);
			 break;
		     case "wmf":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Wmf);
			 break;
		     case "tiff":
			 img.Save(args[1]+"."+args[2], System.Drawing.Imaging.ImageFormat.Tiff);
			 break;
		 }
	}
}
