namespace CyphersWin
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxTextNew = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPlayfair = new System.Windows.Forms.RadioButton();
            this.radioButtonCeasar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDechiper = new System.Windows.Forms.RadioButton();
            this.radioButtonChiper = new System.Windows.Forms.RadioButton();
            this.trackBarShift = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.textBoxShift = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShift)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(12, 12);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxText.Size = new System.Drawing.Size(1401, 199);
            this.textBoxText.TabIndex = 0;
            // 
            // textBoxTextNew
            // 
            this.textBoxTextNew.Location = new System.Drawing.Point(12, 345);
            this.textBoxTextNew.Multiline = true;
            this.textBoxTextNew.Name = "textBoxTextNew";
            this.textBoxTextNew.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxTextNew.Size = new System.Drawing.Size(1386, 199);
            this.textBoxTextNew.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPlayfair);
            this.groupBox1.Controls.Add(this.radioButtonCeasar);
            this.groupBox1.Location = new System.Drawing.Point(13, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cypher";
            // 
            // radioButtonPlayfair
            // 
            this.radioButtonPlayfair.AutoSize = true;
            this.radioButtonPlayfair.Location = new System.Drawing.Point(21, 67);
            this.radioButtonPlayfair.Name = "radioButtonPlayfair";
            this.radioButtonPlayfair.Size = new System.Drawing.Size(59, 17);
            this.radioButtonPlayfair.TabIndex = 1;
            this.radioButtonPlayfair.Text = "Playfair";
            this.radioButtonPlayfair.UseVisualStyleBackColor = true;
            this.radioButtonPlayfair.CheckedChanged += new System.EventHandler(this.radioButtonPlayfair_CheckedChanged);
            // 
            // radioButtonCeasar
            // 
            this.radioButtonCeasar.AutoSize = true;
            this.radioButtonCeasar.Checked = true;
            this.radioButtonCeasar.Location = new System.Drawing.Point(21, 33);
            this.radioButtonCeasar.Name = "radioButtonCeasar";
            this.radioButtonCeasar.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCeasar.TabIndex = 0;
            this.radioButtonCeasar.TabStop = true;
            this.radioButtonCeasar.Text = "Ceasar";
            this.radioButtonCeasar.UseVisualStyleBackColor = true;
            this.radioButtonCeasar.CheckedChanged += new System.EventHandler(this.radioButtonCeasar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDechiper);
            this.groupBox2.Controls.Add(this.radioButtonChiper);
            this.groupBox2.Location = new System.Drawing.Point(150, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // radioButtonDechiper
            // 
            this.radioButtonDechiper.AutoSize = true;
            this.radioButtonDechiper.Location = new System.Drawing.Point(21, 67);
            this.radioButtonDechiper.Name = "radioButtonDechiper";
            this.radioButtonDechiper.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDechiper.TabIndex = 1;
            this.radioButtonDechiper.Text = "Dechiper";
            this.radioButtonDechiper.UseVisualStyleBackColor = true;
            // 
            // radioButtonChiper
            // 
            this.radioButtonChiper.AutoSize = true;
            this.radioButtonChiper.Checked = true;
            this.radioButtonChiper.Location = new System.Drawing.Point(21, 33);
            this.radioButtonChiper.Name = "radioButtonChiper";
            this.radioButtonChiper.Size = new System.Drawing.Size(55, 17);
            this.radioButtonChiper.TabIndex = 0;
            this.radioButtonChiper.TabStop = true;
            this.radioButtonChiper.Text = "Chiper";
            this.radioButtonChiper.UseVisualStyleBackColor = true;
            // 
            // trackBarShift
            // 
            this.trackBarShift.Location = new System.Drawing.Point(408, 236);
            this.trackBarShift.Maximum = 33;
            this.trackBarShift.Minimum = 1;
            this.trackBarShift.Name = "trackBarShift";
            this.trackBarShift.Size = new System.Drawing.Size(250, 45);
            this.trackBarShift.TabIndex = 4;
            this.trackBarShift.Value = 1;
            this.trackBarShift.Scroll += new System.EventHandler(this.trackBarShift_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Poslinkis: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Raktas:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Enabled = false;
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxKey.Location = new System.Drawing.Point(364, 298);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(141, 31);
            this.textBoxKey.TabIndex = 7;
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(521, 298);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(137, 33);
            this.buttonAction.TabIndex = 8;
            this.buttonAction.Text = "Cipher";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // textBoxShift
            // 
            this.textBoxShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxShift.Location = new System.Drawing.Point(364, 236);
            this.textBoxShift.Name = "textBoxShift";
            this.textBoxShift.Size = new System.Drawing.Size(38, 31);
            this.textBoxShift.TabIndex = 9;
            this.textBoxShift.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 556);
            this.Controls.Add(this.textBoxShift);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarShift);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxTextNew);
            this.Controls.Add(this.textBoxText);
            this.MaximumSize = new System.Drawing.Size(6860, 5950);
            this.MinimumSize = new System.Drawing.Size(686, 595);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Playfair + Ceasar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxTextNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPlayfair;
        private System.Windows.Forms.RadioButton radioButtonCeasar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDechiper;
        private System.Windows.Forms.RadioButton radioButtonChiper;
        private System.Windows.Forms.TrackBar trackBarShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.TextBox textBoxShift;
    }
}

