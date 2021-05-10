using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace FuzzySearch
{
    /// <summary>Класс ViewModel for DesignData</summary>
    public class FuzzySearch_VM_DataDesigner : OnPropertyChangedClass
    {
        #region Свойства для привязки элементов отображения
        /// <summary>Свойство для слова поиска</summary>
        public string TextSearch { get => _textSearch; set { _textSearch = value; OnAllPropertyChanged(); } }
        /// <summary>Свойство для слова добавления</summary>
        public string TextAdd { get => _textAdd; set { _textAdd = value; OnAllPropertyChanged(); } }
        /// <summary>Свойство для списка слова</summary>
        public ObservableCollection<string> ListWords { get => _listWords; set { _listWords = value; OnAllPropertyChanged(); } }
        /// <summary>Свойство для сообщения с результатами поиска</summary>
        public string TextMessage { get => _textMessage; set { _textMessage = value; OnAllPropertyChanged(); } }
        #endregion

        #region Приватные поля
        // Поля для хранения значения свойства
        private string _textSearch;
        private string _textAdd;
        private ObservableCollection<string> _listWords;
        private string _textMessage;
        // Поля для хранения значения команд
        private ICommand _searchComm;
        private ICommand _clearComm;
        private ICommand _addComm;
        private ICommand _saveComm;
        private ICommand _loadComm;
        #endregion

        #region Свойства для привязки команд
        /// <summary>Свойство для привязки команды</summary>
        public ICommand SearchComm => _searchComm ?? (_searchComm = new RelayCommand(OnSearch));
        /// <summary>Свойство для привязки команды</summary>
        public ICommand ClearComm => _clearComm ?? (_clearComm = new RelayCommand(OnClear));
        /// <summary>Свойство для привязки команды</summary>
        public ICommand AddComm => _addComm ?? (_addComm = new RelayCommand(OnAdd));
        /// <summary>Свойство для привязки команды</summary>
        public ICommand SaveComm => _saveComm ?? (_saveComm = new RelayCommand(OnSave));
        /// <summary>Свойство для привязки команды</summary>
        public ICommand LoadComm => _loadComm ?? (_loadComm = new RelayCommand(OnLoad));
        #endregion

        #region Методы для команд
        /// <summary>Метод для вызова из команды</summary>
        /// <param name="Value">Значение привязанного параметра</param>
        public virtual void OnSearch(object Value = null) { }
        /// <summary>Метод для вызова из команды</summary>
        /// <param name="Value">Значение привязанного параметра</param>
        public virtual void OnClear(object Value = null)
        { TextSearch = ""; TextMessage = ""; TextAdd = ""; }
        /// <summary>Метод для вызова из команды</summary>
        /// <param name="Value">Значение привязанного параметра</param>
        public virtual void OnAdd(object Value = null) { }
        /// <summary>Метод для вызова из команды</summary>
        /// <param name="Value">Значение привязанного параметра</param>
        public virtual void OnSave(object Value = null) { }
        /// <summary>Метод для вызова из команды</summary>
        /// <param name="Value">Значение привязанного параметра</param>
        public virtual void OnLoad(object Value = null) { }
        #endregion
    }
}
