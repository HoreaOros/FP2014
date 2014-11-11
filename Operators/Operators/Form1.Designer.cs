namespace Operators
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
            this.lblOpStg = new System.Windows.Forms.Label();
            this.lblOpDr = new System.Windows.Forms.Label();
            this.txtOpStg = new System.Windows.Forms.TextBox();
            this.txtOpDr = new System.Windows.Forms.TextBox();
            this.grpOperators = new System.Windows.Forms.GroupBox();
            this.rbtPlus = new System.Windows.Forms.RadioButton();
            this.rbtMinus = new System.Windows.Forms.RadioButton();
            this.rbtInmultire = new System.Windows.Forms.RadioButton();
            this.rbtImpartire = new System.Windows.Forms.RadioButton();
            this.rbtRest = new System.Windows.Forms.RadioButton();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.lblExpresie = new System.Windows.Forms.Label();
            this.txtExpresie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOpStg
            // 
            this.lblOpStg.AutoSize = true;
            this.lblOpStg.Location = new System.Drawing.Point(54, 40);
            this.lblOpStg.Name = "lblOpStg";
            this.lblOpStg.Size = new System.Drawing.Size(77, 13);
            this.lblOpStg.TabIndex = 0;
            this.lblOpStg.Text = "Operand stang";
            // 
            // lblOpDr
            // 
            this.lblOpDr.AutoSize = true;
            this.lblOpDr.Location = new System.Drawing.Point(345, 40);
            this.lblOpDr.Name = "lblOpDr";
            this.lblOpDr.Size = new System.Drawing.Size(87, 13);
            this.lblOpDr.TabIndex = 1;
            this.lblOpDr.Text = "Operand dreapta";
            // 
            // txtOpStg
            // 
            this.txtOpStg.Location = new System.Drawing.Point(57, 77);
            this.txtOpStg.Name = "txtOpStg";
            this.txtOpStg.Size = new System.Drawing.Size(100, 20);
            this.txtOpStg.TabIndex = 2;
            // 
            // txtOpDr
            // 
            this.txtOpDr.Location = new System.Drawing.Point(348, 77);
            this.txtOpDr.Name = "txtOpDr";
            this.txtOpDr.Size = new System.Drawing.Size(100, 20);
            this.txtOpDr.TabIndex = 3;
            // 
            // grpOperators
            // 
            this.grpOperators.Controls.Add(this.rbtRest);
            this.grpOperators.Controls.Add(this.rbtImpartire);
            this.grpOperators.Controls.Add(this.rbtInmultire);
            this.grpOperators.Controls.Add(this.rbtMinus);
            this.grpOperators.Controls.Add(this.rbtPlus);
            this.grpOperators.Location = new System.Drawing.Point(184, 77);
            this.grpOperators.Name = "grpOperators";
            this.grpOperators.Size = new System.Drawing.Size(126, 184);
            this.grpOperators.TabIndex = 4;
            this.grpOperators.TabStop = false;
            this.grpOperators.Text = "Operator";
            // 
            // rbtPlus
            // 
            this.rbtPlus.AutoSize = true;
            this.rbtPlus.Checked = true;
            this.rbtPlus.Location = new System.Drawing.Point(17, 29);
            this.rbtPlus.Name = "rbtPlus";
            this.rbtPlus.Size = new System.Drawing.Size(54, 17);
            this.rbtPlus.TabIndex = 0;
            this.rbtPlus.TabStop = true;
            this.rbtPlus.Text = "+ Plus";
            this.rbtPlus.UseVisualStyleBackColor = true;
            // 
            // rbtMinus
            // 
            this.rbtMinus.AutoSize = true;
            this.rbtMinus.Location = new System.Drawing.Point(17, 60);
            this.rbtMinus.Name = "rbtMinus";
            this.rbtMinus.Size = new System.Drawing.Size(59, 17);
            this.rbtMinus.TabIndex = 1;
            this.rbtMinus.Text = "- Minus";
            this.rbtMinus.UseVisualStyleBackColor = true;
            // 
            // rbtInmultire
            // 
            this.rbtInmultire.AutoSize = true;
            this.rbtInmultire.Location = new System.Drawing.Point(17, 91);
            this.rbtInmultire.Name = "rbtInmultire";
            this.rbtInmultire.Size = new System.Drawing.Size(71, 17);
            this.rbtInmultire.TabIndex = 2;
            this.rbtInmultire.Text = "* Inmultire";
            this.rbtInmultire.UseVisualStyleBackColor = true;
            // 
            // rbtImpartire
            // 
            this.rbtImpartire.AutoSize = true;
            this.rbtImpartire.Location = new System.Drawing.Point(17, 122);
            this.rbtImpartire.Name = "rbtImpartire";
            this.rbtImpartire.Size = new System.Drawing.Size(73, 17);
            this.rbtImpartire.TabIndex = 3;
            this.rbtImpartire.Text = "/ Impartire";
            this.rbtImpartire.UseVisualStyleBackColor = true;
            // 
            // rbtRest
            // 
            this.rbtRest.AutoSize = true;
            this.rbtRest.Location = new System.Drawing.Point(17, 153);
            this.rbtRest.Name = "rbtRest";
            this.rbtRest.Size = new System.Drawing.Size(58, 17);
            this.rbtRest.TabIndex = 4;
            this.rbtRest.Text = "% Rest";
            this.rbtRest.UseVisualStyleBackColor = true;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(57, 285);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(75, 23);
            this.btnCalcul.TabIndex = 5;
            this.btnCalcul.Text = "Calculare";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // lblExpresie
            // 
            this.lblExpresie.AutoSize = true;
            this.lblExpresie.Location = new System.Drawing.Point(57, 332);
            this.lblExpresie.Name = "lblExpresie";
            this.lblExpresie.Size = new System.Drawing.Size(50, 13);
            this.lblExpresie.TabIndex = 6;
            this.lblExpresie.Text = "Expresia:";
            // 
            // txtExpresie
            // 
            this.txtExpresie.Location = new System.Drawing.Point(144, 329);
            this.txtExpresie.Name = "txtExpresie";
            this.txtExpresie.ReadOnly = true;
            this.txtExpresie.Size = new System.Drawing.Size(166, 20);
            this.txtExpresie.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rezultat:";
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(144, 378);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(166, 20);
            this.txtRezultat.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(373, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 439);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpresie);
            this.Controls.Add(this.lblExpresie);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.grpOperators);
            this.Controls.Add(this.txtOpDr);
            this.Controls.Add(this.txtOpStg);
            this.Controls.Add(this.lblOpDr);
            this.Controls.Add(this.lblOpStg);
            this.Name = "Form1";
            this.Text = "Operatori";
            this.grpOperators.ResumeLayout(false);
            this.grpOperators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpStg;
        private System.Windows.Forms.Label lblOpDr;
        private System.Windows.Forms.TextBox txtOpStg;
        private System.Windows.Forms.TextBox txtOpDr;
        private System.Windows.Forms.GroupBox grpOperators;
        private System.Windows.Forms.RadioButton rbtRest;
        private System.Windows.Forms.RadioButton rbtImpartire;
        private System.Windows.Forms.RadioButton rbtInmultire;
        private System.Windows.Forms.RadioButton rbtMinus;
        private System.Windows.Forms.RadioButton rbtPlus;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Label lblExpresie;
        private System.Windows.Forms.TextBox txtExpresie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Button btnExit;
    }
}

