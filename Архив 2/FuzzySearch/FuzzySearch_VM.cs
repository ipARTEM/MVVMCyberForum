using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzySearch
{
    /// <summary>Клас реальной ViewModel</summary>
    public class FuzzySearch_VM : FuzzySearch_VM_DataDesigner
    {
        public FuzzySearch_VM()
        {
            FuzzySearch_Model.Load();
            ListWords = FuzzySearch_Model.ListWords;
        }

        public override void OnAdd(object Value = null) => FuzzySearch_Model.AddWord(TextAdd);
        public override void OnLoad(object Value = null) => FuzzySearch_Model.Load();
        public override void OnSave(object Value = null) => FuzzySearch_Model.Save();
        public override void OnSearch(object Value = null) => TextMessage = FuzzySearch_Model.SearchWord(TextSearch);
    }
}
