namespace A2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.gameInfo = new System.Windows.Forms.GroupBox();
            this.lblNumLost = new System.Windows.Forms.Label();
            this.lblNumWon = new System.Windows.Forms.Label();
            this.lblNumPlayed = new System.Windows.Forms.Label();
            this.labelLost = new System.Windows.Forms.Label();
            this.LabelWon = new System.Windows.Forms.Label();
            this.labelPlayed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.lblInputError = new System.Windows.Forms.Label();
            this.pbDie = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMultiRoll = new System.Windows.Forms.Button();
            this.tbMultiRoll = new System.Windows.Forms.TextBox();
            this.lblMultiError = new System.Windows.Forms.Label();
            this.gameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbResults
            // 
            this.rtbResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResults.Location = new System.Drawing.Point(12, 282);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(290, 121);
            this.rtbResults.TabIndex = 0;
            this.rtbResults.Text = "";
            // 
            // gameInfo
            // 
            this.gameInfo.Controls.Add(this.lblNumLost);
            this.gameInfo.Controls.Add(this.lblNumWon);
            this.gameInfo.Controls.Add(this.lblNumPlayed);
            this.gameInfo.Controls.Add(this.labelLost);
            this.gameInfo.Controls.Add(this.LabelWon);
            this.gameInfo.Controls.Add(this.labelPlayed);
            this.gameInfo.Location = new System.Drawing.Point(12, 12);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(290, 100);
            this.gameInfo.TabIndex = 1;
            this.gameInfo.TabStop = false;
            this.gameInfo.Text = "Game Info";
            // 
            // lblNumLost
            // 
            this.lblNumLost.Location = new System.Drawing.Point(143, 80);
            this.lblNumLost.Name = "lblNumLost";
            this.lblNumLost.Size = new System.Drawing.Size(141, 13);
            this.lblNumLost.TabIndex = 4;
            this.lblNumLost.Text = "0";
            this.lblNumLost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumWon
            // 
            this.lblNumWon.Location = new System.Drawing.Point(148, 48);
            this.lblNumWon.Name = "lblNumWon";
            this.lblNumWon.Size = new System.Drawing.Size(136, 13);
            this.lblNumWon.TabIndex = 4;
            this.lblNumWon.Text = "0";
            this.lblNumWon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumPlayed
            // 
            this.lblNumPlayed.Location = new System.Drawing.Point(160, 16);
            this.lblNumPlayed.Name = "lblNumPlayed";
            this.lblNumPlayed.Size = new System.Drawing.Size(124, 13);
            this.lblNumPlayed.TabIndex = 3;
            this.lblNumPlayed.Text = "0";
            this.lblNumPlayed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLost
            // 
            this.labelLost.AutoSize = true;
            this.labelLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLost.Location = new System.Drawing.Point(6, 80);
            this.labelLost.Name = "labelLost";
            this.labelLost.Size = new System.Drawing.Size(134, 13);
            this.labelLost.TabIndex = 2;
            this.labelLost.Text = "Number of Times Lost:";
            // 
            // LabelWon
            // 
            this.LabelWon.AutoSize = true;
            this.LabelWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWon.Location = new System.Drawing.Point(6, 48);
            this.LabelWon.Name = "LabelWon";
            this.LabelWon.Size = new System.Drawing.Size(136, 13);
            this.LabelWon.TabIndex = 1;
            this.LabelWon.Text = "Number of Times Won:";
            // 
            // labelPlayed
            // 
            this.labelPlayed.AutoSize = true;
            this.labelPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayed.Location = new System.Drawing.Point(6, 16);
            this.labelPlayed.Name = "labelPlayed";
            this.labelPlayed.Size = new System.Drawing.Size(148, 13);
            this.labelPlayed.TabIndex = 0;
            this.labelPlayed.Text = "Number of Times Played:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your guess  (1-6):";
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(155, 116);
            this.tbGuess.MaxLength = 1;
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(43, 20);
            this.tbGuess.TabIndex = 3;
            this.tbGuess.TextChanged += new System.EventHandler(this.textChangedGuess);
            // 
            // lblInputError
            // 
            this.lblInputError.AutoSize = true;
            this.lblInputError.ForeColor = System.Drawing.Color.Red;
            this.lblInputError.Location = new System.Drawing.Point(204, 119);
            this.lblInputError.Name = "lblInputError";
            this.lblInputError.Size = new System.Drawing.Size(73, 13);
            this.lblInputError.TabIndex = 4;
            this.lblInputError.Text = "Not a Number";
            this.lblInputError.Visible = false;
            // 
            // pbDie
            // 
            this.pbDie.Location = new System.Drawing.Point(56, 148);
            this.pbDie.Name = "pbDie";
            this.pbDie.Size = new System.Drawing.Size(128, 128);
            this.pbDie.TabIndex = 5;
            this.pbDie.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(215, 148);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 6;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(215, 177);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMultiRoll
            // 
            this.btnMultiRoll.Location = new System.Drawing.Point(215, 206);
            this.btnMultiRoll.Name = "btnMultiRoll";
            this.btnMultiRoll.Size = new System.Drawing.Size(75, 23);
            this.btnMultiRoll.TabIndex = 8;
            this.btnMultiRoll.Text = "Multi-Roll";
            this.btnMultiRoll.UseVisualStyleBackColor = true;
            this.btnMultiRoll.Click += new System.EventHandler(this.btnMultiRoll_Click);
            // 
            // tbMultiRoll
            // 
            this.tbMultiRoll.Location = new System.Drawing.Point(215, 235);
            this.tbMultiRoll.MaxLength = 7;
            this.tbMultiRoll.Name = "tbMultiRoll";
            this.tbMultiRoll.Size = new System.Drawing.Size(75, 20);
            this.tbMultiRoll.TabIndex = 9;
            this.tbMultiRoll.TextChanged += new System.EventHandler(this.tbMultiRoll_TextChanged);
            // 
            // lblMultiError
            // 
            this.lblMultiError.AutoSize = true;
            this.lblMultiError.ForeColor = System.Drawing.Color.Red;
            this.lblMultiError.Location = new System.Drawing.Point(217, 258);
            this.lblMultiError.Name = "lblMultiError";
            this.lblMultiError.Size = new System.Drawing.Size(73, 13);
            this.lblMultiError.TabIndex = 10;
            this.lblMultiError.Text = "Not a Number";
            this.lblMultiError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 415);
            this.Controls.Add(this.lblMultiError);
            this.Controls.Add(this.tbMultiRoll);
            this.Controls.Add(this.btnMultiRoll);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pbDie);
            this.Controls.Add(this.lblInputError);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameInfo);
            this.Controls.Add(this.rtbResults);
            this.Name = "Form1";
            this.Text = "Dice Roll/Guessing";
            this.gameInfo.ResumeLayout(false);
            this.gameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbResults;
        public System.Windows.Forms.GroupBox gameInfo;
        public System.Windows.Forms.Label labelLost;
        public System.Windows.Forms.Label LabelWon;
        public System.Windows.Forms.Label labelPlayed;
        public System.Windows.Forms.Label lblNumLost;
        public System.Windows.Forms.Label lblNumWon;
        public System.Windows.Forms.Label lblNumPlayed;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbGuess;
        public System.Windows.Forms.Label lblInputError;
        public System.Windows.Forms.PictureBox pbDie;
        public System.Windows.Forms.Button btnRoll;
        public System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMultiRoll;
        private System.Windows.Forms.TextBox tbMultiRoll;
        public System.Windows.Forms.Label lblMultiError;
    }
}

