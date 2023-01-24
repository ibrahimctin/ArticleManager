using ArticleManager.Domain.Entities;

namespace ArticleManager.Domain.Application.Contracts.Persistence
{
    public interface IArticleRepository
    {

        Task AddArticleAsync(Article article);
        Task<List<Article>> GetAllArticle(int limit, int offset);
        Task<List<Article>> GetAllArticleForUser(User user, int limit, int offset);
        void DeleteArticle(Article article);
    }
}
