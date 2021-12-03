using System.Net.Http.Headers;


//   APIUrl = "https://bitbucket.org/aymenmelki/test/src/main/FileUser.txt";
    var client = new HttpClient();

    client.BaseAddress = new Uri("https://api.bitbucket.org/2.0/users/alfasoftdev");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    HttpResponseMessage response = await client.GetAsync("https://api.bitbucket.org/2.0/users/alfasoftdev");
    Console.WriteLine("response");
var readTask = response.Content.ReadAsStringAsync().ConfigureAwait(false);
var rawResponse = readTask.GetAwaiter().GetResult();
Console.WriteLine(rawResponse);


