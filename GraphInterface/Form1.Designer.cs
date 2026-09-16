
namespace GraphInterface
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonMR = new System.Windows.Forms.Button();
            this.buttonMPlus = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonMod = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonABS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBS = new System.Windows.Forms.Button();
            this.buttonCloseBracket = new System.Windows.Forms.Button();
            this.buttonOpenBracket = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExpression.Location = new System.Drawing.Point(110, 17);
            this.textBoxExpression.Multiline = true;
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExpression.Size = new System.Drawing.Size(273, 68);
            this.textBoxExpression.TabIndex = 2;
            this.textBoxExpression.TextChanged += new System.EventHandler(this.textBoxExpression_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.textBoxResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxExpression);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 563);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.buttonEqual, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonMR, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonMPlus, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonMC, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(321, 298);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(62, 217);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqual.ForeColor = System.Drawing.Color.Red;
            this.buttonEqual.Location = new System.Drawing.Point(3, 165);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(56, 49);
            this.buttonEqual.TabIndex = 9;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonMR
            // 
            this.buttonMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMR.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonMR.Location = new System.Drawing.Point(3, 3);
            this.buttonMR.Name = "buttonMR";
            this.buttonMR.Size = new System.Drawing.Size(56, 48);
            this.buttonMR.TabIndex = 5;
            this.buttonMR.Text = "MR";
            this.buttonMR.UseVisualStyleBackColor = true;
            this.buttonMR.Click += new System.EventHandler(this.buttonMR_Click);
            // 
            // buttonMPlus
            // 
            this.buttonMPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMPlus.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonMPlus.Location = new System.Drawing.Point(3, 57);
            this.buttonMPlus.Name = "buttonMPlus";
            this.buttonMPlus.Size = new System.Drawing.Size(56, 48);
            this.buttonMPlus.TabIndex = 7;
            this.buttonMPlus.Text = "M+";
            this.buttonMPlus.UseVisualStyleBackColor = true;
            this.buttonMPlus.Click += new System.EventHandler(this.buttonMPlus_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMC.ForeColor = System.Drawing.Color.MediumBlue;
            this.buttonMC.Location = new System.Drawing.Point(3, 111);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(56, 48);
            this.buttonMC.TabIndex = 8;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonMod, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonABS, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDiv, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMult, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSub, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 220);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonMod
            // 
            this.buttonMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMod.ForeColor = System.Drawing.Color.Red;
            this.buttonMod.Location = new System.Drawing.Point(125, 168);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(55, 49);
            this.buttonMod.TabIndex = 17;
            this.buttonMod.Text = "mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Location = new System.Drawing.Point(3, 168);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(55, 49);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonABS
            // 
            this.buttonABS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonABS.ForeColor = System.Drawing.Color.Black;
            this.buttonABS.Location = new System.Drawing.Point(64, 168);
            this.buttonABS.Name = "buttonABS";
            this.buttonABS.Size = new System.Drawing.Size(55, 49);
            this.buttonABS.TabIndex = 12;
            this.buttonABS.Text = "+/-";
            this.buttonABS.UseVisualStyleBackColor = true;
            this.buttonABS.Click += new System.EventHandler(this.buttonABS_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(64, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(125, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(64, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(125, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(3, 113);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 49);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(64, 113);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 49);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(125, 113);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 49);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDiv.ForeColor = System.Drawing.Color.Red;
            this.buttonDiv.Location = new System.Drawing.Point(186, 3);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(55, 49);
            this.buttonDiv.TabIndex = 11;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMult.ForeColor = System.Drawing.Color.Red;
            this.buttonMult.Location = new System.Drawing.Point(186, 58);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(55, 49);
            this.buttonMult.TabIndex = 13;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSub.ForeColor = System.Drawing.Color.Red;
            this.buttonSub.Location = new System.Drawing.Point(186, 113);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(55, 49);
            this.buttonSub.TabIndex = 18;
            this.buttonSub.Text = "-";
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.ForeColor = System.Drawing.Color.Red;
            this.buttonAdd.Location = new System.Drawing.Point(186, 168);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(55, 49);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonC);
            this.groupBox1.Controls.Add(this.buttonBS);
            this.groupBox1.Controls.Add(this.buttonCloseBracket);
            this.groupBox1.Controls.Add(this.buttonOpenBracket);
            this.groupBox1.Location = new System.Drawing.Point(21, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing";
            // 
            // buttonC
            // 
            this.buttonC.ForeColor = System.Drawing.Color.Red;
            this.buttonC.Location = new System.Drawing.Point(271, 25);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 36);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonBS
            // 
            this.buttonBS.ForeColor = System.Drawing.Color.Red;
            this.buttonBS.Location = new System.Drawing.Point(128, 25);
            this.buttonBS.Name = "buttonBS";
            this.buttonBS.Size = new System.Drawing.Size(137, 36);
            this.buttonBS.TabIndex = 2;
            this.buttonBS.Text = "Backspace";
            this.buttonBS.UseVisualStyleBackColor = true;
            this.buttonBS.Click += new System.EventHandler(this.buttonBS_Click);
            // 
            // buttonCloseBracket
            // 
            this.buttonCloseBracket.Location = new System.Drawing.Point(63, 25);
            this.buttonCloseBracket.Name = "buttonCloseBracket";
            this.buttonCloseBracket.Size = new System.Drawing.Size(42, 36);
            this.buttonCloseBracket.TabIndex = 1;
            this.buttonCloseBracket.Text = ")";
            this.buttonCloseBracket.UseVisualStyleBackColor = true;
            this.buttonCloseBracket.Click += new System.EventHandler(this.buttonCloseBracket_Click);
            // 
            // buttonOpenBracket
            // 
            this.buttonOpenBracket.Location = new System.Drawing.Point(15, 25);
            this.buttonOpenBracket.Name = "buttonOpenBracket";
            this.buttonOpenBracket.Size = new System.Drawing.Size(42, 36);
            this.buttonOpenBracket.TabIndex = 0;
            this.buttonOpenBracket.Text = "(";
            this.buttonOpenBracket.UseVisualStyleBackColor = true;
            this.buttonOpenBracket.Click += new System.EventHandler(this.buttonOpenBracket_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxResult.Location = new System.Drawing.Point(110, 108);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(273, 77);
            this.textBoxResult.TabIndex = 3;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 587);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBS;
        private System.Windows.Forms.Button buttonCloseBracket;
        private System.Windows.Forms.Button buttonOpenBracket;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonABS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonMR;
        private System.Windows.Forms.Button buttonMPlus;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Timer timer1;
    }
}

