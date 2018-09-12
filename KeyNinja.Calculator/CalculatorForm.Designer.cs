namespace KeyNinja.Calculator
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
            this.tblOperationsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSignChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearE = new System.Windows.Forms.Button();
            this.btnPorcentage = new System.Windows.Forms.Button();
            this.txtResultValue = new System.Windows.Forms.TextBox();
            this.tblOperationsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblOperationsContainer
            // 
            this.tblOperationsContainer.ColumnCount = 4;
            this.tblOperationsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOperationsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOperationsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOperationsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOperationsContainer.Controls.Add(this.btnEqual, 3, 4);
            this.tblOperationsContainer.Controls.Add(this.btnPoint, 2, 4);
            this.tblOperationsContainer.Controls.Add(this.btn0, 1, 4);
            this.tblOperationsContainer.Controls.Add(this.btnSignChange, 0, 4);
            this.tblOperationsContainer.Controls.Add(this.btnAdd, 3, 3);
            this.tblOperationsContainer.Controls.Add(this.btn3, 2, 3);
            this.tblOperationsContainer.Controls.Add(this.btn2, 1, 3);
            this.tblOperationsContainer.Controls.Add(this.btn1, 0, 3);
            this.tblOperationsContainer.Controls.Add(this.btnSubstract, 3, 2);
            this.tblOperationsContainer.Controls.Add(this.btn6, 2, 2);
            this.tblOperationsContainer.Controls.Add(this.btn5, 1, 2);
            this.tblOperationsContainer.Controls.Add(this.btn4, 0, 2);
            this.tblOperationsContainer.Controls.Add(this.btnMultiplication, 3, 1);
            this.tblOperationsContainer.Controls.Add(this.btn9, 2, 1);
            this.tblOperationsContainer.Controls.Add(this.btn8, 1, 1);
            this.tblOperationsContainer.Controls.Add(this.btn7, 0, 1);
            this.tblOperationsContainer.Controls.Add(this.btnDivision, 3, 0);
            this.tblOperationsContainer.Controls.Add(this.btnClear, 2, 0);
            this.tblOperationsContainer.Controls.Add(this.btnClearE, 1, 0);
            this.tblOperationsContainer.Controls.Add(this.btnPorcentage, 0, 0);
            this.tblOperationsContainer.Location = new System.Drawing.Point(12, 79);
            this.tblOperationsContainer.Name = "tblOperationsContainer";
            this.tblOperationsContainer.RowCount = 5;
            this.tblOperationsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOperationsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOperationsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOperationsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOperationsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOperationsContainer.Size = new System.Drawing.Size(500, 260);
            this.tblOperationsContainer.TabIndex = 0;
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(378, 211);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(119, 46);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Tag = "Equal";
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(253, 211);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(119, 46);
            this.btnPoint.TabIndex = 18;
            this.btnPoint.Tag = "Point";
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(128, 211);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(119, 46);
            this.btn0.TabIndex = 17;
            this.btn0.Tag = "NumberType";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnSignChange
            // 
            this.btnSignChange.Enabled = false;
            this.btnSignChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignChange.Location = new System.Drawing.Point(3, 211);
            this.btnSignChange.Name = "btnSignChange";
            this.btnSignChange.Size = new System.Drawing.Size(119, 46);
            this.btnSignChange.TabIndex = 16;
            this.btnSignChange.Text = "+/-";
            this.btnSignChange.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(378, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 46);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Tag = "BasicOperationType";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(253, 159);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(119, 46);
            this.btn3.TabIndex = 14;
            this.btn3.Tag = "NumberType";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(128, 159);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(119, 46);
            this.btn2.TabIndex = 13;
            this.btn2.Tag = "NumberType";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 159);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(119, 46);
            this.btn1.TabIndex = 12;
            this.btn1.Tag = "NumberType";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnSubstract
            // 
            this.btnSubstract.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstract.Location = new System.Drawing.Point(378, 107);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(119, 46);
            this.btnSubstract.TabIndex = 11;
            this.btnSubstract.Tag = "BasicOperationType";
            this.btnSubstract.Text = "-";
            this.btnSubstract.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(253, 107);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(119, 46);
            this.btn6.TabIndex = 10;
            this.btn6.Tag = "NumberType";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(128, 107);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(119, 46);
            this.btn5.TabIndex = 9;
            this.btn5.Tag = "NumberType";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 107);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(119, 46);
            this.btn4.TabIndex = 8;
            this.btn4.Tag = "NumberType";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.Location = new System.Drawing.Point(378, 55);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(119, 46);
            this.btnMultiplication.TabIndex = 7;
            this.btnMultiplication.Tag = "BasicOperationType";
            this.btnMultiplication.Text = "X";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(253, 55);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(119, 46);
            this.btn9.TabIndex = 6;
            this.btn9.Tag = "NumberType";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(128, 55);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(119, 46);
            this.btn8.TabIndex = 5;
            this.btn8.Tag = "NumberType";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 55);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(119, 46);
            this.btn7.TabIndex = 4;
            this.btn7.Tag = "NumberType";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(378, 3);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(119, 46);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Tag = "BasicOperationType";
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(253, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Tag = "Clear";
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClearE
            // 
            this.btnClearE.Enabled = false;
            this.btnClearE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearE.Location = new System.Drawing.Point(128, 3);
            this.btnClearE.Name = "btnClearE";
            this.btnClearE.Size = new System.Drawing.Size(119, 46);
            this.btnClearE.TabIndex = 1;
            this.btnClearE.Tag = "Clear";
            this.btnClearE.Text = "CE";
            this.btnClearE.UseVisualStyleBackColor = true;
            // 
            // btnPorcentage
            // 
            this.btnPorcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentage.Location = new System.Drawing.Point(3, 3);
            this.btnPorcentage.Name = "btnPorcentage";
            this.btnPorcentage.Size = new System.Drawing.Size(119, 46);
            this.btnPorcentage.TabIndex = 0;
            this.btnPorcentage.Tag = "Porcentage";
            this.btnPorcentage.Text = "%";
            this.btnPorcentage.UseVisualStyleBackColor = true;
            // 
            // txtResultValue
            // 
            this.txtResultValue.Enabled = false;
            this.txtResultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultValue.Location = new System.Drawing.Point(15, 37);
            this.txtResultValue.Name = "txtResultValue";
            this.txtResultValue.Size = new System.Drawing.Size(494, 26);
            this.txtResultValue.TabIndex = 1;
            this.txtResultValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 348);
            this.Controls.Add(this.txtResultValue);
            this.Controls.Add(this.tblOperationsContainer);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.tblOperationsContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblOperationsContainer;
        private System.Windows.Forms.Button btnPorcentage;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSignChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearE;
        private System.Windows.Forms.TextBox txtResultValue;
    }
}

