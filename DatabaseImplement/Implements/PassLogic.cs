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
     public class PassLogic: IPassLogic
    {
        public void CreateOrUpdate(PassBindingModel model)
        {
            using (var context = new Database())
            {
                Pass element = context.Passs.FirstOrDefault(rec => rec.name == model.name && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть запись с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Passs.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Pass();
                    context.Passs.Add(element);
                }
                element.reisId = model.ReisId;
                element.name = model.name;
                element.numPlace = model.numberPlace;
                element.date = model.date;
                element.grazdanstvo = model.grazdanstvo;
                context.SaveChanges();
            }
        }
        public void Delete(PassBindingModel model)
        {
            using (var context = new Database())
            {
                Pass element = context.Passs.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Passs.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public File<PassViewModel> Read(PassBindingModel model)
        {
            using (var context = new Database())
            {
                return context.Passs
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new PassViewModel
                {
                    Id = rec.Id,
                    reisId = rec.reisId,
                    name = rec.name,
                    numPlace = rec.numPlace,
                    date = rec.date,
                    grazdanstvo = rec.grazdanstvo

                })
                .ToFile();
            }
        }
    }
}
