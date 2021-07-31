using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictionary.Infrastructure.Commands
{
    internal class LambdaCommand : Command
    {
        #region Fields
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;
        #endregion
        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;
        public override void Execute(object parameter) => _Execute(parameter);
        public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute)); //Проверка на передачу ссылки
            _CanExecute = CanExecute;
        }
    }
}
