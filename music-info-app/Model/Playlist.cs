namespace music_info_app.Model
{
    public class Playlist : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Song> Songs { get; set; }
    }
}
