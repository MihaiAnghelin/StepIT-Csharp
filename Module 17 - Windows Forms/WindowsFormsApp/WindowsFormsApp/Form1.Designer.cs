namespace WindowsFormsApp
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Numar1Label = new System.Windows.Forms.Label();
            this.Numar2Label = new System.Windows.Forms.Label();
            this.Numar1TextBox = new System.Windows.Forms.TextBox();
            this.Numar2TextBox = new System.Windows.Forms.TextBox();
            this.SumaButton = new System.Windows.Forms.Button();
            this.RezultatLabel = new System.Windows.Forms.Label();
            this.RezultatTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DiferentaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(319, 42);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(174, 39);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Calculator";
            // 
            // Numar1Label
            // 
            this.Numar1Label.AutoSize = true;
            this.Numar1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numar1Label.Location = new System.Drawing.Point(98, 135);
            this.Numar1Label.Name = "Numar1Label";
            this.Numar1Label.Size = new System.Drawing.Size(78, 22);
            this.Numar1Label.TabIndex = 1;
            this.Numar1Label.Text = "Numar 1";
            this.Numar1Label.Click += new System.EventHandler(this.Numar1Label_Click);
            // 
            // Numar2Label
            // 
            this.Numar2Label.AutoSize = true;
            this.Numar2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numar2Label.Location = new System.Drawing.Point(101, 189);
            this.Numar2Label.Name = "Numar2Label";
            this.Numar2Label.Size = new System.Drawing.Size(78, 22);
            this.Numar2Label.TabIndex = 2;
            this.Numar2Label.Text = "Numar 2";
            this.Numar2Label.Click += new System.EventHandler(this.Numar2Label_Click);
            // 
            // Numar1TextBox
            // 
            this.Numar1TextBox.Location = new System.Drawing.Point(204, 135);
            this.Numar1TextBox.Name = "Numar1TextBox";
            this.Numar1TextBox.Size = new System.Drawing.Size(138, 22);
            this.Numar1TextBox.TabIndex = 3;
            this.Numar1TextBox.TextChanged += new System.EventHandler(this.Numar1TextBox_TextChanged);
            this.Numar1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numar1_keypress);
            // 
            // Numar2TextBox
            // 
            this.Numar2TextBox.Location = new System.Drawing.Point(204, 189);
            this.Numar2TextBox.Name = "Numar2TextBox";
            this.Numar2TextBox.Size = new System.Drawing.Size(138, 22);
            this.Numar2TextBox.TabIndex = 4;
            this.Numar2TextBox.TextChanged += new System.EventHandler(this.Numar2TextBox_TextChanged);
            this.Numar2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numar2TextBox_KeyPress);
            // 
            // SumaButton
            // 
            this.SumaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SumaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumaButton.Location = new System.Drawing.Point(192, 245);
            this.SumaButton.Name = "SumaButton";
            this.SumaButton.Size = new System.Drawing.Size(170, 35);
            this.SumaButton.TabIndex = 5;
            this.SumaButton.Text = "Calculeaza suma";
            this.SumaButton.UseVisualStyleBackColor = true;
            this.SumaButton.Click += new System.EventHandler(this.SumaButton_Click);
            // 
            // RezultatLabel
            // 
            this.RezultatLabel.AutoSize = true;
            this.RezultatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RezultatLabel.Location = new System.Drawing.Point(101, 347);
            this.RezultatLabel.Name = "RezultatLabel";
            this.RezultatLabel.Size = new System.Drawing.Size(75, 22);
            this.RezultatLabel.TabIndex = 6;
            this.RezultatLabel.Text = "Rezultat";
            this.RezultatLabel.Click += new System.EventHandler(this.RezultatLabel_Click);
            // 
            // RezultatTextBox
            // 
            this.RezultatTextBox.Location = new System.Drawing.Point(204, 347);
            this.RezultatTextBox.Name = "RezultatTextBox";
            this.RezultatTextBox.ReadOnly = true;
            this.RezultatTextBox.Size = new System.Drawing.Size(138, 22);
            this.RezultatTextBox.TabIndex = 7;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(105, 303);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.ErrorLabel.TabIndex = 8;
            // 
            // DiferentaButton
            // 
            this.DiferentaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiferentaButton.Location = new System.Drawing.Point(433, 245);
            this.DiferentaButton.Name = "DiferentaButton";
            this.DiferentaButton.Size = new System.Drawing.Size(214, 35);
            this.DiferentaButton.TabIndex = 9;
            this.DiferentaButton.Text = "Calculeaza diferenta";
            this.DiferentaButton.UseVisualStyleBackColor = true;
            this.DiferentaButton.Click += new System.EventHandler(this.DiferentaButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(108, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(577, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Inca un calculator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IncaUnCalculatorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DiferentaButton);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RezultatTextBox);
            this.Controls.Add(this.RezultatLabel);
            this.Controls.Add(this.SumaButton);
            this.Controls.Add(this.Numar2TextBox);
            this.Controls.Add(this.Numar1TextBox);
            this.Controls.Add(this.Numar2Label);
            this.Controls.Add(this.Numar1Label);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Numar1Label;
        private System.Windows.Forms.Label Numar2Label;
        private System.Windows.Forms.TextBox Numar1TextBox;
        private System.Windows.Forms.TextBox Numar2TextBox;
        private System.Windows.Forms.Button SumaButton;
        private System.Windows.Forms.Label RezultatLabel;
        private System.Windows.Forms.TextBox RezultatTextBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button DiferentaButton;
        private System.Windows.Forms.Button button1;
    }
}

