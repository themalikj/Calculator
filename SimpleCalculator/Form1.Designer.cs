namespace SimpleCalculator
{
    partial class frmCalculator
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSqrRoot = new System.Windows.Forms.Button();
            this.btnByTwo = new System.Windows.Forms.Button();
            this.btnByFour = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(20, 20);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(288, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(18, 60);
            this.btnOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(51, 35);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(78, 60);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(51, 35);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(78, 194);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(51, 35);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(135, 194);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(51, 35);
            this.btnEqual.TabIndex = 12;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(198, 60);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(51, 35);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSqrRoot
            // 
            this.btnSqrRoot.Location = new System.Drawing.Point(258, 105);
            this.btnSqrRoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSqrRoot.Name = "btnSqrRoot";
            this.btnSqrRoot.Size = new System.Drawing.Size(51, 35);
            this.btnSqrRoot.TabIndex = 18;
            this.btnSqrRoot.Text = "√";
            this.btnSqrRoot.UseVisualStyleBackColor = true;
            this.btnSqrRoot.Click += new System.EventHandler(this.btnSqrRoot_Click);
            // 
            // btnByTwo
            // 
            this.btnByTwo.Location = new System.Drawing.Point(258, 150);
            this.btnByTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnByTwo.Name = "btnByTwo";
            this.btnByTwo.Size = new System.Drawing.Size(51, 35);
            this.btnByTwo.TabIndex = 19;
            this.btnByTwo.Text = "½";
            this.btnByTwo.UseVisualStyleBackColor = true;
            this.btnByTwo.Click += new System.EventHandler(this.btnByTwo_Click);
            // 
            // btnByFour
            // 
            this.btnByFour.Location = new System.Drawing.Point(258, 194);
            this.btnByFour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnByFour.Name = "btnByFour";
            this.btnByFour.Size = new System.Drawing.Size(51, 35);
            this.btnByFour.TabIndex = 20;
            this.btnByFour.Text = "¼";
            this.btnByFour.UseVisualStyleBackColor = true;
            this.btnByFour.Click += new System.EventHandler(this.btnByFour_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(135, 104);
            this.btnSix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(51, 35);
            this.btnSix.TabIndex = 21;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(135, 60);
            this.btnThree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(51, 35);
            this.btnThree.TabIndex = 22;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(78, 104);
            this.btnFive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(51, 35);
            this.btnFive.TabIndex = 23;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(18, 104);
            this.btnFour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(51, 35);
            this.btnFour.TabIndex = 24;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(20, 193);
            this.btnZero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(51, 35);
            this.btnZero.TabIndex = 25;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(135, 149);
            this.btnNine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(51, 35);
            this.btnNine.TabIndex = 26;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(78, 149);
            this.btnEight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(51, 35);
            this.btnEight.TabIndex = 27;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(258, 60);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(51, 35);
            this.btnMinus.TabIndex = 29;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(198, 105);
            this.btnMult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(51, 35);
            this.btnMult.TabIndex = 30;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(18, 150);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(51, 35);
            this.btnSeven.TabIndex = 31;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(199, 150);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(51, 35);
            this.btnDiv.TabIndex = 32;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 193);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(51, 35);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 242);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnByFour);
            this.Controls.Add(this.btnByTwo);
            this.Controls.Add(this.btnSqrRoot);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSqrRoot;
        private System.Windows.Forms.Button btnByTwo;
        private System.Windows.Forms.Button btnByFour;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
    }
}

