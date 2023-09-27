using HttpStudy.Models;

namespace HttpStudy.Filters;

internal class LinqFilter
{
    public static void FilterAllMusicGenres(List<Music> musics)
    {
        var allMusicGenres = musics
            .Select(genres => genres.Genre)
            .Distinct()
            .ToList();
    }
}
