using System.Drawing;

namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAdunare = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonImpartire = new System.Windows.Forms.Button();
            this.buttonInmultire = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonScadere = new System.Windows.Forms.Button();
            this.buttonEgal = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 12);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(223, 22);
            this.result.TabIndex = 1;
            this.result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(69, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(126, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // buttonAdunare
            // 
            this.buttonAdunare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdunare.Location = new System.Drawing.Point(183, 187);
            this.buttonAdunare.Name = "buttonAdunare";
            this.buttonAdunare.Size = new System.Drawing.Size(51, 45);
            this.buttonAdunare.TabIndex = 2;
            this.buttonAdunare.Text = "+";
            this.buttonAdunare.UseVisualStyleBackColor = true;
            this.buttonAdunare.Click += new System.EventHandler(this.ButtonAdunare_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 45);
            this.button4.TabIndex = 2;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(69, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 45);
            this.button5.TabIndex = 2;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(126, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 45);
            this.button6.TabIndex = 2;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // buttonImpartire
            // 
            this.buttonImpartire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImpartire.Location = new System.Drawing.Point(183, 136);
            this.buttonImpartire.Name = "buttonImpartire";
            this.buttonImpartire.Size = new System.Drawing.Size(51, 45);
            this.buttonImpartire.TabIndex = 2;
            this.buttonImpartire.Text = "/";
            this.buttonImpartire.UseVisualStyleBackColor = true;
            this.buttonImpartire.Click += new System.EventHandler(this.ButtonImpartire_Click);
            // 
            // buttonInmultire
            // 
            this.buttonInmultire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInmultire.Location = new System.Drawing.Point(184, 85);
            this.buttonInmultire.Name = "buttonInmultire";
            this.buttonInmultire.Size = new System.Drawing.Size(51, 45);
            this.buttonInmultire.TabIndex = 2;
            this.buttonInmultire.Text = "x";
            this.buttonInmultire.UseVisualStyleBackColor = true;
            this.buttonInmultire.Click += new System.EventHandler(this.ButtonInmultire_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(127, 85);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 45);
            this.button9.TabIndex = 2;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(70, 85);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 45);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(13, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 45);
            this.button7.TabIndex = 2;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(69, 238);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(51, 45);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // buttonScadere
            // 
            this.buttonScadere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScadere.Location = new System.Drawing.Point(184, 238);
            this.buttonScadere.Name = "buttonScadere";
            this.buttonScadere.Size = new System.Drawing.Size(51, 45);
            this.buttonScadere.TabIndex = 2;
            this.buttonScadere.Text = "-";
            this.buttonScadere.UseVisualStyleBackColor = true;
            this.buttonScadere.Click += new System.EventHandler(this.ButtonScadere_Click);
            // 
            // buttonEgal
            // 
            this.buttonEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEgal.Location = new System.Drawing.Point(127, 238);
            this.buttonEgal.Name = "buttonEgal";
            this.buttonEgal.Size = new System.Drawing.Size(51, 45);
            this.buttonEgal.TabIndex = 2;
            this.buttonEgal.Text = "=";
            this.buttonEgal.UseVisualStyleBackColor = true;
            this.buttonEgal.Click += new System.EventHandler(this.ButtonEgal_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErase.Location = new System.Drawing.Point(13, 238);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(51, 45);
            this.buttonErase.TabIndex = 2;
            this.buttonErase.Text = "C";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.ButtonScadere_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 302);
            this.Controls.Add(this.buttonAdunare);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonEgal);
            this.Controls.Add(this.buttonScadere);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonInmultire);
            this.Controls.Add(this.buttonImpartire);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(265, 350);
            this.MinimumSize = new System.Drawing.Size(265, 350);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAdunare;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonImpartire;
        private System.Windows.Forms.Button buttonInmultire;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonScadere;
        private System.Windows.Forms.Button buttonEgal;
        private System.Windows.Forms.Button buttonErase;
    }
}

