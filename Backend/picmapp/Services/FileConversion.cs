namespace Backend.picmapp.Services;

public static class FileConversion
{
    public static byte[] GetBytes(IFormFile formFile)
    {
        var memoryStream = new MemoryStream();
        formFile.CopyTo(memoryStream);
        return memoryStream.ToArray();
    }
}