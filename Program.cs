using System.Text.Json;
using HttpStudy.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        List<Music> musics = JsonSerializer.Deserialize<List<Music>>(response)!;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
