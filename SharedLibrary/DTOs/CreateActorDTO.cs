using Microsoft.AspNetCore.Http;
using SharedLibrary.Validations;

namespace SharedLibrary.DTOS
{
    public class CreateActorDTO : ActorPatchDTO
    {
        [WeightFileValidation(maxWeightOnMegaBytes: 4)]
        [FileTypeValidation(fileTypeGroup: FileTypeGroup.Image)]
        public IFormFile Photo { get; set; }
    }
}
