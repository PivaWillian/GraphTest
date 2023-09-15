namespace GraphTest.Types
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public User Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}