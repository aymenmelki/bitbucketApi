using System.Linq;
using System.Net.Http.Headers;


//   APIUrl = "https://bitbucket.org/aymenmelki/test/src/main/FileUser.txt";


//string text = System.IO.File.ReadAllText(@"C:/Users/21658/source/repos/ConsoleApp1/ConsoleApp1/aymen.txt");
string text = System.IO.File.ReadAllText(@"C:/Users/21658/source/repos/ConsoleApp1/ConsoleApp1/aymen.txt");


string[] lines = System.IO.File.ReadAllLines(@"C:/Users/21658/source/repos/ConsoleApp1/ConsoleApp1/aymen.txt");
foreach (string line in lines)
{
    string[] subs = line.Split(' ');

    foreach (var sub in subs)

    {
        string[] sub12 = sub.Split(':');

        Console.WriteLine(sub12[3]);



    }
    
}

var client = new HttpClient();

    client.BaseAddress = new Uri("https://bitbucket.org/aymenmelki/apptest/src/main/Userfile.text");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage response = await client.GetAsync("https://bitbucket.org/aymenmelki/apptest/src/main/Userfile.text");
    Console.WriteLine("response");
var readTask = response.Content.ReadAsStringAsync().ConfigureAwait(false);
var rawResponse = readTask.GetAwaiter().GetResult();
//Console.WriteLine(rawResponse);
