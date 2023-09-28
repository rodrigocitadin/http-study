using HttpStudy.Models;

namespace HttpStudy.Filters;

internal class LinqFilter
{
    public static void FilterAllMusicGenres(List<Music> musics)
    {
        var allMusicGenres = musics
            .Select(genre => genre.Genre)
            .Distinct()
            .ToList();
    }

    public static void FilterAllArtistGenre(List<Music> musics, string genre)
    {
        var artists = musics
            .Where(music => music.Genre!.Contains(genre))
            .Select(music => music.Artist)
            .Distinct()
            .ToList();
    }
}
