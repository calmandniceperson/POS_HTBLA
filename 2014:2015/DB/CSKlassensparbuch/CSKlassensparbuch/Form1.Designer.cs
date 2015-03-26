namespace CSKlassensparbuch
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.einzahlenButton = new System.Windows.Forms.Button();
            this.abhebenButton = new System.Windows.Forms.Button();
            this.einzahlenTextBox = new System.Windows.Forms.TextBox();
            this.abhebenTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datenbankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontenErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(301, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // einzahlenButton
            // 
            this.einzahlenButton.Location = new System.Drawing.Point(35, 282);
            this.einzahlenButton.Name = "einzahlenButton";
            this.einzahlenButton.Size = new System.Drawing.Size(75, 23);
            this.einzahlenButton.TabIndex = 1;
            this.einzahlenButton.Text = "Einzahlen";
            this.einzahlenButton.UseVisualStyleBackColor = true;
            this.einzahlenButton.Click += new System.EventHandler(this.einzahlenButton_Click);
            // 
            // abhebenButton
            // 
            this.abhebenButton.Location = new System.Drawing.Point(190, 282);
            this.abhebenButton.Name = "abhebenButton";
            this.abhebenButton.Size = new System.Drawing.Size(75, 23);
            this.abhebenButton.TabIndex = 2;
            this.abhebenButton.Text = "Abheben";
            this.abhebenButton.UseVisualStyleBackColor = true;
            this.abhebenButton.Click += new System.EventHandler(this.abhebenButton_Click);
            // 
            // einzahlenTextBox
            // 
            this.einzahlenTextBox.Location = new System.Drawing.Point(12, 256);
            this.einzahlenTextBox.Name = "einzahlenTextBox";
            this.einzahlenTextBox.Size = new System.Drawing.Size(131, 20);
            this.einzahlenTextBox.TabIndex = 3;
            // 
            // abhebenTextBox
            // 
            this.abhebenTextBox.Location = new System.Drawing.Point(159, 256);
            this.abhebenTextBox.Name = "abhebenTextBox";
            this.abhebenTextBox.Size = new System.Drawing.Size(131, 20);
            this.abhebenTextBox.TabIndex = 4;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(12, 185);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(131, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 211);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(131, 20);
            this.passwordTextBox.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(149, 197);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "z.B. u1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenbankToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datenbankToolStripMenuItem
            // 
            this.datenbankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontenErstellenToolStripMenuItem});
            this.datenbankToolStripMenuItem.Name = "datenbankToolStripMenuItem";
            this.datenbankToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.datenbankToolStripMenuItem.Text = "Datenbank";
            // 
            // kontenErstellenToolStripMenuItem
            // 
            this.kontenErstellenToolStripMenuItem.Name = "kontenErstellenToolStripMenuItem";
            this.kontenErstellenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.kontenErstellenToolStripMenuItem.Text = "Konten erstellen";
            this.kontenErstellenToolStripMenuItem.Click += new System.EventHandler(this.kontenErstellenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 317);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.abhebenTextBox);
            this.Controls.Add(this.einzahlenTextBox);
            this.Controls.Add(this.abhebenButton);
            this.Controls.Add(this.einzahlenButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Klassensparbuch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button einzahlenButton;
        private System.Windows.Forms.Button abhebenButton;
        private System.Windows.Forms.TextBox einzahlenTextBox;
        private System.Windows.Forms.TextBox abhebenTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datenbankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontenErstellenToolStripMenuItem;
    }
}

