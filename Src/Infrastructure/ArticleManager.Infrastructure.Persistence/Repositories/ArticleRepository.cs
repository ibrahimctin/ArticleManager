using ArticleManager.Domain.Application.Contracts.Persistence;
using ArticleManager.Domain.Entities;
using ArticleManager.Infrastructure.Persistence.DbContext;
using Microsoft.EntityFrameworkCore;

namespace ArticleManager.Infrastructure.Persistence.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly AppDbContext _context;

        public ArticleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddArticleAsync(Article article)
        {
            await _context.Articles.AddAsync(article);
            
        }

        public void DeleteArticle(Article article)
        {
            _context.Articles.Remove(article);
        }

        public async Task<List<Article>> GetAllArticle(int limit, int offset)
        {
            return await _context.Articles
                 .OrderByDescending(x => x.CreateDate)
                 .Skip(limit * offset)
                 .Take(limit)
                 .Include(x => x.Author)
                 .ToListAsync();
        }

        public async Task<List<Article>> GetAllArticleForUser(User user, int limit, int offset)
        {
            return await _context.Articles
                .Include(ğ => ğ.Author)
                .Where(ğ => ğ.Author.UserName == user.UserName)
                .OrderByDescending(ğ => ğ.CreateDate)
                .Skip(limit * offset)
                .Take(limit)
                .ToListAsync();
        }
    }
}
