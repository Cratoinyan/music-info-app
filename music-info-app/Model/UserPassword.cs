namespace music_info_app.Model
{
    public class UserPassword
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Password { get; set; }
    }
}
