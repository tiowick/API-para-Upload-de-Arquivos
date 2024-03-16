using CloudStorage.Application.UseCases.Users.UploadProfilePhoto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudStorage.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StorageController : ControllerBase
{


    // Manda para o endpoint e faz o upload do arquivo, foto, video, etc

    [HttpPost]
    public IActionResult uplaodImage(IFormFile file)   // endpoint para subir imagem
    {
        var useCase = new UploadProfilePhotoUserCase(); // instanciado

        useCase.Execute(file);

        return Created();
    }

    // passo 1 concluido
    // passo 2 : Criar uma biblioteca de Classes na Solution
}
