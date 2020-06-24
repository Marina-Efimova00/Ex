using BussinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic.Interface
{
    public interface IArticle
    {
        List<ArticleViewModel> Read(ArticleBindingModel model);
        void CreateOrUpdate(ArticleBindingModel model);
        void Delete(ArticleBindingModel model);
    }
}
