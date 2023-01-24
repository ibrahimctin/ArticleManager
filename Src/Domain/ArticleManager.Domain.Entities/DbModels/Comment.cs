using RealWorldApp.Commons.Entities;

namespace ArticleManager.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public User Author { get; set; }
        public Article Article { get; set; }
    }
}
