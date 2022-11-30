namespace music_info_app.Model
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Song> Songs { get; set; }
        public int SongCount { get; set; }
    }
}
