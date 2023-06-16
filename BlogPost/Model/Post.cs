using System.ComponentModel.DataAnnotations;

namespace BlogPost.Model
{
    public class Post
    {
        
        public int postId { get; set; }
        public string? title { get; set; }
        public string? Content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public ICollection<User>? Author { get; set; }

        public List<Comment> comments { get; set; }
        

        public string? urlImages { get; set; }
    }
}
