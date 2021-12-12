using System;

public class SoundTest{
	static void wav(string path){
		System.Media.SoundPlayer player = new System.Media.SoundPlayer(path);
		player.PlaySync();
		Console.Write("ok");
	}
	
	//wont work 
	/*static void mp3(string path){
		WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

		wplayer.URL = path;
		wplayer.Controls.Play();
	}*/

	public static void Main(string[]args){
		wav(args[0]);
	}
}
