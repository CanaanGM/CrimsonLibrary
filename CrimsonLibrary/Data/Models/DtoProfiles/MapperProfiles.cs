using AutoMapper;

using CrimsonLibrary.Data.Models.Domain;
using CrimsonLibrary.Data.Models.Dtos;

namespace CrimsonLibrary.Data.Models.DtoProfiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Anime, AnimeCreateDto>().ReverseMap();
            CreateMap<Anime, AnimeDto>().ReverseMap();

            CreateMap<Book, BookCreateDto>().ReverseMap();
            CreateMap<Book, BookDto>().ReverseMap();

            CreateMap<BoughtItem, BoughtItemCreateDto>().ReverseMap();
            CreateMap<BoughtItem, BoughtItemDto>().ReverseMap();

            CreateMap<Exercise, ExerciseCreateDto>().ReverseMap();
            CreateMap<Exercise, ExerciseDto>().ReverseMap();

            CreateMap<Game, GameCreateDto>().ReverseMap();
            CreateMap<Game, GameDto>().ReverseMap();

            CreateMap<Manga, MangaCreateDto>().ReverseMap();
            CreateMap<Manga, MangaDto>().ReverseMap();

            CreateMap<MusicTrack, MusicTrackCreateDto>().ReverseMap();
            CreateMap<MusicTrack, MusicTrackDto>().ReverseMap();

            CreateMap<Workout_BodyBuilding, WorkoutCreateDto>().ReverseMap();
            CreateMap<Workout_BodyBuilding, WorkoutDto>().ReverseMap();


            CreateMap<ApiUser, UserDto>().ReverseMap();

        }
    }
}
