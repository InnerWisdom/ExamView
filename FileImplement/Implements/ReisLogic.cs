using BusinessLogic.BindingModels;
using BusinessLogic.Interface;
using BusinessLogic.ViewModels;
using FileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileImplement.Implements
{
    public class ReisLogic : IReisLogic
    {
        private readonly FileDataSingleton source;
        public ReisLogic()
        {
            source = FileDataSingleton.GetInstance();
        }
        public void CreateOrUpdate(ReisBindingModel model)
        {
                Reis element = source.Reiss.FirstOrDefault(rec => rec.company == model.company && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть запись с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = source.Reiss.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Reis();
                    source.Reiss.Add(element);
                }
                element.date = model.date;
                element.company = model.company;

        }
        public void Delete(ReisBindingModel model)
        {
                Reis element = source.Reiss.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    source.Reiss.Remove(element);
                    return;
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
        }
        public List<ReisViewModel> Read(ReisBindingModel model)
        {
                return source.Reiss
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new ReisViewModel
                {
                    Id = rec.Id,
                    date = rec.date,
                    company = rec.company,


                })
                .ToList();
        }
    }
}
