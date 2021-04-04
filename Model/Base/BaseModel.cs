using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BukStat.Model.Base
{
    public class BaseModel : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
