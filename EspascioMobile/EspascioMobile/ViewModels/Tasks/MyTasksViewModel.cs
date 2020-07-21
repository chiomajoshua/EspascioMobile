using EspascioMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Essentials;

namespace EspascioMobile.ViewModels.Tasks
{
    public class MyTasksViewModel
    {
        public ObservableCollection<TaskModel> Tasks { get; set; }
        public MyTasksViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>
            {
                new TaskModel
                {
                     Title         = "National Assembly",
                     Description   = "Renovations at the Left Wing of the National Assembly Building",                     
                     Status = "In Progress",
                     Location = "Abuja, Nigeria",
                     ItemImage = "peopleFive.png",
                     StatusImage = "bulletColor.png",
                     Features      = new List<Features>
                      {
                          new Features
                          {
                               DateDetail = "SD: " + DateTime.Now.AddMonths(-2).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          },
                          new Features
                          {
                               DateDetail = "DD: " + DateTime.Now.AddMonths(2).AddDays(4).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          }
                     }
                },
                new TaskModel
                {
                    Title         = "Presidential Quarters",
                     Description   = "Complete Building Renovations",                    
                     Status = "In Progress",
                     Location = "Kano, Nigeria",
                     ItemImage = "peopleOne.png",
                     StatusImage = "bulletColor.png",
                     Features      = new List<Features>
                      {
                          new Features
                          {
                               DateDetail = "SD: " + DateTime.Now.AddMonths(-2).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          },
                          new Features
                          {
                               DateDetail = "DD: " + DateTime.Now.AddMonths(2).AddDays(4).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          }
                     }
                },
                new TaskModel
                {
                     Title         = "National Assembly",
                     Description   = "Renovations at the Left Wing of the National Assembly Building",                    
                     Status = "In Progress",
                     Location = "Lagos, Nigeria",
                     ItemImage = "peopleTwo.png",
                     StatusImage = "bulletColor.png",
                     Features      = new List<Features>
                      {
                          new Features
                          {
                               DateDetail = "SD: " + DateTime.Now.AddMonths(-2).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          },
                          new Features
                          {
                               DateDetail = "DD: " + DateTime.Now.AddMonths(2).AddDays(4).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          }
                     }
                },
                new TaskModel
                {
                     Title         = "National Assembly",
                     Description   = "Renovations at the Left Wing of the National Assembly Building",
                     Status = "In Progress",
                     Location = "Lagos, Nigeria",
                     ItemImage = "peopleThree.png",
                     StatusImage = "bulletGray.png",
                     Features      = new List<Features>
                      {
                          new Features
                          {
                               DateDetail = "SD: " + DateTime.Now.AddMonths(-2).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          },
                          new Features
                          {
                               DateDetail = "DD: " + DateTime.Now.AddMonths(2).AddDays(4).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          }
                     }
                },
                new TaskModel
                {
                     Title         = "National Assembly",
                     Description   = "Renovations at the Left Wing of the National Assembly Building",
                     Status = "In Progress",
                     Location = "Lagos, Nigeria",
                     ItemImage = "peopleFour.png",
                     StatusImage = "bulletGray.png",
                     Features      = new List<Features>
                      {
                          new Features
                          {
                               DateDetail = "SD: " + DateTime.Now.AddMonths(-2).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#f0fbf3"),
                               TxColor = ColorConverters.FromHex("#74d884")
                          },
                          new Features
                          {
                               DateDetail = "DD: " + DateTime.Now.AddMonths(2).AddDays(4).ToShortDateString(),
                               BGColor = ColorConverters.FromHex("#fefbec"),
                               TxColor = ColorConverters.FromHex("#fcd058")
                          }
                     }
                }
            };
        }
    }
}