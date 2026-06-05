namespace Conversion
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Mode = new ComboBox();
            comboBox1 = new ComboBox();
            txt_value = new TextBox();
            Convertion = new Button();
            lbl_result = new Label();
            lbl_txt_convertion = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // Mode
            // 
            Mode.FormattingEnabled = true;
            Mode.Items.AddRange(new object[] { "Température", "Monnaie", "Vitesse", "Masse" });
            Mode.Location = new Point(387, 90);
            Mode.Name = "Mode";
            Mode.Size = new Size(182, 33);
            Mode.TabIndex = 22;
            Mode.SelectedIndexChanged += Mode_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(387, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 23;
            // 
            // txt_value
            // 
            txt_value.Location = new Point(387, 336);
            txt_value.Name = "txt_value";
            txt_value.Size = new Size(245, 31);
            txt_value.TabIndex = 25;
            // 
            // Convertion
            // 
            Convertion.Location = new Point(387, 401);
            Convertion.Name = "Convertion";
            Convertion.Size = new Size(112, 34);
            Convertion.TabIndex = 26;
            Convertion.Text = "Convertir";
            Convertion.UseVisualStyleBackColor = true;
            Convertion.Click += Convertion_Click;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Location = new Point(387, 469);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(88, 25);
            lbl_result.TabIndex = 27;
            lbl_result.Text = "Résultat : ";
            // 
            // lbl_txt_convertion
            // 
            lbl_txt_convertion.AutoSize = true;
            lbl_txt_convertion.Location = new Point(387, 51);
            lbl_txt_convertion.Name = "lbl_txt_convertion";
            lbl_txt_convertion.Size = new Size(165, 25);
            lbl_txt_convertion.TabIndex = 28;
            lbl_txt_convertion.Text = "Type de conversion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 147);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 29;
            label2.Text = "De";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(387, 230);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 30;
            label3.Text = "Vers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 308);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 31;
            label4.Text = "Valeur";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(387, 258);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 586);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_txt_convertion);
            Controls.Add(lbl_result);
            Controls.Add(Convertion);
            Controls.Add(txt_value);
            Controls.Add(comboBox1);
            Controls.Add(Mode);
            Name = "Form1";
            Text = "Conversion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox Mode;
        private ComboBox comboBox1;
        private TextBox txt_value;
        private Button Convertion;
        private Label lbl_result;
        private Label lbl_txt_convertion;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
    }
}
