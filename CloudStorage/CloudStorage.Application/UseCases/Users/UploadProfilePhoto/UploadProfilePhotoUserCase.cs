using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudStorage.Application.UseCases.Users.UploadProfilePhoto
{
    public class UploadProfilePhotoUserCase
    {
        public void Execute(IFormFile file) // regra de negócio pracisa validar
        {
            var fileStream = file.OpenReadStream();

            var isImage = fileStream.Is<JointPhotographicExpertsGroup>(); //retornar true or false

            if (isImage == false)
            {
                throw new Exception("The file is not an image.");
            }


        }
    }
    // passo 2 concluido
    // va criar 2 projetos na solution 
}
