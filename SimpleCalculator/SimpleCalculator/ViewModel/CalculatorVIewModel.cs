using Microsoft.Practices.Prism.Commands;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace SimpleCalculator.ViewModel
{
    class CalculatorVIewModel : INotifyPropertyChanged
    {
        private ICommand _one;
        private ICommand _two;
        private ICommand _three;
        private ICommand _four;
        private ICommand _five;
        private ICommand _six;
        private ICommand _seven;
        private ICommand _eight;
        private ICommand _nine;
        private ICommand _zero;
        private ICommand _minus;
        private ICommand _plus;
        private ICommand _divison;
        private ICommand _multiplication;
        private ICommand _equal;
        private ICommand _decimalPoint;
        private ICommand _clearBtn;
        private String _result;
        private string Sign ;
        private string num1;
        private string num2;
        private string answer;
        private Model.CalculatorModel CalculatorModel;



        public CalculatorVIewModel()
        {
            CalculatorModel = new Model.CalculatorModel();
            One = new DelegateCommand(DisplayOne);
            Two = new DelegateCommand(DisplayTwo);
            Three = new DelegateCommand(DisplayThree);
            Four = new DelegateCommand(DisplayFour);
            Five = new DelegateCommand(DisplayFive);
            Six = new DelegateCommand(DisplaySix);
            Seven = new DelegateCommand(DisplaySeven);
            Eight = new DelegateCommand(DisplayEight);
            Nine = new DelegateCommand(DisplayNine);
            Zero = new DelegateCommand(DisplayZero);
            Plus = new DelegateCommand(DisplayPlus);
            Minus = new DelegateCommand(DisplayMinus);
            Divison = new DelegateCommand(DisplayDivision);
            Equal = new DelegateCommand(EqualButtonOperation);
            Multiplication = new DelegateCommand(DisplayMultiplication);
            DecimalPoint = new DelegateCommand(DisplayDecimalPoint);
            ClearBtn = new DelegateCommand(ClearButton);

        }
        public ICommand One
        {
            get
            {
                return _one;
            }

            set
            {
                _one = value;
            }
        }

        public ICommand Two
        {
            get
            {
                return _two;
            }

            set
            {
                _two = value;
            }
        }

        public ICommand Three
        {
            get
            {
                return _three;
            }

            set
            {
                _three = value;
            }
        }

        public ICommand Four
        {
            get
            {
                return _four;
            }

            set
            {
                _four = value;
            }
        }

        public ICommand Five
        {
            get
            {
                return _five;
            }

            set
            {
                _five = value;
            }
        }

        public ICommand Six
        {
            get
            {
                return _six;
            }

            set
            {
                _six = value;
            }
        }

        public ICommand Seven
        {
            get
            {
                return _seven;
            }

            set
            {
                _seven = value;
            }
        }

        public ICommand Eight
        {
            get
            {
                return _eight;
            }

            set
            {
                _eight = value;
            }
        }

        public ICommand Nine
        {
            get
            {
                return _nine;
            }

            set
            {
                _nine = value;
            }
        }

        public ICommand Zero
        {
            get
            {
                return _zero;
            }

            set
            {
                _zero = value;
            }
        }

        public ICommand Minus
        {
            get
            {
                return _minus;
            }

            set
            {
                _minus = value;
            }
        }

        public ICommand Plus
        {
            get
            {
                return _plus;
            }

            set
            {
                _plus = value;
            }
        }

        public ICommand Divison
        {
            get
            {
                return _divison;
            }

            set
            {
                _divison = value;
            }
        }

        public ICommand Multiplication
        {
            get
            {
                return _multiplication;
            }

            set
            {
                _multiplication = value;
            }
        }

        public ICommand Equal
        {
            get
            {
                return _equal;
            }

            set
            {
                _equal = value;
            }
        }

        public ICommand DecimalPoint
        {
            get
            {
                return _decimalPoint;
            }

            set
            {
                _decimalPoint = value;
            }
        }

        public ICommand ClearBtn
        {
            get
            {
                return _clearBtn;
            }

            set
            {
                _clearBtn = value;
            }
        }

        public string Result
        {
            get
            {
                return _result;
            }

            set
            {
                _result = value;
                RaisePropertyChanged("Result");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public void DisplayOne()
        {
            if (Result == "0" && Result != null)
            {
                Result = "1";
            }

            if (Sign == "=")
            {
                Result = "1";
                Sign = "";
            }
            
            else
            {
                Result += "1";
            }
        } 

        public void DisplayTwo()
        {
            if (Result == "0" && Result != null)
            {
                Result = "2";
            }
            if (Sign == "=")
            {
                Result = "2";
                Sign = "";
            }
            else
            {
                Result += "2";
            }
        }
        public void DisplayThree()
        {
            if (Result == "0" && Result != null  )
            {
                Result = "3";
            }
            if ( Sign == "=")
            {
                Result = "3";
                Sign = "";
            }
            else
            {
                Result += "3";
            } }
        public void DisplayFour()
        {
            if (Result == "0" && Result != null )
            {
                Result = "4";
            }
            if (Sign == "=")
            {
                Result = "4";
                Sign = "";
            }
            else
            {
                Result += "4";
            } }
        public void DisplayFive()
        {
            if (Result == "0" && Result != null )
            {
                Result = "5";
            }
            if (Sign == "=")
            {
                Result = "5";
                Sign = "";
            }
            else
            {
                Result += "5";
            }
        }
        public void DisplaySix()
        {
            if (Result == "0" && Result != null )
            {
                Result = "6";
            }
            if (Sign == "=")
            {
                Result = "6";
                Sign = "";
            }
            else
            {
                Result += "6";
            }
        }
        public void DisplaySeven()
        {
            if (Result == "0" && Result != null )
            {
                Result = "7";
            }
            if (Sign == "=")
            {
                Result = "7";
                Sign = "";
            }
            else
            {
                Result += "7";
            }
        }
        public void DisplayEight()
        {
            if (Result == "0" && Result != null )
            {
                Result = "8";
            }
            if (Sign == "=")
            {
                Result = "8";
                Sign = "";
            }
            else
            {
               Result +=  "8";
            }
        }
        public void DisplayNine()
        {
            if (Result == "0" && Result != null )
            {
                Result = "9";
            }
            if (Sign == "=")
            {
                Result = "9";
                Sign = "";
            }
            else
            {
                Result += "9";
            }
            }
        public void DisplayZero()
        {
           
                Result += "0";
            
        }
        public void DisplayPlus()
        {
            if (Sign == "=")
            {
                num1 = answer;
                Result = answer;
            }
            if (answer == null && Sign != null)
            {
                return;
            }
            else {
                num1 = Result;
    }

            CalculatorModel.Num1 = Convert.ToDouble(num1);
            Sign = "+";
            Result += Sign;

        }
        public void DisplayMinus()
        {
            if (Sign == "=")
            {
                num1 = answer;
                Result = answer;
            }
            if (answer== null && Sign != null)
            {
                return;
            }
            else {
                num1 = Result;
            }
            CalculatorModel.Num1 = Convert.ToDouble(num1);
            Sign = "-";
            Result += Sign;

        }
        public void DisplayDivision()
        {
            if (Sign == "=")
            {
                num1 = answer;
                Result = answer;
            }
            if (answer == null && Sign != null)
            {
                return;
            }
            num1 = Result;
            CalculatorModel.Num1 = Convert.ToDouble(num1);
            Sign = "/";
            Result += Sign;
            

        }
        public void DisplayMultiplication()
        {
            if (Sign == "=")
            {
                num1 = answer;
                Result = answer;
            }
            if (answer == null && Sign != null)
            {
                return;
            }

            num1 = Result;
            CalculatorModel.Num1 = Convert.ToDouble(num1);
            Sign = "x";
            Result += Sign;
        }

        public void DisplayDecimalPoint()
        {
            if (Result == "0" && Result != null)
            {
                Result = ".";
            }

            if (Sign == "=")
            {
                Result = answer + ".";
                Sign = "";
            }

            else
            {
                Result += ".";
            }
        


        }
        public void ClearButton()
        {
            Result = "";
           

        }

        public void EqualButtonOperation()
        {
           
            //CalculatorModel.Num2 = Convert.ToDouble(Result);
            
            if (Sign == "+")
            {
                num2 = Result.Replace(num1 + Sign, "");
                CalculatorModel.Num2 = Convert.ToDouble(num2);
                Sign = "=";
                Result += Sign;
                CalculatorModel.Additon();
                answer = CalculatorModel.Result.ToString();
                Result += answer;
            }
            if (Sign == "-")
            {
                num2 = Result.Replace(num1 + Sign, "");
                CalculatorModel.Num2 = Convert.ToDouble(num2);
                Sign = "=";
                Result += Sign;
                CalculatorModel.Substraction();
                answer = CalculatorModel.Result.ToString();
                Result += answer;
            }
            if (Sign == "x")
            {
                num2 = Result.Replace(num1 + Sign, "");
                CalculatorModel.Num2 = Convert.ToDouble(num2);
                Sign = "=";
                Result += Sign;
                CalculatorModel.Multiplication();
                answer = CalculatorModel.Result.ToString();
                Result += answer; ;
            }
            if (Sign == "/")
            {
                num2 = Result.Replace(num1 + Sign, "");
                CalculatorModel.Num2 = Convert.ToDouble(num2);
                Sign = "=";
                Result += Sign;
                CalculatorModel.Division();
                answer = CalculatorModel.Result.ToString();
                Result += answer;
            }
           


        }
    }
}
