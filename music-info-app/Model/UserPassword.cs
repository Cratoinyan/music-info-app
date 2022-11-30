namespace music_info_app.Model
{
    public class UserPassword:BaseModel
    {
        public User User { get; set; }
        public string Password { get; set; }
    }
}
