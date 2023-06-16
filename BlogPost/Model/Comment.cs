namespace BlogPost.Model
{
    public class Comment
    {
        public int commentId { get; set; }
        public string? content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public ICollection<User>? author { get; set; }
        
    }
}
