using System;
using System.Diagnostics;

public class ShellTest{
	void test(){
		string txt = "/C tasklist";
		System.Diagnostics.Process.Start("CMD.exe",txt);
	}
	
	void test2(){
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

	string cmd(string command){
		Process p = new Process();
		p.StartInfo.CreateNoWindow = true;
            	p.StartInfo.RedirectStandardOutput = true;
            	p.StartInfo.UseShellExecute = false;
            	p.StartInfo.Arguments = "/c "+command;
            	p.StartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            	p.Start();

            	string line;
		string fulltxt = "";
		while ((line = p.StandardOutput.ReadLine()) != null){
			fulltxt +=line+"\n";
		}
		return fulltxt;
	
	}

	public static void Main(){
		string stxt = new ShellTest().cmd("dir");
		Console.WriteLine(stxt);
	}
}
