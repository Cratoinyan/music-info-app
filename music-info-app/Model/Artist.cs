namespace music_info_app.Model
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public List<Album> Albums { get; set; }
    }
}
