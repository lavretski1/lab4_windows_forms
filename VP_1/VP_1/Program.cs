using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VP_1
{
    public class DataToSave
    {
        public DataToSave() { }

        public DataToSave(CalculatorMainWindow calculator)
        {
            CurrentState = calculator.CurrentState;
            ParametersRecieved = calculator.ParametersRecieved;
            OpenedBracketsCounter = calculator.OpenedBracketsCounter;
            CurrentInput = calculator.CurrentInput;
            ReadyToCalculationExpression = calculator.ReadyToCalculationExpression;
            ShownToUserExpression = calculator.ShownToUserExpression;
        }

        public CalculatorMainWindow.States CurrentState { get; set; }

        public List<string> ParametersRecieved { get; set; }

        public int OpenedBracketsCounter { get; set; }

        public string CurrentInput { get; set; }

        public string ReadyToCalculationExpression { get; set; }

        public string ShownToUserExpression { get; set; }
    }

    static class Program
    {
        const string fileName = "config.xml";
        private static XmlSerializer serializer = new XmlSerializer(typeof(DataToSave));


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TextReader reader = new StreamReader(fileName);
            var save = serializer.Deserialize(reader);
            reader.Dispose();
            var calculator = new CalculatorMainWindow(save as DataToSave);
            calculator.FormClosing += SaveData;
            Application.Run(calculator);
        }

        static void SaveData(object sender, FormClosingEventArgs e) 
        {
            var save = new DataToSave(sender as CalculatorMainWindow);
            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, save);
        }


        /// <remarks>
        ///     If closing bracket is missing its automatically assumed it has to be in the end of expression
        /// </remarks>
        public static string ConvertToIPN(string input) 
        {
            input += " ";
            Stack<string> stack = new Stack<string>();
            string output = string.Empty;

            string buffer = string.Empty;

            for (int i = 0; i < input.Length; i++) 
            {
                if (input[i] != ' ')
                {
                    buffer += input[i];
                }
                else 
                {
                    if (float.TryParse(buffer, out _))
                    {
                        output += " " + buffer;
                    }
                    else if (buffer == "+" || buffer == "-")
                    {
                        string picked;
                        while (stack.TryPeek(out picked) && picked != "(")
                        {
                            output += " " + stack.Pop();
                        }
                        stack.Push(buffer);
                    }
                    else if (buffer == "*" || buffer == "/")
                    {
                        string picked;
                        while (stack.TryPeek(out picked) && picked != "+" && picked != "-" && picked != "(")
                        {
                            output += " " + stack.Pop();
                        }
                        stack.Push(buffer);
                    }
                    else if (buffer == "√")
                    {
                        string picked;
                        while (stack.TryPeek(out picked) && picked == "√")
                        {
                            output += " " + stack.Pop();
                        }
                        stack.Push(buffer);
                    }
                    else if (buffer == "(")
                    {
                        stack.Push(buffer);
                    }
                    else if (buffer == ")")
                    {
                        while (true)
                        {
                            string picked;
                            if (!stack.TryPeek(out picked))
                            {
                                throw new ArgumentException("Missing opening bracket");
                            }
                            if (picked == "(")
                            {
                                stack.Pop();
                                break;
                            }
                            output += " " + stack.Pop();
                        }
                    }
                    else if(buffer.Length > 0)
                    {
                        throw new ArgumentException("Uknown input expression encountered");
                    }
                    buffer = string.Empty;
                }
            }
            while (stack.TryPeek(out _))
            {
                output += " " + stack.Pop();
            }
            return output;
        }

        public static float ComputeIPN(string IPN) 
        {
            List<string> dividedIPN = new List<string>(IPN.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            try
            {
                while (dividedIPN.Count > 1)
                {
                    bool wasBroken = false;
                    for (int i = 0; i < dividedIPN.Count; i++)
                    {
                        float operationResult;
                        switch (dividedIPN[i])
                        {
                            case "+":
                                operationResult = float.Parse(dividedIPN[i - 2]) + float.Parse(dividedIPN[i - 1]);
                                dividedIPN.RemoveAt(i - 1);
                                dividedIPN.RemoveAt(i - 2);
                                dividedIPN[i - 2] = operationResult.ToString();
                                break;
                            case "-":
                                operationResult = float.Parse(dividedIPN[i - 2]) - float.Parse(dividedIPN[i - 1]);
                                dividedIPN.RemoveAt(i - 1);
                                dividedIPN.RemoveAt(i - 2);
                                dividedIPN[i - 2] = operationResult.ToString();
                                break;
                            case "*":
                                operationResult = float.Parse(dividedIPN[i - 2]) * float.Parse(dividedIPN[i - 1]);
                                dividedIPN.RemoveAt(i - 1);
                                dividedIPN.RemoveAt(i - 2);
                                dividedIPN[i - 2] = operationResult.ToString();
                                break;
                            case "/":
                                operationResult = float.Parse(dividedIPN[i - 2]) / float.Parse(dividedIPN[i - 1]);
                                dividedIPN.RemoveAt(i - 1);
                                dividedIPN.RemoveAt(i - 2);
                                dividedIPN[i - 2] = operationResult.ToString();
                                break;
                            case "√":
                                operationResult = (float)Math.Sqrt(float.Parse(dividedIPN[i - 1]));
                                dividedIPN.RemoveAt(i - 1);
                                dividedIPN[i - 1] = operationResult.ToString();
                                break;
                            default:
                                if (!float.TryParse(dividedIPN[i], out _)) 
                                {
                                    throw new ArgumentException("Error parsing input, uknown expression encountered");
                                }
                                continue;
                        }
                        wasBroken = true;
                        break;
                    }
                    if (wasBroken == false) 
                    {
                        throw new ArgumentException("Error parsing input, could be missing operator");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentException("Error parsing input, could be missing number or operator");
            }
            catch (FormatException) 
            {
                throw new ArgumentException("Error parsing input, could be missing number");
            }
            return float.Parse(dividedIPN[0]);
        }
    }
}
