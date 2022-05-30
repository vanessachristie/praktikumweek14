namespace praktikumweek14
{
    partial class FormTeam
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lTeamName = new System.Windows.Forms.Label();
            this.lManager = new System.Windows.Forms.Label();
            this.lStadium = new System.Windows.Forms.Label();
            this.lTopScorer = new System.Windows.Forms.Label();
            this.lWorst = new System.Windows.Forms.Label();
            this.laTeamName = new System.Windows.Forms.Label();
            this.laManager = new System.Windows.Forms.Label();
            this.laStadium = new System.Windows.Forms.Label();
            this.laTopScorer = new System.Windows.Forms.Label();
            this.laWorst = new System.Windows.Forms.Label();
            this.GridMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(113, 33);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(49, 34);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(190, 33);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 34);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(269, 33);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(42, 34);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(336, 33);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(54, 34);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lTeamName
            // 
            this.lTeamName.AutoSize = true;
            this.lTeamName.Location = new System.Drawing.Point(123, 90);
            this.lTeamName.Name = "lTeamName";
            this.lTeamName.Size = new System.Drawing.Size(86, 16);
            this.lTeamName.TabIndex = 4;
            this.lTeamName.Text = "Team Name:";
            // 
            // lManager
            // 
            this.lManager.AutoSize = true;
            this.lManager.Location = new System.Drawing.Point(124, 127);
            this.lManager.Name = "lManager";
            this.lManager.Size = new System.Drawing.Size(67, 16);
            this.lManager.TabIndex = 5;
            this.lManager.Text = "Manager :";
            // 
            // lStadium
            // 
            this.lStadium.AutoSize = true;
            this.lStadium.Location = new System.Drawing.Point(123, 165);
            this.lStadium.Name = "lStadium";
            this.lStadium.Size = new System.Drawing.Size(59, 16);
            this.lStadium.TabIndex = 6;
            this.lStadium.Text = "Stadium:";
            // 
            // lTopScorer
            // 
            this.lTopScorer.AutoSize = true;
            this.lTopScorer.Location = new System.Drawing.Point(123, 201);
            this.lTopScorer.Name = "lTopScorer";
            this.lTopScorer.Size = new System.Drawing.Size(75, 16);
            this.lTopScorer.TabIndex = 7;
            this.lTopScorer.Text = "Top Scorer";
            // 
            // lWorst
            // 
            this.lWorst.AutoSize = true;
            this.lWorst.Location = new System.Drawing.Point(123, 239);
            this.lWorst.Name = "lWorst";
            this.lWorst.Size = new System.Drawing.Size(107, 16);
            this.lWorst.TabIndex = 8;
            this.lWorst.Text = "Worst Discipline:";
            // 
            // laTeamName
            // 
            this.laTeamName.AutoSize = true;
            this.laTeamName.Location = new System.Drawing.Point(323, 90);
            this.laTeamName.Name = "laTeamName";
            this.laTeamName.Size = new System.Drawing.Size(44, 16);
            this.laTeamName.TabIndex = 9;
            this.laTeamName.Text = "label1";
            // 
            // laManager
            // 
            this.laManager.AutoSize = true;
            this.laManager.Location = new System.Drawing.Point(323, 127);
            this.laManager.Name = "laManager";
            this.laManager.Size = new System.Drawing.Size(44, 16);
            this.laManager.TabIndex = 10;
            this.laManager.Text = "label2";
            // 
            // laStadium
            // 
            this.laStadium.AutoSize = true;
            this.laStadium.Location = new System.Drawing.Point(323, 165);
            this.laStadium.Name = "laStadium";
            this.laStadium.Size = new System.Drawing.Size(44, 16);
            this.laStadium.TabIndex = 11;
            this.laStadium.Text = "label3";
            // 
            // laTopScorer
            // 
            this.laTopScorer.AutoSize = true;
            this.laTopScorer.Location = new System.Drawing.Point(323, 201);
            this.laTopScorer.Name = "laTopScorer";
            this.laTopScorer.Size = new System.Drawing.Size(44, 16);
            this.laTopScorer.TabIndex = 12;
            this.laTopScorer.Text = "label4";
            // 
            // laWorst
            // 
            this.laWorst.AutoSize = true;
            this.laWorst.Location = new System.Drawing.Point(323, 239);
            this.laWorst.Name = "laWorst";
            this.laWorst.Size = new System.Drawing.Size(44, 16);
            this.laWorst.TabIndex = 13;
            this.laWorst.Text = "label5";
            // 
            // GridMatch
            // 
            this.GridMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMatch.Location = new System.Drawing.Point(46, 288);
            this.GridMatch.Name = "GridMatch";
            this.GridMatch.RowHeadersWidth = 51;
            this.GridMatch.RowTemplate.Height = 24;
            this.GridMatch.Size = new System.Drawing.Size(730, 150);
            this.GridMatch.TabIndex = 14;
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridMatch);
            this.Controls.Add(this.laWorst);
            this.Controls.Add(this.laTopScorer);
            this.Controls.Add(this.laStadium);
            this.Controls.Add(this.laManager);
            this.Controls.Add(this.laTeamName);
            this.Controls.Add(this.lWorst);
            this.Controls.Add(this.lTopScorer);
            this.Controls.Add(this.lStadium);
            this.Controls.Add(this.lManager);
            this.Controls.Add(this.lTeamName);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Name = "FormTeam";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.FormTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lTeamName;
        private System.Windows.Forms.Label lManager;
        private System.Windows.Forms.Label lStadium;
        private System.Windows.Forms.Label lTopScorer;
        private System.Windows.Forms.Label lWorst;
        private System.Windows.Forms.Label laTeamName;
        private System.Windows.Forms.Label laManager;
        private System.Windows.Forms.Label laStadium;
        private System.Windows.Forms.Label laTopScorer;
        private System.Windows.Forms.Label laWorst;
        private System.Windows.Forms.DataGridView GridMatch;
    }
}

