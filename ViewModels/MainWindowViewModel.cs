using EnglishDictionary.ViewModels.Base;
using System.Windows.Input;
using EnglishDictionary.Infrastructure.Commands;
using System.Windows;
using EnglishDictionary.Models;
using System.Collections.ObjectModel;

namespace EnglishDictionary.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Fileds
        private string _title = "EnglishDictionary";
        /// <summary>Версия программы.</summary>
        private string _statusBarVersionOfProgramm = "version 1.2";
        public ObservableCollection<Word> Words { get; }

        #endregion
        #region Constructor
        public MainWindowViewModel()
        {
            #region Command
            AddWordCommand = new LambdaCommand(OnAddWordCommand, CanAddWordCommand);
            DeleteWordCommand = new LambdaCommand(OnDeleteWordCommand, CanDeleteWordCommand);
            #endregion
        }
        #endregion
        #region Properties
        /// <summary>Свойство заголовка окна</summary>
        public string Title { get => _title; private set => Set(ref _title, value); }

        /// <summary>Версия программы. Как сделать версию программы.</summary>
        public string StatusBarVersionOfProgramm { get => _statusBarVersionOfProgramm; set => Set(ref _statusBarVersionOfProgramm, value); }
        #endregion
        #region Commands
        #region AddWordCommand and DeleteWordCommand
        public ICommand AddWordCommand { get; }
        private bool CanAddWordCommand(object p) => true;
        private void OnAddWordCommand(object p)
        {
            var wordMaxIndex = Words.Count + 1;
            var newWord = new Word
            {
                Id = wordMaxIndex
            };
            Words.Add(newWord);
        }
        public ICommand DeleteWordCommand { get; }
        private bool CanDeleteWordCommand(object p) => p is Word word && Words.Contains(word);
        private void OnDeleteWordCommand(object p)
        {
            if (!(p is Word word)) return;
            Words.Remove(word);
        }
        #endregion

        #endregion
    }
}
