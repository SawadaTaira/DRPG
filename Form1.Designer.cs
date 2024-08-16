namespace DRPG
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
            btnAttack = new Button();
            txtResult = new TextBox();
            btnReset = new Button();
            pbHero1 = new ProgressBar();
            pbHero2 = new ProgressBar();
            pbHero3 = new ProgressBar();
            pbEnemy1 = new ProgressBar();
            pbEnemy2 = new ProgressBar();
            pbEnemy3 = new ProgressBar();
            lblHero1 = new Label();
            lblHero2 = new Label();
            lblHero3 = new Label();
            lblEnemy1 = new Label();
            lblEnemy2 = new Label();
            lblEnemy3 = new Label();
            lstHeroes = new ListBox();
            lstEnemies = new ListBox();
            SuspendLayout();
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(513, 89);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(189, 99);
            btnAttack.TabIndex = 0;
            btnAttack.Text = "攻撃";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(437, 212);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(332, 215);
            txtResult.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(681, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "やり直す";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // pbHero1
            // 
            pbHero1.Location = new Point(50, 193);
            pbHero1.Name = "pbHero1";
            pbHero1.Size = new Size(100, 23);
            pbHero1.TabIndex = 6;
            // 
            // pbHero2
            // 
            pbHero2.Location = new Point(50, 243);
            pbHero2.Name = "pbHero2";
            pbHero2.Size = new Size(100, 23);
            pbHero2.TabIndex = 7;
            // 
            // pbHero3
            // 
            pbHero3.Location = new Point(50, 297);
            pbHero3.Name = "pbHero3";
            pbHero3.Size = new Size(100, 23);
            pbHero3.TabIndex = 8;
            // 
            // pbEnemy1
            // 
            pbEnemy1.Location = new Point(245, 193);
            pbEnemy1.Name = "pbEnemy1";
            pbEnemy1.Size = new Size(100, 23);
            pbEnemy1.TabIndex = 9;
            // 
            // pbEnemy2
            // 
            pbEnemy2.Location = new Point(245, 243);
            pbEnemy2.Name = "pbEnemy2";
            pbEnemy2.Size = new Size(100, 23);
            pbEnemy2.TabIndex = 10;
            // 
            // pbEnemy3
            // 
            pbEnemy3.Location = new Point(245, 297);
            pbEnemy3.Name = "pbEnemy3";
            pbEnemy3.Size = new Size(100, 23);
            pbEnemy3.TabIndex = 11;
            // 
            // lblHero1
            // 
            lblHero1.AutoSize = true;
            lblHero1.Location = new Point(50, 219);
            lblHero1.Name = "lblHero1";
            lblHero1.Size = new Size(38, 15);
            lblHero1.TabIndex = 12;
            lblHero1.Text = "label1";
            // 
            // lblHero2
            // 
            lblHero2.AutoSize = true;
            lblHero2.Location = new Point(50, 269);
            lblHero2.Name = "lblHero2";
            lblHero2.Size = new Size(38, 15);
            lblHero2.TabIndex = 13;
            lblHero2.Text = "label2";
            // 
            // lblHero3
            // 
            lblHero3.AutoSize = true;
            lblHero3.Location = new Point(50, 323);
            lblHero3.Name = "lblHero3";
            lblHero3.Size = new Size(38, 15);
            lblHero3.TabIndex = 14;
            lblHero3.Text = "label3";
            // 
            // lblEnemy1
            // 
            lblEnemy1.AutoSize = true;
            lblEnemy1.Location = new Point(245, 219);
            lblEnemy1.Name = "lblEnemy1";
            lblEnemy1.Size = new Size(38, 15);
            lblEnemy1.TabIndex = 15;
            lblEnemy1.Text = "label4";
            // 
            // lblEnemy2
            // 
            lblEnemy2.AutoSize = true;
            lblEnemy2.Location = new Point(245, 269);
            lblEnemy2.Name = "lblEnemy2";
            lblEnemy2.Size = new Size(38, 15);
            lblEnemy2.TabIndex = 16;
            lblEnemy2.Text = "label5";
            // 
            // lblEnemy3
            // 
            lblEnemy3.AutoSize = true;
            lblEnemy3.Location = new Point(245, 323);
            lblEnemy3.Name = "lblEnemy3";
            lblEnemy3.Size = new Size(38, 15);
            lblEnemy3.TabIndex = 17;
            lblEnemy3.Text = "label6";
            // 
            // lstHeroes
            // 
            lstHeroes.FormattingEnabled = true;
            lstHeroes.ItemHeight = 15;
            lstHeroes.Location = new Point(30, 12);
            lstHeroes.Name = "lstHeroes";
            lstHeroes.Size = new Size(146, 169);
            lstHeroes.TabIndex = 20;
            // 
            // lstEnemies
            // 
            lstEnemies.FormattingEnabled = true;
            lstEnemies.ItemHeight = 15;
            lstEnemies.Location = new Point(225, 12);
            lstEnemies.Name = "lstEnemies";
            lstEnemies.Size = new Size(140, 169);
            lstEnemies.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEnemies);
            Controls.Add(lstHeroes);
            Controls.Add(lblEnemy3);
            Controls.Add(lblEnemy2);
            Controls.Add(lblEnemy1);
            Controls.Add(lblHero3);
            Controls.Add(lblHero2);
            Controls.Add(lblHero1);
            Controls.Add(pbEnemy3);
            Controls.Add(pbEnemy2);
            Controls.Add(pbEnemy1);
            Controls.Add(pbHero3);
            Controls.Add(pbHero2);
            Controls.Add(pbHero1);
            Controls.Add(btnReset);
            Controls.Add(txtResult);
            Controls.Add(btnAttack);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAttack;
        private TextBox txtResult;
        private Button btnReset;
        private ProgressBar pbHero1;
        private ProgressBar pbHero2;
        private ProgressBar pbHero3;
        private ProgressBar pbEnemy1;
        private ProgressBar pbEnemy2;
        private ProgressBar pbEnemy3;
        private Label lblHero1;
        private Label lblHero2;
        private Label lblHero3;
        private Label lblEnemy1;
        private Label lblEnemy2;
        private Label lblEnemy3;
        private ListBox lstHeroes;
        private ListBox lstEnemies;
    }
}
