using MyTestWPFApp.Infrastructure.Commands;
using MyTestWPFApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyTestWPFApp.ViewModels
{
    internal class MainWindowVm : ViewModel
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
        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecuted(object p) 
        {
        Application.Current.Shutdown();
        }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        #endregion

        #endregion
        public MainWindowVm() 
        {

            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);



            #endregion
        }

    }
}
