

namespace VP_1
{
    class UnselectableButton : System.Windows.Forms.Button 
    {
        public UnselectableButton() : base()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.Selectable, false);
        }

        public void SimulateClick() 
        {
            InvokeOnClick(this,System.EventArgs.Empty);
        }
    }

    partial class CalculatorMainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        public void DisplayMessage(string message) 
        {
            transparentTextBox1.Text = message;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorMainWindow));
            this.WholeExpressionTextBox = new System.Windows.Forms.TextBox();
            this.CurrentInputTextBox = new System.Windows.Forms.TextBox();
            this.HeightButton = new VP_1.UnselectableButton();
            this.SqrtButton = new VP_1.UnselectableButton();
            this.AddButton = new VP_1.UnselectableButton();
            this.MultiplyButton = new VP_1.UnselectableButton();
            this.SubtractButton = new VP_1.UnselectableButton();
            this.DivideButton = new VP_1.UnselectableButton();
            this.EqualsButton = new VP_1.UnselectableButton();
            this.Number7 = new VP_1.UnselectableButton();
            this.Number8 = new VP_1.UnselectableButton();
            this.Number9 = new VP_1.UnselectableButton();
            this.Number6 = new VP_1.UnselectableButton();
            this.Number5 = new VP_1.UnselectableButton();
            this.Number4 = new VP_1.UnselectableButton();
            this.Number3 = new VP_1.UnselectableButton();
            this.Number2 = new VP_1.UnselectableButton();
            this.Number1 = new VP_1.UnselectableButton();
            this.DecimalButton = new VP_1.UnselectableButton();
            this.Number0 = new VP_1.UnselectableButton();
            this.transparentTextBox1 = new System.Windows.Forms.TextBox();
            this.CloseBracket = new VP_1.UnselectableButton();
            this.OpenBracket = new VP_1.UnselectableButton();
            this.ClearButton = new VP_1.UnselectableButton();
            this.SuspendLayout();
            // 
            // WholeExpressionTextBox
            // 
            this.WholeExpressionTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WholeExpressionTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WholeExpressionTextBox.ForeColor = System.Drawing.Color.Coral;
            this.WholeExpressionTextBox.Location = new System.Drawing.Point(11, 11);
            this.WholeExpressionTextBox.Multiline = true;
            this.WholeExpressionTextBox.Name = "WholeExpressionTextBox";
            this.WholeExpressionTextBox.ReadOnly = true;
            this.WholeExpressionTextBox.Size = new System.Drawing.Size(393, 97);
            this.WholeExpressionTextBox.TabIndex = 0;
            this.WholeExpressionTextBox.TabStop = false;
            this.WholeExpressionTextBox.TextChanged += new System.EventHandler(this.WholeExpressionTextBox_TextChanged);
            // 
            // CurrentInputTextBox
            // 
            this.CurrentInputTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CurrentInputTextBox.Enabled = false;
            this.CurrentInputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentInputTextBox.ForeColor = System.Drawing.Color.Coral;
            this.CurrentInputTextBox.Location = new System.Drawing.Point(269, 130);
            this.CurrentInputTextBox.Name = "CurrentInputTextBox";
            this.CurrentInputTextBox.Size = new System.Drawing.Size(135, 39);
            this.CurrentInputTextBox.TabIndex = 1;
            this.CurrentInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeightButton
            // 
            this.HeightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightButton.Location = new System.Drawing.Point(349, 210);
            this.HeightButton.Name = "HeightButton";
            this.HeightButton.Size = new System.Drawing.Size(54, 55);
            this.HeightButton.TabIndex = 2;
            this.HeightButton.Text = "hₐ";
            this.HeightButton.UseVisualStyleBackColor = true;
            this.HeightButton.Click += new System.EventHandler(this.HeightButton_Click);
            // 
            // SqrtButton
            // 
            this.SqrtButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqrtButton.Location = new System.Drawing.Point(269, 210);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(54, 55);
            this.SqrtButton.TabIndex = 3;
            this.SqrtButton.Text = "√";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(269, 294);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(54, 55);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.Location = new System.Drawing.Point(349, 294);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(54, 55);
            this.MultiplyButton.TabIndex = 5;
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubtractButton.Location = new System.Drawing.Point(269, 379);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(54, 55);
            this.SubtractButton.TabIndex = 6;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.Location = new System.Drawing.Point(349, 379);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(54, 55);
            this.DivideButton.TabIndex = 7;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualsButton.Location = new System.Drawing.Point(349, 464);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(54, 55);
            this.EqualsButton.TabIndex = 8;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // Number7
            // 
            this.Number7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number7.Location = new System.Drawing.Point(12, 210);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(54, 55);
            this.Number7.TabIndex = 9;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Number7_Click);
            // 
            // Number8
            // 
            this.Number8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number8.Location = new System.Drawing.Point(92, 210);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(54, 55);
            this.Number8.TabIndex = 10;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Number8_Click);
            // 
            // Number9
            // 
            this.Number9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number9.Location = new System.Drawing.Point(172, 210);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(54, 55);
            this.Number9.TabIndex = 11;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.Number9_Click);
            // 
            // Number6
            // 
            this.Number6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number6.Location = new System.Drawing.Point(172, 294);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(54, 55);
            this.Number6.TabIndex = 14;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Number6_Click);
            // 
            // Number5
            // 
            this.Number5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number5.Location = new System.Drawing.Point(92, 294);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(54, 55);
            this.Number5.TabIndex = 13;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Number5_Click);
            // 
            // Number4
            // 
            this.Number4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number4.Location = new System.Drawing.Point(12, 294);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(54, 55);
            this.Number4.TabIndex = 12;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Number4_Click);
            // 
            // Number3
            // 
            this.Number3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number3.Location = new System.Drawing.Point(172, 379);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(54, 55);
            this.Number3.TabIndex = 17;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.Number3_Click);
            // 
            // Number2
            // 
            this.Number2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number2.Location = new System.Drawing.Point(92, 379);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(54, 55);
            this.Number2.TabIndex = 16;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Number2_Click);
            // 
            // Number1
            // 
            this.Number1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number1.Location = new System.Drawing.Point(12, 379);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(54, 55);
            this.Number1.TabIndex = 15;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalButton.Location = new System.Drawing.Point(269, 464);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(54, 55);
            this.DecimalButton.TabIndex = 20;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // Number0
            // 
            this.Number0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number0.Location = new System.Drawing.Point(12, 464);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(54, 55);
            this.Number0.TabIndex = 21;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.Number0_Click);
            // 
            // transparentTextBox1
            // 
            this.transparentTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.transparentTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transparentTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transparentTextBox1.Enabled = false;
            this.transparentTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transparentTextBox1.Location = new System.Drawing.Point(71, 130);
            this.transparentTextBox1.Multiline = true;
            this.transparentTextBox1.Name = "transparentTextBox1";
            this.transparentTextBox1.Size = new System.Drawing.Size(192, 55);
            this.transparentTextBox1.TabIndex = 22;
            this.transparentTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CloseBracket
            // 
            this.CloseBracket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBracket.Location = new System.Drawing.Point(172, 464);
            this.CloseBracket.Name = "CloseBracket";
            this.CloseBracket.Size = new System.Drawing.Size(54, 55);
            this.CloseBracket.TabIndex = 23;
            this.CloseBracket.Text = ")";
            this.CloseBracket.UseVisualStyleBackColor = true;
            this.CloseBracket.Click += new System.EventHandler(this.CloseBracket_Click);
            // 
            // OpenBracket
            // 
            this.OpenBracket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenBracket.Location = new System.Drawing.Point(92, 464);
            this.OpenBracket.Name = "OpenBracket";
            this.OpenBracket.Size = new System.Drawing.Size(54, 55);
            this.OpenBracket.TabIndex = 24;
            this.OpenBracket.Text = "(";
            this.OpenBracket.UseVisualStyleBackColor = true;
            this.OpenBracket.Click += new System.EventHandler(this.OpenBracket_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(12, 130);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(54, 55);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculatorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 532);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OpenBracket);
            this.Controls.Add(this.CloseBracket);
            this.Controls.Add(this.transparentTextBox1);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.DecimalButton);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.HeightButton);
            this.Controls.Add(this.CurrentInputTextBox);
            this.Controls.Add(this.WholeExpressionTextBox);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CalculatorMainWindow";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorMainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WholeExpressionTextBox;
        private System.Windows.Forms.TextBox CurrentInputTextBox;
        private UnselectableButton HeightButton;
        private UnselectableButton SqrtButton;
        private UnselectableButton AddButton;
        private UnselectableButton MultiplyButton;
        private UnselectableButton SubtractButton;
        private UnselectableButton DivideButton;
        private UnselectableButton EqualsButton;
        private UnselectableButton Number7;
        private UnselectableButton Number8;
        private UnselectableButton Number9;
        private UnselectableButton Number6;
        private UnselectableButton Number5;
        private UnselectableButton Number4;
        private UnselectableButton Number3;
        private UnselectableButton Number2;
        private UnselectableButton Number1;
        private UnselectableButton DecimalButton;
        private UnselectableButton Number0;
        private System.Windows.Forms.TextBox transparentTextBox1;
        private UnselectableButton CloseBracket;
        private UnselectableButton OpenBracket;
        private UnselectableButton ClearButton;
    }
}

