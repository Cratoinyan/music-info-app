namespace music_info_app.Entities
{
    public class Song: BaseEntity
    {
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public int Duration { get; set;}
        public int ListenerCount { get; set;}
    }
}
