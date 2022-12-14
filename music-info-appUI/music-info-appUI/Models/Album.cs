namespace music_info_app.Entities
{
    public class Album : BaseEntity
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public int SongCount { get; set; }
    }
}
