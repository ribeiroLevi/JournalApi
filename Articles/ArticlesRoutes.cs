using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JournalApi.Articles;
using JournalApi.Data;

namespace JournalApi.Articles
{
    public static class ArticlesRoutes
    {
        public static void AddRoutesArticles(this WebApplication app)
        {
            var articleRoutes = app.MapGroup("/Articles");

            articleRoutes.MapPost(
                "",
                async (AddArticleRequest request, AppDbContext context) =>
                {
                    var newArticle = new Article(request.Title, request.SubTitle, request.Text);
                    if (request.Title.Length > 30)
                    {
                        throw new Exception("Title Too Big,, keep it below 30 characters");
                    }
                    else if (request.SubTitle.Length > 40)
                    {
                        throw new Exception("SubTitle Too Big, keep it below 40 characters");
                    }
                    else if (request.Text.Length > 4000)
                    {
                        throw new Exception("Text Too Big, keep it below 4000 characters");
                    }
                    else
                    {
                        await context.AddAsync(newArticle);
                        await context.SaveChangesAsync();
                        return Results.Ok(newArticle);
                    }
                }
            );
        }
    }
}
