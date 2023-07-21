using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrderControlReact.Dal
{
    public class Record<T> : INotifyPropertyChanged where T : new()
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (!string.IsNullOrEmpty(propertyName))
            {
                MarkColumnModified(propertyName);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [Ignore]
        [JsonIgnore]
        public List<string> ModifiedColumns { get; set; } = new List<string>();

        //[Ignore]
        //[JsonIgnore]
        //public Dictionary<string, bool> ModifiedColumns { get; set; } = new Dictionary<string, bool>();

        protected void MarkColumnModified([CallerMemberName] string column_name = null)
        {
            //if (ModifiedColumns != null)
            //    ModifiedColumns[column_name] = true;

            if (!ModifiedColumns.Exists(item => item == column_name))
            {
                ModifiedColumns.Add(column_name);
            }
        }

        private void OnLoaded()
        {

            if (ModifiedColumns == null)
            {
                ModifiedColumns = new List<string>();
            }
            else
            {
                ModifiedColumns.Clear();
            }
        }
    }
    [TableName("dbo.orders")]
    [PrimaryKey("id", AutoIncrement = true)]
    [ExplicitColumns]
    public class ORDERS : Record<ORDERS>
    {
        [ResultColumn(IncludeInAutoSelect.Yes)]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; OnPropertyChanged(); }
        }
        int _ID;

        [PetaPoco.Column]
        public DateTime CREATE_DATE
        {
            get { return _CREATE_DATE; }
            set { _CREATE_DATE = value; OnPropertyChanged(); }
        }
        DateTime _CREATE_DATE;

        [PetaPoco.Column]
        public string? ORDER_TYPE
        {
            get { return _ORDER_TYPE; }
            set { _ORDER_TYPE = value; OnPropertyChanged(); }
        }
        string? _ORDER_TYPE;

        [PetaPoco.Column]
        public string ORDER_CODE
        {
            get { return _ORDER_CODE; }
            set { _ORDER_CODE = value; OnPropertyChanged(); }
        }
        string _ORDER_CODE;

        [PetaPoco.Column]
        public string ORDER_NAME
        {
            get { return _ORDER_NAME; }
            set { _ORDER_NAME = value; OnPropertyChanged(); }
        }
        string _ORDER_NAME;

    }

}
