using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

public class JsonTest{	
	//serializer.Serialize(result)

	static Dictionary<string,object> getJson(string json){
		JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
		//string json = "{ \"name\" : \"allan\",\"lastname\" : \"sm\" }";
		dynamic result = serializer.DeserializeObject(json);
		
		return result;
		/*Dictionary<string,string> arr = new Dictionary<string,string>();

		foreach (KeyValuePair<string, object> entry in result){
			var key = entry.Key;
			var value = entry.Value;

			arr[key] = value;
		}

		return arr;*/

	}

	void arrTest(){
		Dictionary<string,string> arr = new Dictionary<string,string>();
		
		arr["name"] = "allan";
		arr["lastname"] = "sm";
		Console.WriteLine(arr["name"]+" "+arr["lastname"]);

	}
	public static void Main(){
		string js1 = getJson("{'id':0,'result':\"{'name':'allan'}\"}")["result"] as string;
		Console.WriteLine(getJson(js1)["name"]);
	}
}
