﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyTestWPFApp.ViewModels.Base
{
    // Базовый класс модели представления
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        

        protected virtual void OnPropertyChanged([CallerMemberName] string? PropertyName = null) 
        {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string? PropertyName = null) 
        {
        if (Equals(field, value)) return false;
        field = value;
            OnPropertyChanged(PropertyName);
            return true;
            

        }
        public void Dispose()
        {
            Dispose(true);
        }
        private bool _Dispose;
        protected virtual void Dispose(bool Disposing) 
        {
        if (!Disposing || _Dispose) return;
        _Dispose = true;
         // Освобождение  управляемых ресурсов
        }
    }
}
