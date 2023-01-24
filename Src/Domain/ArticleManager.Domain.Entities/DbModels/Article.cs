﻿using RealWorldApp.Commons.Entities;

namespace ArticleManager.Domain.Entities
{
    public class Article : BaseEntity
    {
        
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public bool Favorited { get; set; } = false;
        public int FavoritesCount { get; set; } = 0;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public User Author { get; set; }

        public ICollection<Tag> TagList { get; set; } = new List<Tag>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
