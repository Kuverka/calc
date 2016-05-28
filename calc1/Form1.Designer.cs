namespace calc1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenBracket = new System.Windows.Forms.Button();
            this.buttonCloseBracket = new System.Windows.Forms.Button();
            this.buttonOperationDegree = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonOperationMinus = new System.Windows.Forms.Button();
            this.buttonOperationPlus = new System.Windows.Forms.Button();
            this.buttonOperationMultiply = new System.Windows.Forms.Button();
            this.buttonOperationDivision = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonOperationRoot = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.radioButtonNotationBin = new System.Windows.Forms.RadioButton();
            this.radioButtonNotationOct = new System.Windows.Forms.RadioButton();
            this.radioButtonNotationHex = new System.Windows.Forms.RadioButton();
            this.radioButtonNotationDec = new System.Windows.Forms.RadioButton();
            this.buttonHexF = new System.Windows.Forms.Button();
            this.buttonHexE = new System.Windows.Forms.Button();
            this.buttonHexD = new System.Windows.Forms.Button();
            this.buttonHexC = new System.Windows.Forms.Button();
            this.buttonHexA = new System.Windows.Forms.Button();
            this.buttonHexB = new System.Windows.Forms.Button();
            this.buttonLogicNot = new System.Windows.Forms.Button();
            this.buttonLogicXor = new System.Windows.Forms.Button();
            this.buttonLogicOr = new System.Windows.Forms.Button();
            this.buttonLogicAnd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(202, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 20;
            // 
            // buttonOpenBracket
            // 
            this.buttonOpenBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenBracket.Location = new System.Drawing.Point(126, 55);
            this.buttonOpenBracket.Name = "buttonOpenBracket";
            this.buttonOpenBracket.Size = new System.Drawing.Size(50, 33);
            this.buttonOpenBracket.TabIndex = 21;
            this.buttonOpenBracket.Text = "(";
            this.buttonOpenBracket.UseVisualStyleBackColor = true;
            this.buttonOpenBracket.Click += new System.EventHandler(this.buttonOpenBracket_Click);
            // 
            // buttonCloseBracket
            // 
            this.buttonCloseBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseBracket.Location = new System.Drawing.Point(182, 55);
            this.buttonCloseBracket.Name = "buttonCloseBracket";
            this.buttonCloseBracket.Size = new System.Drawing.Size(50, 33);
            this.buttonCloseBracket.TabIndex = 22;
            this.buttonCloseBracket.Text = ")";
            this.buttonCloseBracket.UseVisualStyleBackColor = true;
            this.buttonCloseBracket.Click += new System.EventHandler(this.buttonCloseBracket_Click);
            // 
            // buttonOperationDegree
            // 
            this.buttonOperationDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationDegree.Location = new System.Drawing.Point(70, 94);
            this.buttonOperationDegree.Name = "buttonOperationDegree";
            this.buttonOperationDegree.Size = new System.Drawing.Size(50, 33);
            this.buttonOperationDegree.TabIndex = 23;
            this.buttonOperationDegree.Text = "^";
            this.buttonOperationDegree.UseVisualStyleBackColor = true;
            this.buttonOperationDegree.Click += new System.EventHandler(this.buttonOperationDegree_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 148);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(104, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Лог выполнения действия";
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber6.Location = new System.Drawing.Point(126, 172);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber6.TabIndex = 27;
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = true;
            this.buttonNumber6.Click += new System.EventHandler(this.buttonNumber6_Click);
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber7.Location = new System.Drawing.Point(14, 133);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber7.TabIndex = 28;
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = true;
            this.buttonNumber7.Click += new System.EventHandler(this.buttonNumber7_Click);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber8.Location = new System.Drawing.Point(70, 133);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber8.TabIndex = 29;
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = true;
            this.buttonNumber8.Click += new System.EventHandler(this.buttonNumber8_Click);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber9.Location = new System.Drawing.Point(126, 133);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber9.TabIndex = 30;
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = true;
            this.buttonNumber9.Click += new System.EventHandler(this.buttonNumber9_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber2.Location = new System.Drawing.Point(70, 211);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber2.TabIndex = 31;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            this.buttonNumber2.Click += new System.EventHandler(this.buttonNumber2_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber3.Location = new System.Drawing.Point(126, 211);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber3.TabIndex = 32;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            this.buttonNumber3.Click += new System.EventHandler(this.buttonNumber3_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber4.Location = new System.Drawing.Point(14, 172);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber4.TabIndex = 33;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            this.buttonNumber4.Click += new System.EventHandler(this.buttonNumber4_Click);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber5.Location = new System.Drawing.Point(70, 172);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber5.TabIndex = 34;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = true;
            this.buttonNumber5.Click += new System.EventHandler(this.buttonNumber5_Click);
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber1.Location = new System.Drawing.Point(14, 211);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(50, 33);
            this.buttonNumber1.TabIndex = 35;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber1_Click);
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber0.Location = new System.Drawing.Point(14, 250);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(106, 33);
            this.buttonNumber0.TabIndex = 36;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = true;
            this.buttonNumber0.Click += new System.EventHandler(this.buttonNumber0_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComma.Location = new System.Drawing.Point(126, 250);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(50, 33);
            this.buttonComma.TabIndex = 37;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.buttonComma_Click);
            // 
            // buttonOperationMinus
            // 
            this.buttonOperationMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationMinus.Location = new System.Drawing.Point(182, 133);
            this.buttonOperationMinus.Name = "buttonOperationMinus";
            this.buttonOperationMinus.Size = new System.Drawing.Size(50, 33);
            this.buttonOperationMinus.TabIndex = 38;
            this.buttonOperationMinus.Text = "-";
            this.buttonOperationMinus.UseVisualStyleBackColor = true;
            this.buttonOperationMinus.Click += new System.EventHandler(this.buttonOperationMinus_Click);
            // 
            // buttonOperationPlus
            // 
            this.buttonOperationPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationPlus.Location = new System.Drawing.Point(182, 172);
            this.buttonOperationPlus.Name = "buttonOperationPlus";
            this.buttonOperationPlus.Size = new System.Drawing.Size(50, 33);
            this.buttonOperationPlus.TabIndex = 39;
            this.buttonOperationPlus.Text = "+";
            this.buttonOperationPlus.UseVisualStyleBackColor = true;
            this.buttonOperationPlus.Click += new System.EventHandler(this.buttonOperationPlus_Click);
            // 
            // buttonOperationMultiply
            // 
            this.buttonOperationMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationMultiply.Location = new System.Drawing.Point(182, 94);
            this.buttonOperationMultiply.Name = "buttonOperationMultiply";
            this.buttonOperationMultiply.Size = new System.Drawing.Size(50, 33);
            this.buttonOperationMultiply.TabIndex = 40;
            this.buttonOperationMultiply.Text = "*";
            this.buttonOperationMultiply.UseVisualStyleBackColor = true;
            this.buttonOperationMultiply.Click += new System.EventHandler(this.buttonOperationMultiply_Click);
            // 
            // buttonOperationDivision
            // 
            this.buttonOperationDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationDivision.Location = new System.Drawing.Point(126, 94);
            this.buttonOperationDivision.Name = "buttonOperationDivision";
            this.buttonOperationDivision.Size = new System.Drawing.Size(50, 33);
            this.buttonOperationDivision.TabIndex = 41;
            this.buttonOperationDivision.Text = "/";
            this.buttonOperationDivision.UseVisualStyleBackColor = true;
            this.buttonOperationDivision.Click += new System.EventHandler(this.buttonOperationDivision_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(14, 55);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 33);
            this.buttonClear.TabIndex = 42;
            this.buttonClear.Text = "С";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackspace.Location = new System.Drawing.Point(70, 55);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(50, 33);
            this.buttonBackspace.TabIndex = 43;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonOperationRoot
            // 
            this.buttonOperationRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationRoot.Location = new System.Drawing.Point(14, 94);
            this.buttonOperationRoot.Name = "buttonOperationRoot";
            this.buttonOperationRoot.Size = new System.Drawing.Size(50, 33);
            this.buttonOperationRoot.TabIndex = 44;
            this.buttonOperationRoot.Text = "√";
            this.buttonOperationRoot.UseVisualStyleBackColor = true;
            this.buttonOperationRoot.Click += new System.EventHandler(this.buttonOperationRoot_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(182, 211);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(50, 72);
            this.buttonCalculate.TabIndex = 45;
            this.buttonCalculate.Text = "=";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // radioButtonNotationBin
            // 
            this.radioButtonNotationBin.AutoSize = true;
            this.radioButtonNotationBin.Location = new System.Drawing.Point(9, 16);
            this.radioButtonNotationBin.Name = "radioButtonNotationBin";
            this.radioButtonNotationBin.Size = new System.Drawing.Size(40, 17);
            this.radioButtonNotationBin.TabIndex = 46;
            this.radioButtonNotationBin.Text = "Bin";
            this.radioButtonNotationBin.UseVisualStyleBackColor = true;
            this.radioButtonNotationBin.CheckedChanged += new System.EventHandler(this.radioButtonNotationBin_CheckedChanged);
            // 
            // radioButtonNotationOct
            // 
            this.radioButtonNotationOct.AutoSize = true;
            this.radioButtonNotationOct.Location = new System.Drawing.Point(65, 16);
            this.radioButtonNotationOct.Name = "radioButtonNotationOct";
            this.radioButtonNotationOct.Size = new System.Drawing.Size(42, 17);
            this.radioButtonNotationOct.TabIndex = 47;
            this.radioButtonNotationOct.Text = "Oct";
            this.radioButtonNotationOct.UseVisualStyleBackColor = true;
            this.radioButtonNotationOct.CheckedChanged += new System.EventHandler(this.radioButtonNotationOct_CheckedChanged);
            // 
            // radioButtonNotationHex
            // 
            this.radioButtonNotationHex.AutoSize = true;
            this.radioButtonNotationHex.Location = new System.Drawing.Point(65, 47);
            this.radioButtonNotationHex.Name = "radioButtonNotationHex";
            this.radioButtonNotationHex.Size = new System.Drawing.Size(44, 17);
            this.radioButtonNotationHex.TabIndex = 49;
            this.radioButtonNotationHex.Text = "Hex";
            this.radioButtonNotationHex.UseVisualStyleBackColor = true;
            this.radioButtonNotationHex.CheckedChanged += new System.EventHandler(this.radioButtonNotationHex_CheckedChanged);
            // 
            // radioButtonNotationDec
            // 
            this.radioButtonNotationDec.AutoSize = true;
            this.radioButtonNotationDec.Checked = true;
            this.radioButtonNotationDec.Location = new System.Drawing.Point(9, 47);
            this.radioButtonNotationDec.Name = "radioButtonNotationDec";
            this.radioButtonNotationDec.Size = new System.Drawing.Size(45, 17);
            this.radioButtonNotationDec.TabIndex = 48;
            this.radioButtonNotationDec.TabStop = true;
            this.radioButtonNotationDec.Text = "Dec";
            this.radioButtonNotationDec.UseVisualStyleBackColor = true;
            this.radioButtonNotationDec.CheckedChanged += new System.EventHandler(this.radioButtonNotationDec_CheckedChanged);
            // 
            // buttonHexF
            // 
            this.buttonHexF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHexF.Location = new System.Drawing.Point(63, 238);
            this.buttonHexF.Name = "buttonHexF";
            this.buttonHexF.Size = new System.Drawing.Size(50, 33);
            this.buttonHexF.TabIndex = 50;
            this.buttonHexF.Text = "F";
            this.buttonHexF.UseVisualStyleBackColor = true;
            this.buttonHexF.Click += new System.EventHandler(this.buttonHexF_Click);
            // 
            // buttonHexE
            // 
            this.buttonHexE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHexE.Location = new System.Drawing.Point(63, 199);
            this.buttonHexE.Name = "buttonHexE";
            this.buttonHexE.Size = new System.Drawing.Size(50, 33);
            this.buttonHexE.TabIndex = 51;
            this.buttonHexE.Text = "E";
            this.buttonHexE.UseVisualStyleBackColor = true;
            this.buttonHexE.Click += new System.EventHandler(this.buttonHexE_Click);
            // 
            // buttonHexD
            // 
            this.buttonHexD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHexD.Location = new System.Drawing.Point(63, 160);
            this.buttonHexD.Name = "buttonHexD";
            this.buttonHexD.Size = new System.Drawing.Size(50, 33);
            this.buttonHexD.TabIndex = 52;
            this.buttonHexD.Text = "D";
            this.buttonHexD.UseVisualStyleBackColor = true;
            this.buttonHexD.Click += new System.EventHandler(this.buttonHexD_Click);
            // 
            // buttonHexC
            // 
            this.buttonHexC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHexC.Location = new System.Drawing.Point(7, 238);
            this.buttonHexC.Name = "buttonHexC";
            this.buttonHexC.Size = new System.Drawing.Size(50, 33);
            this.buttonHexC.TabIndex = 53;
            this.buttonHexC.Text = "C";
            this.buttonHexC.UseVisualStyleBackColor = true;
            this.buttonHexC.Click += new System.EventHandler(this.buttonHexC_Click);
            // 
            // buttonHexA
            // 
            this.buttonHexA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHexA.Location = new System.Drawing.Point(7, 160);
            this.buttonHexA.Name = "buttonHexA";
            this.buttonHexA.Size = new System.Drawing.Size(50, 33);
            this.buttonHexA.TabIndex = 54;
            this.buttonHexA.Text = "A";
            this.buttonHexA.UseVisualStyleBackColor = true;
            this.buttonHexA.Click += new System.EventHandler(this.buttonHexA_Click);
            // 
            // buttonHexB
            // 
            this.buttonHexB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHexB.Location = new System.Drawing.Point(7, 199);
            this.buttonHexB.Name = "buttonHexB";
            this.buttonHexB.Size = new System.Drawing.Size(50, 33);
            this.buttonHexB.TabIndex = 55;
            this.buttonHexB.Text = "B";
            this.buttonHexB.UseVisualStyleBackColor = true;
            this.buttonHexB.Click += new System.EventHandler(this.buttonHexB_Click);
            // 
            // buttonLogicNot
            // 
            this.buttonLogicNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogicNot.Location = new System.Drawing.Point(63, 121);
            this.buttonLogicNot.Name = "buttonLogicNot";
            this.buttonLogicNot.Size = new System.Drawing.Size(50, 33);
            this.buttonLogicNot.TabIndex = 56;
            this.buttonLogicNot.Text = "Not";
            this.buttonLogicNot.UseVisualStyleBackColor = true;
            this.buttonLogicNot.Click += new System.EventHandler(this.buttonLogicNot_Click);
            // 
            // buttonLogicXor
            // 
            this.buttonLogicXor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogicXor.Location = new System.Drawing.Point(63, 82);
            this.buttonLogicXor.Name = "buttonLogicXor";
            this.buttonLogicXor.Size = new System.Drawing.Size(50, 33);
            this.buttonLogicXor.TabIndex = 57;
            this.buttonLogicXor.Text = "Xor";
            this.buttonLogicXor.UseVisualStyleBackColor = true;
            this.buttonLogicXor.Click += new System.EventHandler(this.buttonLogicXor_Click);
            // 
            // buttonLogicOr
            // 
            this.buttonLogicOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogicOr.Location = new System.Drawing.Point(7, 82);
            this.buttonLogicOr.Name = "buttonLogicOr";
            this.buttonLogicOr.Size = new System.Drawing.Size(50, 33);
            this.buttonLogicOr.TabIndex = 58;
            this.buttonLogicOr.Text = "Or";
            this.buttonLogicOr.UseVisualStyleBackColor = true;
            this.buttonLogicOr.Click += new System.EventHandler(this.buttonLogicOr_Click);
            // 
            // buttonLogicAnd
            // 
            this.buttonLogicAnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogicAnd.Location = new System.Drawing.Point(7, 121);
            this.buttonLogicAnd.Name = "buttonLogicAnd";
            this.buttonLogicAnd.Size = new System.Drawing.Size(50, 33);
            this.buttonLogicAnd.TabIndex = 59;
            this.buttonLogicAnd.Text = "And";
            this.buttonLogicAnd.UseVisualStyleBackColor = true;
            this.buttonLogicAnd.Click += new System.EventHandler(this.buttonLogicAnd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.buttonLogicOr);
            this.panel2.Controls.Add(this.buttonLogicAnd);
            this.panel2.Controls.Add(this.buttonHexF);
            this.panel2.Controls.Add(this.buttonHexE);
            this.panel2.Controls.Add(this.buttonLogicXor);
            this.panel2.Controls.Add(this.buttonHexD);
            this.panel2.Controls.Add(this.buttonLogicNot);
            this.panel2.Controls.Add(this.radioButtonNotationHex);
            this.panel2.Controls.Add(this.radioButtonNotationDec);
            this.panel2.Controls.Add(this.buttonHexC);
            this.panel2.Controls.Add(this.radioButtonNotationOct);
            this.panel2.Controls.Add(this.buttonHexB);
            this.panel2.Controls.Add(this.radioButtonNotationBin);
            this.panel2.Controls.Add(this.buttonHexA);
            this.panel2.Location = new System.Drawing.Point(245, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 271);
            this.panel2.TabIndex = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonOperationDegree);
            this.Controls.Add(this.buttonOperationMinus);
            this.Controls.Add(this.buttonOperationRoot);
            this.Controls.Add(this.buttonOperationPlus);
            this.Controls.Add(this.buttonOperationDivision);
            this.Controls.Add(this.buttonOperationMultiply);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.buttonNumber0);
            this.Controls.Add(this.buttonNumber1);
            this.Controls.Add(this.buttonNumber5);
            this.Controls.Add(this.buttonNumber4);
            this.Controls.Add(this.buttonNumber3);
            this.Controls.Add(this.buttonNumber2);
            this.Controls.Add(this.buttonNumber9);
            this.Controls.Add(this.buttonNumber8);
            this.Controls.Add(this.buttonNumber7);
            this.Controls.Add(this.buttonNumber6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCloseBracket);
            this.Controls.Add(this.buttonOpenBracket);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenBracket;
        private System.Windows.Forms.Button buttonCloseBracket;
        private System.Windows.Forms.Button buttonOperationDegree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNumber6;
        private System.Windows.Forms.Button buttonNumber7;
        private System.Windows.Forms.Button buttonNumber8;
        private System.Windows.Forms.Button buttonNumber9;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button buttonNumber0;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonOperationMinus;
        private System.Windows.Forms.Button buttonOperationPlus;
        private System.Windows.Forms.Button buttonOperationMultiply;
        private System.Windows.Forms.Button buttonOperationDivision;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonOperationRoot;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.RadioButton radioButtonNotationBin;
        private System.Windows.Forms.RadioButton radioButtonNotationOct;
        private System.Windows.Forms.RadioButton radioButtonNotationHex;
        private System.Windows.Forms.RadioButton radioButtonNotationDec;
        private System.Windows.Forms.Button buttonHexF;
        private System.Windows.Forms.Button buttonHexE;
        private System.Windows.Forms.Button buttonHexD;
        private System.Windows.Forms.Button buttonHexC;
        private System.Windows.Forms.Button buttonHexA;
        private System.Windows.Forms.Button buttonHexB;
        private System.Windows.Forms.Button buttonLogicNot;
        private System.Windows.Forms.Button buttonLogicXor;
        private System.Windows.Forms.Button buttonLogicOr;
        private System.Windows.Forms.Button buttonLogicAnd;
        private System.Windows.Forms.Panel panel2;
    }
}

