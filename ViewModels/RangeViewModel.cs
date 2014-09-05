using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using TryMVVM.Commands;
using TryMVVM.Models;

namespace TryMVVM.ViewModels
{
    public class RangeViewModel : ViewModelBase
    {
        private RangeModel _range;
        private string _criticality;
        private Brush _bgColor;
        private ICommand _submitCommand;

        public RangeModel Range
        {
            get { return _range; }
            set 
            {
                _range = value;
                NotifyPropertyChanged("Range");                
            }
        }

        public string Criticality
        {
            get { return _criticality; }
            set
            {
                _criticality = value;
                NotifyPropertyChanged("Criticality");
            }
        }

        public Brush BGColor
        {
            get { return _bgColor; }
            set
            {
                _bgColor = value;
                NotifyPropertyChanged("BGColor");
            }
        }

        public ICommand SubmitCommand
        {
            get
            {
                if (_submitCommand == null)
                {
                    _submitCommand = new RangeCommand(param => this.Submit(),
                        null);
                }
                return _submitCommand;
            }
        }

        public RangeViewModel() 
        {
            Range = new RangeModel();
        }

        private void Submit()
        {
            Criticality = Helper.Helper.GetRangeCriticality(Range.Range);
            BGColor = Helper.Helper.GetRangeIndicator(Range.Range);
        }       
    }
}
