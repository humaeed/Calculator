namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Temperature");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Standard");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("About");
            this.negate = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.TextBox();
            this.eLabel = new System.Windows.Forms.Label();
            this.MC = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MPlus = new System.Windows.Forms.Button();
            this.MMinus = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.Sidebar = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.MStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // negate
            // 
            this.negate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.negate.FlatAppearance.BorderSize = 0;
            this.negate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.negate.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negate.Location = new System.Drawing.Point(5, 480);
            this.negate.Name = "negate";
            this.negate.Size = new System.Drawing.Size(75, 55);
            this.negate.TabIndex = 0;
            this.negate.Text = "±";
            this.negate.UseVisualStyleBackColor = false;
            this.negate.Click += new System.EventHandler(this.NegateClick);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.Window;
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(85, 480);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 55);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.NumberButtonClick);
            this.zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ControlLight;
            this.point.FlatAppearance.BorderSize = 0;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(165, 480);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(75, 55);
            this.point.TabIndex = 2;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.NumberButtonClick);
            this.point.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equal.FlatAppearance.BorderSize = 0;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(245, 480);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 55);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.EqualsButtonClick);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(245, 420);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 55);
            this.plus.TabIndex = 7;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.Window;
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(165, 420);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 55);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.NumberButtonClick);
            this.three.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.Window;
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(85, 420);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 55);
            this.two.TabIndex = 5;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.NumberButtonClick);
            this.two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.Window;
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(5, 420);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 55);
            this.one.TabIndex = 4;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.NumberButtonClick);
            this.one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(245, 360);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 55);
            this.minus.TabIndex = 11;
            this.minus.Text = "−";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.Window;
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(165, 360);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 55);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.NumberButtonClick);
            this.six.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.Window;
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(85, 360);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 55);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.NumberButtonClick);
            this.five.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.Window;
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(5, 360);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 55);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.NumberButtonClick);
            this.four.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(245, 300);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(75, 55);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.Window;
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(165, 300);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 55);
            this.nine.TabIndex = 14;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.NumberButtonClick);
            this.nine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.Window;
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(85, 300);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 55);
            this.eight.TabIndex = 13;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.NumberButtonClick);
            this.eight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.Window;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(5, 300);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 55);
            this.seven.TabIndex = 12;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.NumberButtonClick);
            this.seven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(245, 240);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 55);
            this.divide.TabIndex = 19;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(165, 240);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(75, 55);
            this.backspace.TabIndex = 18;
            this.backspace.Text = "⌫";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.BackspaceButtonClick);
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearAll.FlatAppearance.BorderSize = 0;
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.Location = new System.Drawing.Point(85, 240);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(75, 55);
            this.clearAll.TabIndex = 17;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.ClearClick);
            // 
            // clearEntry
            // 
            this.clearEntry.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearEntry.FlatAppearance.BorderSize = 0;
            this.clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntry.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntry.Location = new System.Drawing.Point(5, 240);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(75, 55);
            this.clearEntry.TabIndex = 16;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.ClearClick);
            // 
            // inverse
            // 
            this.inverse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inverse.FlatAppearance.BorderSize = 0;
            this.inverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inverse.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverse.Location = new System.Drawing.Point(245, 180);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(75, 55);
            this.inverse.TabIndex = 23;
            this.inverse.Text = "1/x";
            this.inverse.UseVisualStyleBackColor = false;
            this.inverse.Click += new System.EventHandler(this.InverseClick);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.ControlLight;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square.Location = new System.Drawing.Point(165, 180);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(75, 55);
            this.square.TabIndex = 22;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.SquareClick);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sqrt.FlatAppearance.BorderSize = 0;
            this.sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrt.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.Location = new System.Drawing.Point(85, 180);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(75, 55);
            this.sqrt.TabIndex = 21;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.SqrtClick);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.percent.FlatAppearance.BorderSize = 0;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(5, 180);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(75, 55);
            this.percent.TabIndex = 20;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.PercentClick);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Control;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screen.Enabled = false;
            this.screen.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(4, 79);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(315, 54);
            this.screen.TabIndex = 24;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.eLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.eLabel.Location = new System.Drawing.Point(0, 51);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(0, 21);
            this.eLabel.TabIndex = 25;
            // 
            // MC
            // 
            this.MC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MC.Enabled = false;
            this.MC.FlatAppearance.BorderSize = 0;
            this.MC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MC.Location = new System.Drawing.Point(5, 139);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(47, 35);
            this.MC.TabIndex = 26;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = false;
            // 
            // MR
            // 
            this.MR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MR.Enabled = false;
            this.MR.FlatAppearance.BorderSize = 0;
            this.MR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MR.Location = new System.Drawing.Point(58, 139);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(47, 35);
            this.MR.TabIndex = 27;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = false;
            // 
            // MPlus
            // 
            this.MPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MPlus.FlatAppearance.BorderSize = 0;
            this.MPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MPlus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPlus.Location = new System.Drawing.Point(113, 139);
            this.MPlus.Name = "MPlus";
            this.MPlus.Size = new System.Drawing.Size(47, 35);
            this.MPlus.TabIndex = 28;
            this.MPlus.Text = "M+";
            this.MPlus.UseVisualStyleBackColor = false;
            // 
            // MMinus
            // 
            this.MMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MMinus.FlatAppearance.BorderSize = 0;
            this.MMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MMinus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMinus.Location = new System.Drawing.Point(167, 139);
            this.MMinus.Name = "MMinus";
            this.MMinus.Size = new System.Drawing.Size(47, 35);
            this.MMinus.TabIndex = 29;
            this.MMinus.Text = "M-";
            this.MMinus.UseVisualStyleBackColor = false;
            // 
            // Memory
            // 
            this.Memory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Memory.Enabled = false;
            this.Memory.FlatAppearance.BorderSize = 0;
            this.Memory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Memory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memory.Location = new System.Drawing.Point(273, 139);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(47, 35);
            this.Memory.TabIndex = 30;
            this.Memory.Text = "M*";
            this.Memory.UseVisualStyleBackColor = false;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.Control;
            this.history.FlatAppearance.BorderSize = 0;
            this.history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.history.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Image = ((System.Drawing.Image)(resources.GetObject("history.Image")));
            this.history.Location = new System.Drawing.Point(280, 1);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(40, 40);
            this.history.TabIndex = 33;
            this.history.UseVisualStyleBackColor = false;
            this.history.Click += new System.EventHandler(this.HistoryClick);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.SystemColors.Control;
            this.Sidebar.FlatAppearance.BorderSize = 0;
            this.Sidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sidebar.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sidebar.Image = ((System.Drawing.Image)(resources.GetObject("Sidebar.Image")));
            this.Sidebar.Location = new System.Drawing.Point(4, 1);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(40, 40);
            this.Sidebar.TabIndex = 34;
            this.Sidebar.UseVisualStyleBackColor = false;
            this.Sidebar.Click += new System.EventHandler(this.SidebarClick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(50, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(113, 32);
            this.Title.TabIndex = 35;
            this.Title.Text = "Standard";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Control;
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(5, 47);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Temperature";
            treeNode1.Text = "Temperature";
            treeNode2.Name = "Standard";
            treeNode2.Text = "Standard";
            treeNode3.Name = "About";
            treeNode3.Text = "About";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView.ShowLines = false;
            this.treeView.Size = new System.Drawing.Size(195, 504);
            this.treeView.TabIndex = 36;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // MStore
            // 
            this.MStore.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MStore.Enabled = false;
            this.MStore.FlatAppearance.BorderSize = 0;
            this.MStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MStore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MStore.Location = new System.Drawing.Point(220, 139);
            this.MStore.Name = "MStore";
            this.MStore.Size = new System.Drawing.Size(47, 35);
            this.MStore.TabIndex = 38;
            this.MStore.Text = "MS";
            this.MStore.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(325, 541);
            this.Controls.Add(this.MStore);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.history);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.MMinus);
            this.Controls.Add(this.MPlus);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.square);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.negate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.Click += new System.EventHandler(this.CalcFormClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button negate;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button inverse;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button MPlus;
        private System.Windows.Forms.Button MMinus;
        private System.Windows.Forms.Button Memory;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button Sidebar;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button MStore;
    }
}

