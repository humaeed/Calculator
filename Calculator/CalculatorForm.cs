using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        HistoryForm hForm;
        List<string> stuff;
        int operator_flag = 0;
        string result = "", operator_used = "", last_text = "", path, path2;
        bool start_flag = false, point_flag = false, equal_flag = false, hForm_flag = false;
        bool sqrt_flag = false, inverse_flag = false, square_flag = false, percent_flag = false;

        public CalculatorForm()
        {
            stuff = new List<string>();
            hForm = new HistoryForm();

            bool date_flag = false;
            string ds = DateTime.Now.ToLongDateString();

            path = Directory.GetCurrentDirectory() + "\\" + "History.txt";
            path2 = Directory.GetCurrentDirectory() + "\\" + "LastDate.txt";

            // Check last date used in LastDate.txt
            if (File.Exists(path2))
            {
                string s = File.ReadAllText(path2);
                if (s.Equals(ds))
                {
                    date_flag = true;
                }
                else
                {
                    string[] lines = { ds };
                    System.IO.File.WriteAllLines(path2, lines);
                }
            }
            else
            {
                FileStream fs = File.Create(path2);
                fs.Close();
                string[] lines = { ds };
                System.IO.File.WriteAllLines(path2, lines);
            }

            // Write new entry in History.txt
            if (File.Exists(path))
            {
                if (!date_flag)
                {
                    string[] lines = { "********** " + ds + " **********", "\n" };
                    System.IO.File.AppendAllLines(path, lines);
                }
            }
            else
            {
                FileStream fs = File.Create(path);
                fs.Close();
                string[] lines = { "********** " + ds + " **********", "\n" };
                System.IO.File.AppendAllLines(path, lines);
            }

            InitializeComponent();
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (inverse_flag || sqrt_flag || square_flag || percent_flag)
            {
                screen.Text = button.Text;
                stuff.RemoveAt(stuff.Count - 1);
                eLabel.Text = GetEquation();
                equal_flag = start_flag = point_flag = inverse_flag = sqrt_flag = square_flag = percent_flag = false;
            }

            if (equal_flag)
            {
                equal_flag = start_flag = point_flag = inverse_flag = sqrt_flag = square_flag = percent_flag = false;
                operator_used = "";
                screen.Text = "0";
            }

            if (operator_flag == 1)
            {
                screen.Text = "0";
                operator_flag = 2;
                start_flag = point_flag = false;
            }

            if (button.Text.Equals("."))
            {
                if (!point_flag)
                {
                    if (!start_flag)
                    {
                        screen.Text += button.Text;
                        start_flag = true;
                    }
                    else
                    {
                        screen.Text += button.Text;
                    }
                    point_flag = true;
                }
            }
            else if (button.Text.Equals("0"))
            {
                if (start_flag)
                {
                    screen.Text += button.Text;
                }
            }
            else
            {
                if (!start_flag)
                {
                    screen.Text = button.Text;
                    start_flag = true;
                }
                else
                {
                    screen.Text += button.Text;
                }
            }
        }

        private void OperatorButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (operator_flag == 0)
            {
                result = screen.Text;
                operator_flag = 1;
                if (inverse_flag || sqrt_flag || square_flag || percent_flag)
                {
                    inverse_flag = sqrt_flag = square_flag = percent_flag = false;
                }
                else stuff.Add(screen.Text);
                stuff.Add(button.Text);
                operator_used = button.Text;
                eLabel.Text = GetEquation();
                equal_flag = false;
            }
            else if ((sqrt_flag || square_flag || inverse_flag || percent_flag) && operator_flag == 1)
            {
                double x = Double.Parse(result);
                double y = Double.Parse(screen.Text);
                double z = GetAnswer(x, y, operator_used);

                stuff.Add(button.Text);
                operator_used = button.Text;
                result = z.ToString();
                CheckForRound();
                screen.Text = result;
                eLabel.Text = GetEquation();
                inverse_flag = sqrt_flag = square_flag = percent_flag = false;
            }
            else if (operator_flag == 1 && !operator_used.Equals(button.Text))
            {
                stuff.RemoveAt(stuff.Count - 1);
                stuff.Add(button.Text);
                operator_used = button.Text;
                eLabel.Text = GetEquation();
            }
            else if (operator_flag == 2)
            {
                double x = Double.Parse(result);
                double y = Double.Parse(screen.Text);
                double z = GetAnswer(x, y, operator_used);

                operator_used = button.Text;
                if (inverse_flag || sqrt_flag || square_flag || percent_flag)
                {
                    inverse_flag = sqrt_flag = square_flag = percent_flag = false;
                }
                else stuff.Add(screen.Text);
                stuff.Add(button.Text);
                eLabel.Text = GetEquation();
                result = z.ToString();
                CheckForRound();
                screen.Text = result;
                operator_flag = 1;
            }
        }

        private void InverseClick(object sender, EventArgs e)
        {
            if (screen.Text.Equals("0"))
            {
                eLabel.Text = "1/(" + eLabel.Text + ")";
                screen.Text = "Math ERROR";
                DisableButtons();
            }
            else if (equal_flag)
            {
                if (stuff.Count == 0) stuff.Add("1/(" + screen.Text + ")");
                else stuff[0] = "1/(" + stuff[0] + ")";
                eLabel.Text = stuff[0];
                inverse_flag = true;
                screen.Text = result = CheckForRound((1 / Double.Parse(screen.Text)).ToString());
            }
            else
            {
                if (inverse_flag)
                {
                    stuff[stuff.Count - 1] = "1/(" + stuff[stuff.Count - 1] + ")";
                    screen.Text = CheckForRound((1 / Double.Parse(screen.Text)).ToString());
                    eLabel.Text = GetEquation();
                }
                else
                {
                    if (sqrt_flag || square_flag || percent_flag)
                    {
                        stuff[stuff.Count - 1] = "1/(" + stuff[stuff.Count - 1] + ")";
                        sqrt_flag = square_flag = percent_flag = false;
                    }
                    else stuff.Add("1/(" + screen.Text + ")");
                    inverse_flag = true;
                    eLabel.Text = GetEquation();
                    equal_flag = false;
                    screen.Text = CheckForRound((1 / Double.Parse(screen.Text)).ToString());
                }
            }
        }

        private void SqrtClick(object sender, EventArgs e)
        {
            if (equal_flag)
            {
                if (stuff.Count == 0) stuff.Add("√(" + screen.Text + ")");
                else stuff[0] = "√(" + stuff[0] + ")";
                eLabel.Text = stuff[0];
                screen.Text = result = CheckForRound(Math.Sqrt(Double.Parse(screen.Text)).ToString());
                if (screen.Text.Equals("NaN"))
                {
                    DisableButtons();
                    screen.Text = "Invalid Input";
                }
                sqrt_flag = true;
            }
            else if (sqrt_flag)
            {
                stuff[stuff.Count - 1] = "√(" + stuff[stuff.Count - 1] + ")";
                screen.Text = CheckForRound(Math.Sqrt(Double.Parse(screen.Text)).ToString());
                eLabel.Text = GetEquation();
                if (screen.Text.Equals("NaN"))
                {
                    DisableButtons();
                    screen.Text = "Invalid Input";
                }
            }
            else
            {
                if (inverse_flag || square_flag || percent_flag)
                {
                    stuff[stuff.Count - 1] = "√(" + stuff[stuff.Count - 1] + ")";
                    inverse_flag = square_flag = percent_flag = false;
                }
                else stuff.Add("√(" + screen.Text + ")");
                sqrt_flag = true;
                eLabel.Text = GetEquation();
                equal_flag = false;
                screen.Text = CheckForRound(Math.Sqrt(Double.Parse(screen.Text)).ToString());
                if (screen.Text.Equals("NaN"))
                {
                    DisableButtons();
                    screen.Text = "Invalid Input";
                }
            }
        }

        private void SquareClick(object sender, EventArgs e)
        {
            if (equal_flag)
            {
                if (stuff.Count == 0) stuff.Add("sqr(" + screen.Text + ")");
                else stuff[0] = "sqr(" + stuff[0] + ")";
                eLabel.Text = stuff[0];
                square_flag = true;
                screen.Text = result = CheckForRound(Math.Pow(Double.Parse(screen.Text), 2).ToString());
            }
            else if (square_flag)
            {
                stuff[stuff.Count - 1] = "sqr(" + stuff[stuff.Count - 1] + ")";
                screen.Text = CheckForRound(Math.Pow(Double.Parse(screen.Text), 2).ToString());
                eLabel.Text = GetEquation();
            }
            else
            {
                if (inverse_flag || sqrt_flag || percent_flag)
                {
                    stuff[stuff.Count - 1] = "sqr(" + stuff[stuff.Count - 1] + ")";
                    inverse_flag = sqrt_flag = percent_flag = false;
                }
                else stuff.Add("sqr(" + screen.Text + ")");
                square_flag = true;
                eLabel.Text = GetEquation();
                equal_flag = false;
                screen.Text = CheckForRound(Math.Pow(Double.Parse(screen.Text), 2).ToString());
            }
        }

        private void PercentClick(object sender, EventArgs e) 
        {
            if (result.Equals(""))
            {
                screen.Text = eLabel.Text = result = "0";
                return;
            }

            double ans = GetAnswer(Double.Parse(screen.Text) / 100, Double.Parse(result), operator_used);

            if (equal_flag)
            {
                if (stuff.Count == 0) stuff.Add(ans.ToString());
                else stuff[0] = ans.ToString();
                screen.Text = eLabel.Text = result = stuff[0];
                percent_flag = true;
                return;
            }

            if (percent_flag)
            {
                screen.Text = ans.ToString();
                stuff[stuff.Count - 1] = screen.Text;
                eLabel.Text = GetEquation();
            }
            else
            {
                if (inverse_flag || sqrt_flag || square_flag)
                {
                    inverse_flag = sqrt_flag = square_flag = false;
                    stuff[stuff.Count - 1] = screen.Text = ans.ToString();
                }
                else
                {
                    screen.Text = ans.ToString();
                    stuff.Add(screen.Text);
                }
                percent_flag = true;
                eLabel.Text = GetEquation();
                equal_flag = false;
            }
        }

        private void NegateClick(object sender, EventArgs e) 
        {
            if (screen.Text.Equals("0"))
            {
                // nothing :D for now atleast
            }
            else if (screen.Text[0] != '-')
            {
                screen.Text = "-" + screen.Text;
            }
            else
            {
                string x = "";
                for (int i = 1; i < screen.Text.Length; i++)
                {
                    x += screen.Text[i];
                }
                screen.Text = x;
            }

            
            if (!start_flag) start_flag = true;
            if (!operator_used.Equals("")) operator_flag = 2;

            point_flag = false; // point check
            for (int i = 0; i < screen.Text.Length; i++)
            {
                if (screen.Text[i] == '.')
                {
                    point_flag = true;
                    break;
                }
            }
        }

        private void EqualsButtonClick(object sender, EventArgs e)
        {
            if (equal_flag)
            {
                if (operator_used.Equals("")) return;

                double x = Double.Parse(result);
                double y = Double.Parse(last_text);
                double z = GetAnswer(x, y, operator_used);

                if (!inverse_flag && !sqrt_flag && !square_flag && !percent_flag) stuff.Add(result);
                stuff.Add(operator_used);
                stuff.Add(last_text);
                result = z.ToString();
                if (screen.Text.Equals("NaN"))
                {
                    DisableButtons();
                    screen.Text = "Invalid Input";
                }
                CheckForRound();
                screen.Text = result;
            }
            else if (operator_flag == 1 || operator_flag == 2) 
            {
                double x = Double.Parse(result);
                double y = Double.Parse(screen.Text);
                double z = GetAnswer(x, y, operator_used);

                last_text = screen.Text;
                if (!inverse_flag && !sqrt_flag && !square_flag && !percent_flag)
                    stuff.Add(screen.Text);
                result = z.ToString();
                if (screen.Text.Equals("NaN"))
                {
                    DisableButtons();
                    screen.Text = "Invalid Input";
                }
                CheckForRound();
                screen.Text = result;
                eLabel.Text = "";
                operator_flag = 0;
                equal_flag = true;
            }
            else if (inverse_flag || sqrt_flag || square_flag || percent_flag)
            {
                inverse_flag = square_flag = sqrt_flag = percent_flag = false;
                last_text = result = screen.Text;
                screen.Text = result;
                eLabel.Text = "";
                equal_flag = true;
            }

            if (inverse_flag || sqrt_flag || square_flag || percent_flag)
            {
                inverse_flag = square_flag = sqrt_flag = percent_flag = false;
                last_text = result = screen.Text;
                screen.Text = result;
                eLabel.Text = "";
                equal_flag = true;
            }

            inverse_flag = sqrt_flag = square_flag = percent_flag = false;

            // History File Input
            if (File.Exists(path))
            {
                string[] lines = { GetEquation() + "=" + result, "\n" };
                System.IO.File.AppendAllLines(path, lines);
            }
            else
            {
                FileStream fs = File.Create(path);
                fs.Close();
                string[] lines = { GetEquation() + "=" + result, "\n" };
                System.IO.File.AppendAllLines(path, lines);
            }

            // History Form Input
            //SHOW.Text = GetEquation();
            hForm.GetSetHistory(GetEquation(), result);
            stuff.Clear();
        }

        private void BackspaceButtonClick(object sender, EventArgs e)
        {
            if (!screen.Text.Equals("0") && !equal_flag && operator_flag == 0)
            {
                if (screen.Text.Length == 1 || (screen.Text.Length == 2 && screen.Text[0] == '-'))
                {
                    screen.Text = "0";
                    start_flag = point_flag = false;
                }
                else
                {
                    if (screen.Text[screen.Text.Length - 1] == '.')
                    {
                        screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
                        point_flag = false;
                    }
                    else
                    {
                        screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
                    }
                }
            }
            else if (operator_flag == 2)
            {
                if (screen.Text.Length == 1 || (screen.Text.Length == 2 && screen.Text[0] == '-'))
                {
                    screen.Text = "0";
                    start_flag = point_flag = false;
                }
                else
                {
                    if (screen.Text[screen.Text.Length - 1] == '.')
                    {
                        screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
                        point_flag = false;
                    }
                    else
                    {
                        screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
                    }
                }
            }
        }

        private void ClearClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (button.Text.Equals("C"))
            {
                start_flag = point_flag = equal_flag = inverse_flag = false;
                sqrt_flag = square_flag = percent_flag = false;
                operator_used = eLabel.Text = "";
                operator_flag = 0;
                screen.Text = "0";
                stuff.Clear();
                result = "";
            }
            else
            {
                screen.Text = "0";
                start_flag = point_flag = equal_flag = inverse_flag = false;
                sqrt_flag = square_flag = percent_flag = false;

            }
            EnableButtons();
        }

        private double GetAnswer(double x, double y, string op)
        {
            switch (op)
            {
                case "+":
                    return x + y;
                case "−":
                    return x - y;
                case "×":
                    return x * y;
                case "÷":
                    return x / y;
            }
            return 0;
        }

        private void NumberKeyPress(object sender, KeyPressEventArgs e) // not done yet
        {

        }

        private void HistoryClick(object sender, EventArgs e)
        {
            if (hForm_flag)
            {
                hForm_flag = false;
                hForm.Hide();
            }
            else
            {
                hForm_flag = true;
                hForm.Show();
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            treeView.Visible = false;
        }

        private void SidebarClick(object sender, EventArgs e)
        {
            if (treeView.Visible)
            {
                treeView.Visible = false;
            }
            else
            {
                treeView.Visible = true;
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) 
        {
            if (e.Node.Text.Equals("About"))
            {
                treeView.Visible = false;
                MessageBox.Show("                               Calculator\n    © 2018 Badassiumoxide. All rights reserved.",
                                "About");
            }
            else
                treeView.Visible = false;
        }

        private void CalcFormClick(object sender, EventArgs e)
        {
            treeView.Visible = false;
        }

        private string CheckForRound(string s)
        {
            int c = 0; // Ceil
            for (int i = 0; i < s.Length; i++)
            {
                bool flag = false;
                if (s[i] == '.')
                {
                    i++;
                    while (i < s.Length)
                    {
                        if (s[i] == '9')
                        {
                            c++;
                            i++;
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }
            }

            if (c > 9)
            {
                return s = (Math.Ceiling(Double.Parse(s))).ToString();
            }

            c = 0; // Floor
            for (int i = 0; i < s.Length; i++)
            {
                bool flag = false;
                if (s[i] == '.')
                {
                    i++;
                    while (i < s.Length)
                    {
                        if (s[i] == '0')
                        {
                            c++;
                            i++;
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }
            }

            if (c > 9)
            {
                return s = (Math.Floor(Double.Parse(s))).ToString();
            }

            return s;
        }

        private void CheckForRound()
        {
            int c = 0; // Ceil
            for (int i = 0; i < result.Length; i++)
            {
                bool flag = false;
                if (result[i] == '.')
                {
                    i++;
                    while (i < result.Length)
                    {
                        if (result[i] == '9')
                        {
                            c++;
                            i++;
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }
            }

            if (c > 9)
            {
                result = (Math.Ceiling(Double.Parse(result))).ToString();
                return;
            }

            c = 0; // Floor
            for (int i = 0; i < result.Length; i++)
            {
                bool flag = false;
                if (result[i] == '.')
                {
                    i++;
                    while (i < result.Length)
                    {
                        if (result[i] == '0')
                        {
                            c++;
                            i++;
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }
            }

            if (c > 9)
            {
                result = (Math.Floor(Double.Parse(result))).ToString();
            }
        }

        private string GetEquation()
        {
            string x = "";
            foreach (string i in stuff)
            {
                x += i;
            }
            return x;
        }

        private void EnableButtons()
        {
            one.Enabled = two.Enabled = three.Enabled = four.Enabled = five.Enabled =
            six.Enabled = seven.Enabled = eight.Enabled = nine.Enabled = zero.Enabled =
            plus.Enabled = minus.Enabled = multiply.Enabled = negate.Enabled = clearEntry.Enabled = 
            percent.Enabled = sqrt.Enabled = divide.Enabled = square.Enabled = 
            inverse.Enabled = point.Enabled = equal.Enabled = backspace.Enabled = true;
        }

        private void DisableButtons()
        {
            one.Enabled = two.Enabled = three.Enabled = four.Enabled = five.Enabled =
            six.Enabled = seven.Enabled = eight.Enabled = nine.Enabled = zero.Enabled =
            plus.Enabled = minus.Enabled = multiply.Enabled = negate.Enabled = clearEntry.Enabled =
            percent.Enabled = sqrt.Enabled = divide.Enabled = square.Enabled =
            inverse.Enabled = point.Enabled = equal.Enabled = backspace.Enabled = false;
        }
    }
}
