namespace HttpStudy.Filters;

using HttpStudy.Models;

internal class LinqOrder
{
    public static void OrderArtists(List<Music> musics)
    {
        var artists = musics
            .OrderBy(music => music.Artist)
            .Select(music => music.Artist)
            .Distinct()
            .ToList();
    }
}
