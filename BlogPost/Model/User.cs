namespace BlogPost.Model
{
    public class User
    {
        public int userId { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }
        public string? email { get; set; }
        public string? fullName { get; set; }

        public Comment? comments { get; set; }
        public Post? blogPosts { get; set; }
    }
}
