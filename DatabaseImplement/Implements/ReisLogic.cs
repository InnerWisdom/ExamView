using BusinessLogic.BindingModels;
using BusinessLogic.Interface;
using BusinessLogic.ViewModels;
using DatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseImplement.Implements
{
    public class ReisLogic : IReisLogic
    {

        public void CreateOrUpdate(ReisBindingModel model)
        {
            using (var context = new Database())
            {
                Reis element = context.Reiss.FirstOrDefault(rec => rec.company == model.company && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть запись с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Reiss.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Reis();
                    context.Reiss.Add(element);
                }
                element.date = model.date;
                element.company = model.company;
              
                context.SaveChanges();
            }
        }
        public void Delete(ReisBindingModel model)
        {
            using (var context = new Database())
            {
                Reis element = context.Reiss.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Reiss.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public File<ReisViewModel> Read(ReisBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Reiss
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new ReisViewModel
                {
                    Id = rec.Id,
                    date = rec.date,
                    company = rec.company,
                   

                })
                .ToFile();
            }
        }
    }
}