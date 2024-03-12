using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Helpers;
using SharedLibrary.Validations;

namespace SharedLibrary.DTOS
{
    public class CreateMovieDTO : MoviePatchDTO
    {
        [WeightFileValidation(maxWeightOnMegaBytes: 4)]
        [FileTypeValidation(fileTypeGroup: FileTypeGroup.Image)]
        public IFormFile Poster { get; set; }

        [ModelBinder(BinderType = typeof(TypeBinder<List<int>>))]
        public List<int> GenresIDs { get; set; }
        [ModelBinder(BinderType = typeof(TypeBinder<List<CreateMoviesActorDTO>>))]
        public List<CreateMoviesActorDTO> Actors { get; set; }
    }
}
