using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishDictionary.ViewModels.Base;

namespace EnglishDictionary.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Fileds
        private string _title = "EnglishDictionary";
        /// <summary>Версия программы.</summary>
        private string _statusBarVersionOfProgramm = "version 1.2";

        #endregion
        #region Properties
        /// <summary>Свойство заголовка окна</summary>
        public string Title { get => _title; private set => Set(ref _title, value); }

        /// <summary>Версия программы. Как сделать версию программы.</summary>
        public string StatusBarVersionOfProgramm { get => _statusBarVersionOfProgramm; set => Set(ref _statusBarVersionOfProgramm, value); }
        #endregion
    }
}
