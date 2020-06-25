using BankBussinessLogic.HelperInfo;
using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using BussinessLogic.BindingModel;
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
        public List<AuthorViewModel> GetAuthors(ReportBindingModel model)
        {
            var authors = author.Read(new AuthorBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            });
            var list = new List<AuthorViewModel>();
            foreach (var serv in authors)
            {
                var record = new AuthorViewModel
                {
                    FIO = serv.FIO,
                    Name = serv.Name,
                    Birthday =serv.Birthday,
                    Work = serv.Work,
                    DateCreate = serv.DateCreate
                };
                list.Add(record);
            }
            return list;
        }
        public void SaveAuthorsToPdfFile(ReportBindingModel model)
        {
            string title = "Авторы и их статьи";
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = title,
                Authors = GetAuthors(model),
            });
        }
    }
}
