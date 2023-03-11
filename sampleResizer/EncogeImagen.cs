using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace sampleResizer
{
    public class EncogeImagen
    {
        [FunctionName("EncogeImagen")]
        public void Run([BlobTrigger("imagecontainer/{name}", Connection = "azureactionern_STORAGE")]Stream myBlob,
            [Blob("imageoutputcontainer/{rand-guid}{name}", FileAccess.Write)] Stream outputBlob,
            string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            if (name.Contains("jpg") || name.Contains("JPEG") || name.Contains("JPG") || name.Contains("jpeg"))
                using (var image = SixLabors.ImageSharp.Image.Load(myBlob))
                {
                    image.Mutate(c => c.Resize(100, 100));
                    image.SaveAsJpeg(outputBlob);
                }

        }
    }
}
