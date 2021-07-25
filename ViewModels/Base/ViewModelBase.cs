using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EnglishDictionary.ViewModels.Base
{
    class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        #region Fields
        private bool _disposed;
        #endregion
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChangeed([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Setter Wrappers
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChangeed(propertyName);
            return true;
        }
        #endregion
        #region Dispose
        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(!disposing || _disposed)
            {
                return;
            }
            _disposed = true;
        }
        #endregion
    }
}
