namespace music_info_app.Model
{
    public class User:BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Playlist> Playlists{ get; set; }
    }
}
