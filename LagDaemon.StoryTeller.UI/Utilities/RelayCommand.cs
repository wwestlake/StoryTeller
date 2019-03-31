﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LagDaemon.StoryTeller.UI.Utilities
{
    public class RelayCommand<T> : ICommand
    {
        #region Fields
        readonly Action<T> _execute;
        readonly Predicate<T> _canExecute;
        #endregion // Fields

        #region Constructors
        public RelayCommand(Action<T> execute)
        : this(execute, null)
        {
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }
        #endregion // Constructors

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute( parameter is T ? (T)parameter : default(T));
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _execute(parameter is T ? (T)parameter : default(T));
        }

        #endregion // ICommand Members
    }
}
