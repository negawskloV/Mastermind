
namespace Mastermind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnHowTo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSol1 = new System.Windows.Forms.Button();
            this.btnSol2 = new System.Windows.Forms.Button();
            this.btnSol3 = new System.Windows.Forms.Button();
            this.btnSol4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(12, 147);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(40, 40);
            this.btnBlack.TabIndex = 0;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(12, 193);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(40, 40);
            this.btnWhite.TabIndex = 1;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(12, 331);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(40, 40);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(12, 239);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(40, 40);
            this.btnRed.TabIndex = 3;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(12, 285);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(40, 40);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(12, 377);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(40, 40);
            this.btnYellow.TabIndex = 5;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(12, 423);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(40, 40);
            this.btnOrange.TabIndex = 6;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.Location = new System.Drawing.Point(12, 469);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(40, 40);
            this.btnPurple.TabIndex = 7;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 86);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 55);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit Attempt";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnHowTo
            // 
            this.btnHowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowTo.Location = new System.Drawing.Point(12, 12);
            this.btnHowTo.Name = "btnHowTo";
            this.btnHowTo.Size = new System.Drawing.Size(90, 55);
            this.btnHowTo.TabIndex = 9;
            this.btnHowTo.Text = "How to play";
            this.btnHowTo.UseVisualStyleBackColor = true;
            this.btnHowTo.Click += new System.EventHandler(this.btnHowTo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(616, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 55);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSol1
            // 
            this.btnSol1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSol1.Enabled = false;
            this.btnSol1.Location = new System.Drawing.Point(175, 12);
            this.btnSol1.Name = "btnSol1";
            this.btnSol1.Size = new System.Drawing.Size(60, 60);
            this.btnSol1.TabIndex = 11;
            this.btnSol1.UseVisualStyleBackColor = false;
            // 
            // btnSol2
            // 
            this.btnSol2.Enabled = false;
            this.btnSol2.Location = new System.Drawing.Point(241, 12);
            this.btnSol2.Name = "btnSol2";
            this.btnSol2.Size = new System.Drawing.Size(60, 60);
            this.btnSol2.TabIndex = 12;
            this.btnSol2.UseVisualStyleBackColor = true;
            // 
            // btnSol3
            // 
            this.btnSol3.Enabled = false;
            this.btnSol3.Location = new System.Drawing.Point(307, 12);
            this.btnSol3.Name = "btnSol3";
            this.btnSol3.Size = new System.Drawing.Size(60, 60);
            this.btnSol3.TabIndex = 13;
            this.btnSol3.UseVisualStyleBackColor = true;
            // 
            // btnSol4
            // 
            this.btnSol4.Enabled = false;
            this.btnSol4.Location = new System.Drawing.Point(373, 12);
            this.btnSol4.Name = "btnSol4";
            this.btnSol4.Size = new System.Drawing.Size(60, 60);
            this.btnSol4.TabIndex = 14;
            this.btnSol4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selected color:\r\n   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSol4);
            this.Controls.Add(this.btnSol3);
            this.Controls.Add(this.btnSol2);
            this.Controls.Add(this.btnSol1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHowTo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnBlack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mastermind";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHowTo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSol1;
        private System.Windows.Forms.Button btnSol2;
        private System.Windows.Forms.Button btnSol3;
        private System.Windows.Forms.Button btnSol4;
        private System.Windows.Forms.Label label1;
    }
}

