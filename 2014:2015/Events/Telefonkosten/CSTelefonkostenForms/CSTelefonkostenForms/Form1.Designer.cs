namespace CSTelefonkostenForms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.AbhebenButton = new System.Windows.Forms.Button();
            this.AuflegenButton = new System.Windows.Forms.Button();
            this.KostenLabel = new System.Windows.Forms.Label();
            this.IntervallBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PreisBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AbhebenButton
            // 
            this.AbhebenButton.Location = new System.Drawing.Point(12, 171);
            this.AbhebenButton.Name = "AbhebenButton";
            this.AbhebenButton.Size = new System.Drawing.Size(75, 23);
            this.AbhebenButton.TabIndex = 0;
            this.AbhebenButton.Text = "Abheben";
            this.AbhebenButton.UseVisualStyleBackColor = true;
            this.AbhebenButton.Click += new System.EventHandler(this.AbhebenButton_Click);
            // 
            // AuflegenButton
            // 
            this.AuflegenButton.Location = new System.Drawing.Point(113, 171);
            this.AuflegenButton.Name = "AuflegenButton";
            this.AuflegenButton.Size = new System.Drawing.Size(75, 23);
            this.AuflegenButton.TabIndex = 1;
            this.AuflegenButton.Text = "Auflegen";
            this.AuflegenButton.UseVisualStyleBackColor = true;
            this.AuflegenButton.Click += new System.EventHandler(this.AuflegenButton_Click);
            // 
            // KostenLabel
            // 
            this.KostenLabel.AutoSize = true;
            this.KostenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KostenLabel.Location = new System.Drawing.Point(35, 28);
            this.KostenLabel.Name = "KostenLabel";
            this.KostenLabel.Size = new System.Drawing.Size(126, 46);
            this.KostenLabel.TabIndex = 2;
            this.KostenLabel.Text = "label1";
            // 
            // IntervallBox
            // 
            this.IntervallBox.Location = new System.Drawing.Point(43, 96);
            this.IntervallBox.Name = "IntervallBox";
            this.IntervallBox.Size = new System.Drawing.Size(100, 20);
            this.IntervallBox.TabIndex = 3;
            this.IntervallBox.Tag = "Intervall";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Intervall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "cent/Intervall";
            // 
            // PreisBox
            // 
            this.PreisBox.Location = new System.Drawing.Point(43, 135);
            this.PreisBox.Name = "PreisBox";
            this.PreisBox.Size = new System.Drawing.Size(100, 20);
            this.PreisBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 204);
            this.Controls.Add(this.PreisBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntervallBox);
            this.Controls.Add(this.KostenLabel);
            this.Controls.Add(this.AuflegenButton);
            this.Controls.Add(this.AbhebenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AbhebenButton;
        private System.Windows.Forms.Button AuflegenButton;
        private System.Windows.Forms.Label KostenLabel;
        private System.Windows.Forms.TextBox IntervallBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreisBox;
    }
}

