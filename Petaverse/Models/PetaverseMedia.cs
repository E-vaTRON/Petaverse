namespace Petaverse.Models
{
    public class PetaverseMedia : BaseEntity
    {
        public string       MediaUrl    { get; set; } = string.Empty;
        public DateTime     TimeUpload  { get; set; }
        public MediaType    Type        { get; set; }
    }
    public enum MediaType
    {
        Video, Photo
    }
}
