using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VP_1
{
    public partial class CalculatorMainWindow : Form
    {
        public enum States 
        {
            AwaitingNumberOrNumberExpression,
            AwaitingOperator,
            AwaitingParameters,
            AwaitingFurtherInstructions
        }

        private States _currentState = States.AwaitingNumberOrNumberExpression;
        public States CurrentState { get { return _currentState; } }

        private List<string> _parametersRecieved = new List<string>();
        public List<string> ParametersRecieved { get { return _parametersRecieved; } }
        private int _openedBracketsCounter = 0;
        public int OpenedBracketsCounter { get { return _openedBracketsCounter; } }

        private string _currentInput = string.Empty;
        public string CurrentInput { get { return _currentInput; } }

        private string _readyToCalculationExpression = string.Empty;
        public string ReadyToCalculationExpression { get { return _readyToCalculationExpression; } }

        public string ShownToUserExpression {
            get 
            {
                return WholeExpressionTextBox.Text;
            }
        }

        public CalculatorMainWindow()
        {
            InitializeComponent();
        }

        public CalculatorMainWindow(DataToSave savedState)
        {
            InitializeComponent();
            _currentState = savedState.CurrentState;
            _parametersRecieved = savedState.ParametersRecieved;
            _openedBracketsCounter = savedState.OpenedBracketsCounter;
            _currentInput = savedState.CurrentInput;
            _readyToCalculationExpression = savedState.ReadyToCalculationExpression;
            WholeExpressionTextBox.Text = string.Empty;
            WholeExpressionTextBox.AppendText(savedState.ShownToUserExpression);
            UpdateTextBox();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.Add:
                    AddButton.SimulateClick();
                    break;
                case Keys.Subtract:
                    SubtractButton.SimulateClick();
                    break;
                case Keys.Multiply:
                    MultiplyButton.SimulateClick();
                    break;
                case Keys.Divide:
                    DivideButton.SimulateClick();
                    break;
                case Keys.Oemplus:
                    EqualsButton.SimulateClick();
                    break;
                case Keys.Decimal:
                    DecimalButton.SimulateClick();
                    break;
                case Keys.D0:
                    Number0.SimulateClick();
                    break;
                case Keys.D1:
                    Number1.SimulateClick();
                    break;
                case Keys.D2:
                    Number2.SimulateClick();
                    break;
                case Keys.D3:
                    Number3.SimulateClick();
                    break;
                case Keys.D4:
                    Number4.SimulateClick();
                    break;
                case Keys.D5:
                    Number5.SimulateClick();
                    break;
                case Keys.D6:
                    Number6.SimulateClick();
                    break;
                case Keys.D7:
                    Number7.SimulateClick();
                    break;
                case Keys.D8:
                    Number8.SimulateClick();
                    break;
                case Keys.D9:
                    Number9.SimulateClick();
                    break;
                case Keys.OemOpenBrackets:
                    OpenBracket.SimulateClick();
                    break;
                case Keys.OemCloseBrackets:
                    CloseBracket.SimulateClick();
                    break;
                case Keys.Delete:
                    ClearButton.SimulateClick();
                    break;
            }
        }

        private void UpdateTextBox() 
        {
            CurrentInputTextBox.Text = _currentInput;
            DisplayMessage(string.Empty);
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression || _currentState == States.AwaitingParameters)
            {
                if (int.TryParse(_currentInput, out _))
                {
                    _currentInput += '.';
                    UpdateTextBox();
                }
                else
                {
                    DisplayMessage("Too many .");
                }
            }
            else 
            {
                DisplayMessage("Awaiting number expression");
            }
        }

        private void OpenBracket_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (_currentInput.Length == 0)
                {
                    _readyToCalculationExpression += " " + "(";
                    WholeExpressionTextBox.AppendText(" " + "(");
                    _openedBracketsCounter++;
                    UpdateTextBox();
                }
                else
                {
                    DisplayMessage("After number operator expected");
                }
            }
            else 
            {
                DisplayMessage("Awaiting number expression");
            }
        }

        private void CloseBracket_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingOperator)
            {
                
            }
            else if (_currentState == States.AwaitingNumberOrNumberExpression) 
            {
                if (_currentInput.Length < 1) 
                {
                    DisplayMessage("Number expression expected");
                    return;
                }
            }
            else
            {
                DisplayMessage("Cant use ) here");
                return;
            }
            if (_openedBracketsCounter < 1)
            {
                DisplayMessage("No brackets to close");
                return;
            }

            _openedBracketsCounter--;
            _readyToCalculationExpression +=" " + _currentInput + " " + ")";
            WholeExpressionTextBox.AppendText(" " + _currentInput + " " + ")");
            _currentState = States.AwaitingOperator;
            _currentInput = string.Empty;
            UpdateTextBox();
        }

        private void Operation(char operation) 
        {
            if (_currentState == States.AwaitingFurtherInstructions)
            {
                _readyToCalculationExpression = string.Empty;
                WholeExpressionTextBox.Text = string.Empty;
                _openedBracketsCounter = 0;
            }
            else if (_currentState == States.AwaitingOperator)
            {

            }
            else if (_currentState == States.AwaitingNumberOrNumberExpression) 
            {
                if (_currentInput.Length == 0)
                {
                    DisplayMessage("Number expected");
                    return;
                }
                else if (!float.TryParse(_currentInput,out _)) 
                {
                    DisplayMessage("Finish entering number");
                    return;
                }
            }
            else
            {
                DisplayMessage("Operator not expected");
                return;
            }
            _readyToCalculationExpression += " " + _currentInput + " " + operation;
            WholeExpressionTextBox.AppendText(" " + _currentInput + " " + operation);
            _currentState = States.AwaitingNumberOrNumberExpression;
            _currentInput = string.Empty;
            UpdateTextBox();
        }

        private void Digit(char digit) 
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression || _currentState == States.AwaitingFurtherInstructions || _currentState == States.AwaitingParameters)
            {
                _currentInput += digit;
                UpdateTextBox();
            }
            else 
            {
                DisplayMessage("Digit not expected");
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (float.TryParse(_currentInput, out _))
                {
                    _readyToCalculationExpression += " " + _currentInput;
                    WholeExpressionTextBox.AppendText(" " + _currentInput);
                }
                else
                {
                    DisplayMessage("Finish expression first");
                    return;
                }
            }
            else if (_currentState == States.AwaitingParameters) 
            {
                DisplayMessage("Enter parameters first");
                return;
            }
            while (_openedBracketsCounter > 0) 
            {
                _readyToCalculationExpression += " )";
                WholeExpressionTextBox.AppendText(" )");
                _openedBracketsCounter--;
            }
            _currentState = States.AwaitingFurtherInstructions;
            var IPN = Program.ConvertToIPN(_readyToCalculationExpression);
            _currentInput = Program.ComputeIPN(IPN).ToString();
            UpdateTextBox();
            DisplayMessage("Result:");
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (_currentInput.Length == 0)
                {
                    _readyToCalculationExpression += " √";
                    WholeExpressionTextBox.AppendText(" √");
                }
                else
                {
                    DisplayMessage("Press √ before number");
                }
            }
            else 
            {
                DisplayMessage("√ not expected");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            _readyToCalculationExpression = string.Empty;
            WholeExpressionTextBox.Text = string.Empty;
            _currentInput = string.Empty;
            _openedBracketsCounter = 0;
            _parametersRecieved = new List<string>();
            _currentState = States.AwaitingNumberOrNumberExpression;
            UpdateTextBox();
        }

        private void HeightButton_Click(object sender, EventArgs e)
        {
            if (_currentState == States.AwaitingNumberOrNumberExpression)
            {
                if (_currentInput.Length == 0)
                {
                    WholeExpressionTextBox.AppendText(" hₐ(");
                    _currentState = States.AwaitingParameters;
                    DisplayMessage("Press hₐ to confirm parameter");
                }
                else
                {
                    DisplayMessage("Function needs to be before parameters");
                }
            }
            else if (_currentState == States.AwaitingParameters) 
            {
                if (float.TryParse(_currentInput, out _))
                {
                    if (_parametersRecieved.Count < 2)
                    {
                        _parametersRecieved.Add(_currentInput);
                        WholeExpressionTextBox.AppendText(" " + _currentInput + ",");
                        _currentInput = string.Empty;
                        UpdateTextBox();
                    }
                    else 
                    {
                        _parametersRecieved.Add(_currentInput);
                        WholeExpressionTextBox.AppendText(" " + _currentInput +" )");
                        _currentInput = string.Empty;
                        UpdateTextBox();
                        _currentState = States.AwaitingOperator;
                        string p = "( ( " + _parametersRecieved[0] + " + " + _parametersRecieved[1] + " + " + _parametersRecieved[2] + " ) / 2 )";
                        string h = " ( ( 2 * √ ( " + p + " * ( " + p + " - " + _parametersRecieved[0] + " ) * ( " + p + " - " + _parametersRecieved[1] + " ) * ( " + p + " - " + _parametersRecieved[2] + " ) ) ) / " + _parametersRecieved[0] + " )";
                        _readyToCalculationExpression += h;
                        _parametersRecieved.Clear();
                    }
                }
                else 
                {
                    DisplayMessage("Finsh expression first");
                }
            }
            else
            {
                DisplayMessage("Function not expected");
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (_currentInput.Length > 0 || _currentState == States.AwaitingOperator)
            {
                Operation('-');
            }
            else
            {
                if (_currentState == States.AwaitingNumberOrNumberExpression || _currentState == States.AwaitingParameters)
                {
                    _currentInput += '-';
                    UpdateTextBox();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Operation('+');
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Operation('*');
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Operation('/');
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            Digit('0');
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            Digit('1');
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            Digit('2');
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            Digit('3');
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            Digit('4');
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            Digit('5');
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            Digit('6');
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            Digit('7');
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            Digit('8');
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            Digit('9');
        }

        private void CalculatorMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void WholeExpressionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
