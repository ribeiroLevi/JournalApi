using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JournalApi.Articles
{
    public class Article
    {
        public Guid Id { get; init; }
        public string Title { get; private set; }
        public string SubTitle { get; private set; }
        public string Text { get; private set; }
        public DateTime Data { get; set; }

        public Article(string title, string subTitle, string text)
        {
            Id = Guid.NewGuid();
            Title = title;
            SubTitle = subTitle;
            Text = text;
            Data = DateTime.Now;
        }
    }
}
