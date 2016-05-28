using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc1
{
    public partial class Form1 : Form
    {
        static int notation = 2; // 0 - bin, 1 - oct, 2 - dec, 3 - hex
        static int balanceBrackets = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {
            double notUse = 0;
            List<string> example = new List<string>();
            List<string> result = new List<string>();
            Stack<string> operatorsStack = new Stack<string>();
            StringBuilder textExample = new StringBuilder(textBox1.Text);

            createExampleList(example, textExample, notUse);

            foreach (var value in example)
            {
                if (!isOperator(value))
                {
                    result.Add(value);
                }
                else
                {
                    updateStack(value, result, operatorsStack, example);
                }
            }
            solveExample(result, notUse);
            label1.Text = label1.Text + "-------" + "\n";
            textBox1.Text = "";
            
        }

        // метод проверки символа на то, является ли он оператором
        private bool isOperator(string symbol)
        {
            bool isOperator = false;
            string[,] operators = new string[4, 2] { { "(", ")" }, { "+", "-" }, { "*", "/" }, { "^", "√" } };
            for (int i = 0; i < operators.GetLength (0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (symbol == operators[i,j])
                    {
                        isOperator = true;
                    }
                }
            }
            return isOperator;
        }

        // метод создания коллекции строк (аргументов и операторов) и объединения рядом стоящих цифр
        private void createExampleList(List<string> example, StringBuilder textExample, double notUse)
        {
            for (int i = 0; i < textExample.Length; i++)
            {
                example.Add(textExample[i].ToString());
            }
            for (int i = 0; i < example.Count; i++)
            {
                if (example[i] == ",")
                {
                    if (i == 0 | isOperator(example[i - 1]))
                    {
                        example[i] = "0" + example[i] + example[i + 1];
                        example.RemoveAt(i + 1);
                    }
                }
                if (i != example.Count - 1 & !isOperator(example[i]) & !isOperator(example[i + 1])) //если выбранный элемент не последний, он не является оператором как и следующий 
                {
                    example[i] = example[i] + example[i + 1];
                    example.RemoveAt(i + 1);
                    i--;
                }
            }
        }

        // метод работы со стеком
        private void updateStack(string value, List<string> result, Stack<string> operatorsStack, List<string> example)
        {
            int indexLastItemStack = 0;
            int indexNewItem = 0;
            bool needRepeat;
            string removeBracket;

            do
            {
                needRepeat = false;
                if (operatorsStack.Count() == 0)
                {
                    operatorsStack.Push(value);
                }
                else
                {
                    if (operatorsStack.Peek() == "(" | value == "(")
                    {
                        operatorsStack.Push(value);
                    }
                    else if (value == ")")
                    {
                        while (!(operatorsStack.Peek() == "("))
                        {
                            result.Add(operatorsStack.Pop());
                        }
                        removeBracket = operatorsStack.Pop();
                    }
                    else
                    {
                        indexLastItemStack = findIndex(operatorsStack.Peek());
                        indexNewItem = findIndex(value);

                        if (indexNewItem >= indexLastItemStack)
                        {
                            operatorsStack.Push(value);
                        }
                        else
                        { 
                            result.Add(operatorsStack.Pop());
                            needRepeat = true;
                        }
                    }
                }
            } while (needRepeat);

            while (!(operatorsStack.Count == 0))
            {
                result.Add(operatorsStack.Pop());
            }
        }

        // метод определения индекса (приоритета) последнего элемента стека и новодобавляемого
        private int findIndex(string arg)
        {
            string[,] operatorsPriority = new string[4, 2] { { "(", ")" }, { "+", "-" }, { "*", "/" }, { "^", "√" } };
            int resultIndex = 0;

            for (int i = 0; i < operatorsPriority.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (operatorsPriority[i, j] == arg)
                    {
                        resultIndex = i;
                    }
                }
            }
                return resultIndex;
        }

        //метод вызова методов математических операций
        private void solveExample(List<string> result, double notUse)
        {
            for (int i = 0; i < result.Count; i++)
            {
                if (isOperator(result[i]))
                {
                    switch (result[i])
                    {
                        case "+":
                            result[i - 2] = addition(result[i - 2], result[i - 1]);
                            result.RemoveAt(i);
                            result.RemoveAt(i - 1);
                            i = i - 2;
                            break;
                        case "-":
                            result[i - 2] = subtraction(result[i - 2], result[i - 1]);
                            result.RemoveAt(i);
                            result.RemoveAt(i - 1);
                            i = i - 2;
                            break;
                        case "*":
                            result[i - 2] = multiplication(result[i - 2], result[i - 1]);
                            result.RemoveAt(i);
                            result.RemoveAt(i - 1);
                            i = i - 2;
                            break;
                        case "/":
                            result[i - 2] = division(result[i - 2], result[i - 1]);
                            result.RemoveAt(i);
                            result.RemoveAt(i - 1);
                            i = i - 2;
                            break;
                        case "^":
                            result[i - 2] = involution(result[i - 2], result[i - 1]);
                            result.RemoveAt(i);
                            result.RemoveAt(i - 1);
                            i = i - 2;
                            break;
                        case "√":
                            result[i - 1] = rootExtract(result[i - 1]);
                            result.RemoveAt(i);
                            i = i - 1;
                            break;
                    }
                }
            }
        }

        private void notationChangeNum(ref string arg1, ref string arg2, ref string result, bool changeBack)
        {
            switch (notation)
            {
                case 0:
                    if (changeBack)
                    {
                        result = Convert.ToString(Convert.ToInt32(result),2);
                    }
                    else
                    {
                        arg1 = Convert.ToString(Convert.ToInt32(arg1), 10);
                        arg2 = Convert.ToString(Convert.ToInt32(arg2), 10);
                    }
                    break;
                case 1:
                    if (changeBack)
                    {
                        result = Convert.ToString(Convert.ToInt32(result), 8);
                    }
                    else
                    {
                        arg1 = Convert.ToString(Convert.ToInt32(arg1), 10);
                        arg2 = Convert.ToString(Convert.ToInt32(arg2), 10);
                    }
                    break;
                case 3:
                    if (changeBack)
                    {
                        result = Convert.ToString(Convert.ToInt32(result), 16);
                    }
                    else
                    {
                        arg1 = Convert.ToString(Convert.ToInt32(arg1), 10);
                        arg2 = Convert.ToString(Convert.ToInt32(arg2), 10);
                    }
                    break;
            }
        }

        // методы математических операций
        private string addition(string arg1, string arg2) //функция сложения
        {
            string result = "";
            string originalArg1 = arg1, originalArg2 = arg2;
            if (notation != 2)
            {
                notationChangeNum(ref arg1, ref arg2, ref result, false);
                result = Convert.ToString(Convert.ToDouble(arg1) + Convert.ToDouble(arg2));
                notationChangeNum(ref arg1, ref arg2, ref result, true);

            }
            {
                result = Convert.ToString(Convert.ToDouble(arg1) + Convert.ToDouble(arg2));
            }
            
            LogWrite(originalArg1, originalArg2, "+", result);
            return result;
        }
        private string subtraction(string arg1, string arg2) //функция вычетания
        {
            string result = Convert.ToString(Convert.ToDouble(arg1) - Convert.ToDouble(arg2));
            LogWrite(arg1, arg2, "-", result);
            return result;
        }
        private string multiplication(string arg1, string arg2) //функция умножения
        {
            string result = Convert.ToString(Convert.ToDouble(arg1) * Convert.ToDouble(arg2));
            LogWrite(arg1, arg2, "*", result);
            return result;
        }
        private string division(string arg1, string arg2) //функция деления
        {
            string result = Convert.ToString(Convert.ToDouble(arg1) / Convert.ToDouble(arg2));
            LogWrite(arg1, arg2, "/", result);
            return result;
        }
        private string involution(string arg1, string arg2) //функция возведения в степень
        {
            string result = Convert.ToString(Math.Pow(Convert.ToDouble(arg1), Convert.ToDouble(arg2)));
            LogWrite(arg1, arg2, "^", result);
            return result;
        }
        private string rootExtract(string arg1) //функция извлечения корня
        {
            string result = Convert.ToString(Math.Sqrt(Convert.ToDouble(arg1)));
            LogWrite(null, arg1, "√", result);
            return result;
        }

        // вывод действий решения в лог
        private void LogWrite(string arg1, string arg2, string operand, string result)
        {
            int indexComma = result.IndexOf(",");
            if (indexComma == -1 | result.Length<7)
            {
                label1.Text = label1.Text + arg1 + operand + arg2 + "=" + result + "\n";
            }
            else
            {
                label1.Text = label1.Text + arg1 + operand + arg2 + "=" + result.Substring(0, indexComma+5) + "\n";
            }
            
        }

        // обработка событий клика на кнопки цифры
        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }
        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        private void buttonComma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        // обработка событий клика на кнопки букв
        private void buttonHexA_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "A";
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        private void buttonHexB_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "B";
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        private void buttonHexC_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "C";
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        private void buttonHexD_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "D";
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        private void buttonHexE_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "E";
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        private void buttonHexF_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "F";
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        // обработка событий клика на кнопки операторов
        private void buttonOperationPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (!notDoubleOperation())
                {
                    textBox1.Text = textBox1.Text + "+";
                }
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void buttonOperationMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (!notDoubleOperation())
                {
                    textBox1.Text = textBox1.Text + "-";
                }
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void buttonOperationMultiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (!notDoubleOperation())
                {
                    textBox1.Text = textBox1.Text + "*";
                }
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void buttonOperationDivision_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (!notDoubleOperation())
                {
                    textBox1.Text = textBox1.Text + "/";
                }
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void buttonOperationDegree_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (!notDoubleOperation())
                {
                    textBox1.Text = textBox1.Text + "^";
                }
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void buttonOperationRoot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text.Substring(textBox1.Text.Length-1) != "√" & notDoubleOperation())
                {
                    textBox1.Text = textBox1.Text + "√";
                }
                textBox1.SelectionStart = textBox1.Text.Length;
            }
            else
            {
                textBox1.Text = textBox1.Text + "√";
            }
        }
        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (notDoubleOperation() & textBox1.Text.Substring(textBox1.Text.Length-1) != "√")
                {
                    textBox1.Text = textBox1.Text + "(";
                    balanceBrackets++;

                }
                textBox1.SelectionStart = textBox1.Text.Length;
            }
            else
            {
                textBox1.Text = textBox1.Text + "(";
                balanceBrackets++;
            }
        }
        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (!notDoubleOperation() & textBox1.Text.Substring(textBox1.Text.Length) != "√" & balanceBrackets>0)
                {
                    textBox1.Text = textBox1.Text + ")";
                    balanceBrackets--;
                }
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        // обработка событий клика на кнопки логических операторов
        private void buttonLogicOr_Click(object sender, EventArgs e)
        {

        }
        private void buttonLogicXor_Click(object sender, EventArgs e)
        {

        }
        private void buttonLogicAnd_Click(object sender, EventArgs e)
        {

        }
        private void buttonLogicNot_Click(object sender, EventArgs e)
        {

        }

        // обработка событий смены активного радиобатона
        private void radioButtonNotationBin_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonNotationDec_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonNotationOct_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButtonNotationHex_CheckedChanged(object sender, EventArgs e)
        {

        }

        // проверка предыдущего символа в TextBox1
        private bool notDoubleOperation()
        {
            bool lastSymbolIsOperation = false;
            double notUse;
            if (!Double.TryParse(textBox1.Text.Substring(textBox1.Text.Length - 1), out notUse))
            {
                if (textBox1.Text.Substring(textBox1.Text.Length - 1) != ")")
                {
                    lastSymbolIsOperation = true;
                }
            }

            return lastSymbolIsOperation;
        }

        // обработка событий клика на кнопки действий
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length-1);
            }
            textBox1.Focus();

        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (balanceBrackets == 0)
            {
                calculate();
            }
            else
            {
                label1.Text = label1.Text + "Нехватает скобки" + "\n";
            }
               
        }

        // обработка события TextBox1
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int ich = ch;
            if (!Char.IsDigit(ch))
            {
                switch (ich)
                {
                    case 8:
                        buttonBackspace_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    case 13:
                        calculate();
                        e.Handled = true;
                        break;
                    case 40:
                        buttonOpenBracket_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    case 41:
                        buttonCloseBracket_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    case 42:
                        buttonOperationMultiply_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    case 43:
                        buttonOperationPlus_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    case 44:
                        buttonComma_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    case 45:
                        buttonOperationMinus_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    case 47:
                        buttonOperationDivision_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    case 94:
                        buttonOperationDegree_Click(textBox1, null);
                        e.Handled = true;
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
        }
    }
}