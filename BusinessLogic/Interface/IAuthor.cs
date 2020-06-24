using BussinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLogic.Interface
{
    public interface IAuthor
    {
        List<AuthorViewModel> Read(AuthorBindingModel model);
        void CreateOrUpdate(AuthorBindingModel model);
        void Delete(AuthorBindingModel model);
    }
}
