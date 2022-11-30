namespace music_info_app.Model
{
    public class Artist : BaseModel
    {
        public string Name { get; set; }
        public string About { get; set; }
        public List<Album> Albums { get; set; }
    }
}
