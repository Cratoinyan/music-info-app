namespace music_info_app.Model
{
    public class Album : BaseModel
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public int SongCount { get; set; }
    }
}
