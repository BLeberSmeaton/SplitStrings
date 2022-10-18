var str = "abcdef";
var underscore = "_";
var evenStr = "";
var result = new List<string>();

if (str.Length % 2 != 0)
{
	evenStr = str + underscore;
}
else
{
	evenStr = str;
}

for (int i = 0; i < evenStr.Length; i+=2)
{
	var pair = evenStr.Substring(i,2);
	result.Add(pair);
}

var resultArr = result.ToArray();

foreach (var i in resultArr)
{
	Console.WriteLine(i);
}

