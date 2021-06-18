using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interface
{
   public interface IPassLogic
    {
        List<PassViewModel> Read(PassBindingModel model);
        void CreateOrUpdate(PassBindingModel model);
        void Delete(PassBindingModel model);
    }
}
