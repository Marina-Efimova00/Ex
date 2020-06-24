using BankBussinessLogic.HelperInfo;
using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using BussinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.BusinessLogic
{
    public class ReportLogic
    {
        private readonly IArticle article;
        private readonly IAuthor author;
        public ReportLogic(IArticle article, IAuthor author)
        {
            this.article = article;
            this.author = author;
        }
        public List<ArticleViewModel> GetArticles()
        {
            var articles = article.Read(null);
            var list = new List<ArticleViewModel>();
            foreach (var serv in articles)
            {
                    var record = new ArticleViewModel
                    {
                        Name = serv.Name,
                        DateCreate = serv.DateCreate
                    };
                    list.Add(record);
            }
            return list;
        }
        public List<AuthorViewModel> GetAuthors()
        {
            var authors = author.Read(null);
            var list = new List<AuthorViewModel>();
            foreach (var serv in authors)
            {
                var record = new AuthorViewModel
                {
                    FIO = serv.FIO,
                    Name = serv.Name,
                    Birthday =serv.Birthday,
                    Work = serv.Work,

                };
                list.Add(record);
            }
            return list;
        }
        public void SaveClientsToPdfFile(string fileName)
        {
            string title = "Авторы и их статьи";
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = fileName,
                Title = title,
                Authors = GetAuthors(),
            });
        }
    }
}
