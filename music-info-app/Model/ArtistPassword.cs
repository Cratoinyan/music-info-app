namespace music_info_app.Model
{
    public class ArtistPassword:BaseModel
    {
        public Artist Artist { get; set; }
        public string Password { get; set; }
    }
}
