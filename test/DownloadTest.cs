using System;
using System.Net;

public class DownloadTest{
	public static void Main(string[]args){
		WebClient client = new WebClient();
		client.DownloadFile(args[0], args[1]);
	}
}
