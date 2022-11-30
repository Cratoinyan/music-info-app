namespace music_info_app.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Playlist> Playlists{ get; set; }
    }
}
