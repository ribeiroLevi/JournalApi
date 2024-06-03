using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalApi.Articles
{
    public record AddArticleRequest(string Title, string SubTitle, string Text);
}
