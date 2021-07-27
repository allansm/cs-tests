using System;
using System.Diagnostics;

public class ShellTest{
	void test(){
		string txt = "/C tasklist";
		System.Diagnostics.Process.Start("CMD.exe",txt);
	}

	public static void Main(){
		Process p = new Process();
		p.StartInfo.CreateNoWindow = true;
            	p.StartInfo.RedirectStandardOutput = true;
            	p.StartInfo.UseShellExecute = false;
            	p.StartInfo.Arguments = "/c dir";
            	p.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            	p.Start();

            	string line;

		while ((line = p.StandardOutput.ReadLine()) != null){
			Console.WriteLine(line);
		}
	}
}
