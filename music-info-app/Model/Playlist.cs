namespace music_info_app.Model
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Song> Songs { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
