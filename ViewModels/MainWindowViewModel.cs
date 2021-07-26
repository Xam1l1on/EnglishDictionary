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
        private string _statusBar;

        #endregion
        #region Properties
        /// <summary>Свойство заголовка окна</summary>
        public string Title { get => _title; private set => Set(ref _title, value); }
        public string StatusBar { get => _statusBar; set => Set(ref _statusBar, value); }
        #endregion
    }
}
