using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetPetByIdUseCase
{
    public ResponseByIdPetJson Execute(int id)
    {
        return new ResponseByIdPetJson
        {
            Id = id,
            Name = "Pudim",
            Type = Communication.Enums.PetType.Dog,
            Birthday = DateTime.Now,
        };
    }
}
