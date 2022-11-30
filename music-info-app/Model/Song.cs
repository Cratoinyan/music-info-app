namespace music_info_app.Model
{
    public class Song: BaseModel
    {
        public string Title { get; set; }
        public string Lyrics { get; set; }
        public int Duration { get; set;}
        public string Singer { get; set;}
        public int ListenerCount { get; set;}
    }
}
