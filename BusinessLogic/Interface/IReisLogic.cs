using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interface
{
   public interface IReisLogic
    {
        List<ReisViewModel> Read(ReisBindingModel model);
        void CreateOrUpdate(ReisBindingModel model);
        void Delete(ReisBindingModel model);
    }
}
