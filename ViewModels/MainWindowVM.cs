using MyTestWPFApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestWPFApp.ViewModels
{
    internal class MainWindowVM : ViewModel
    {
        //protected override void Dispose(bool Disposing)
        //{
        //    base.Dispose(Disposing);
        //}
        private string _Title = "Тестовый проект XAML";

        /// <summary>заголовок окна</summary>
        public string Title 
        {
        get => _Title;
        set =>  Set(ref _Title, value); 
        }
    }
}
