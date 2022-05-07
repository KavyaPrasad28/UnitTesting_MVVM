using System;
using System.ComponentModel;
using System.Windows.Controls;

namespace UnitTesting_MVVM.Model
{
    public class BasicMathModel : IDataErrorInfo, INotifyPropertyChanged
    {
        private int? _number1;
        public int? Number1
        {
            get
            {
                return _number1;
            }
            set
            {
                _number1 = value;
                NotifyPropertyChanged("Number1");
            }
        }
        private int? _number2;
        public int? Number2
        {
            get
            {
                return _number2;
            }
            set
            {
                _number2 = value;
                NotifyPropertyChanged("Number2");
            }
        }

        private int? _result;
        public int? Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                NotifyPropertyChanged("Result");
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        string IDataErrorInfo.Error
        {
            get
            {
                return null;
            }
        }

        string IDataErrorInfo.this[string propertyName]
        {
            get
            {
                return GetValidationError(propertyName);
            }
        }

        #region Validation

        static readonly string[] ValidatedProperties =
        {
            "Number1",
            "Number2"
        };

        public bool IsValid
        {
            get
            {
                foreach (string property in ValidatedProperties)
                {
                    if (GetValidationError(property) != null)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        string GetValidationError(String propertyName)
        {
            string error = null;
            switch (propertyName)
            {
                case "Number1":
                    error = ValidateEmptySpace(Number1);
                    /*if (error == null)
                    {
                        error = ValidateType();
                    }*/
                    break;
                case "Number2":
                    error = ValidateEmptySpace(Number2);
                    /*if (error == null)
                    {
                        error = ValidateType();
                    }*/
                    break;
                default:
                    return error;
            }
            return error;
        }
        /*private string ValidateType()
        {
           if (Number1.Value.GetType() != typeof(int))
            {
                return "Number should be an integer!";
            }
            return null;
        }*/
        private string ValidateEmptySpace(int? _caseName)
        {
            return _caseName == null ? "Number Cannot be empty!" : null;
        }
        
        #endregion
    }
}
