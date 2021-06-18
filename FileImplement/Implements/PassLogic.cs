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
    public class PassLogic : IPassLogic
    {
        private readonly FileDataSingleton instance;
        public PassLogic()
        {
            instance = FileDataSingleton.GetInstance();
        }
        public void CreateOrUpdate(PassBindingModel model)
        {
                Pass element = instance.Passs.FirstOrDefault(rec => rec.name == model.name && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть запись с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = instance.Passs.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Pass();
                    instance.Passs.Add(element);
                }
                element.reisId = model.ReisId;
                element.name = model.name;
                element.numPlace = model.numberPlace;
                element.date = model.date;
                element.grazdanstvo = model.grazdanstvo;
            
        }
        public void Delete(PassBindingModel model)
        {
                Pass element = instance.Passs.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    instance.Passs.Remove(element);
                    return;
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
        }
        public List<PassViewModel> Read(PassBindingModel model)
        {
                return instance.Passs
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
                .ToList();
        }
    }
}
