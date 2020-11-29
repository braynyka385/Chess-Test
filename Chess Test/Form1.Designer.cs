namespace Chess_Test
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
            this.components = new System.ComponentModel.Container();
            this.bRook1 = new System.Windows.Forms.Button();
            this.bKnight1 = new System.Windows.Forms.Button();
            this.bBishop1 = new System.Windows.Forms.Button();
            this.bQueen = new System.Windows.Forms.Button();
            this.bKing = new System.Windows.Forms.Button();
            this.bBishop2 = new System.Windows.Forms.Button();
            this.bKnight2 = new System.Windows.Forms.Button();
            this.bRook2 = new System.Windows.Forms.Button();
            this.wRook2 = new System.Windows.Forms.Button();
            this.wKnight2 = new System.Windows.Forms.Button();
            this.wBishop2 = new System.Windows.Forms.Button();
            this.wKing = new System.Windows.Forms.Button();
            this.wQueen = new System.Windows.Forms.Button();
            this.wBishop1 = new System.Windows.Forms.Button();
            this.wKnight1 = new System.Windows.Forms.Button();
            this.wRook1 = new System.Windows.Forms.Button();
            this.wPawn8 = new System.Windows.Forms.Button();
            this.wPawn7 = new System.Windows.Forms.Button();
            this.wPawn6 = new System.Windows.Forms.Button();
            this.wPawn5 = new System.Windows.Forms.Button();
            this.wPawn4 = new System.Windows.Forms.Button();
            this.wPawn3 = new System.Windows.Forms.Button();
            this.wPawn2 = new System.Windows.Forms.Button();
            this.wPawn1 = new System.Windows.Forms.Button();
            this.bPawn8 = new System.Windows.Forms.Button();
            this.bPawn7 = new System.Windows.Forms.Button();
            this.bPawn6 = new System.Windows.Forms.Button();
            this.bPawn5 = new System.Windows.Forms.Button();
            this.bPawn4 = new System.Windows.Forms.Button();
            this.bPawn3 = new System.Windows.Forms.Button();
            this.bPawn2 = new System.Windows.Forms.Button();
            this.bPawn1 = new System.Windows.Forms.Button();
            this.bTime = new System.Windows.Forms.Label();
            this.wTime = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.debugLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bRook1
            // 
            this.bRook1.BackColor = System.Drawing.Color.Black;
            this.bRook1.ForeColor = System.Drawing.Color.White;
            this.bRook1.Location = new System.Drawing.Point(55, 55);
            this.bRook1.Name = "bRook1";
            this.bRook1.Size = new System.Drawing.Size(54, 54);
            this.bRook1.TabIndex = 0;
            this.bRook1.Text = "bRook1";
            this.bRook1.UseVisualStyleBackColor = false;
            this.bRook1.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bKnight1
            // 
            this.bKnight1.BackColor = System.Drawing.Color.Black;
            this.bKnight1.ForeColor = System.Drawing.Color.White;
            this.bKnight1.Location = new System.Drawing.Point(110, 55);
            this.bKnight1.Name = "bKnight1";
            this.bKnight1.Size = new System.Drawing.Size(54, 54);
            this.bKnight1.TabIndex = 1;
            this.bKnight1.Text = "bKnight1";
            this.bKnight1.UseVisualStyleBackColor = false;
            this.bKnight1.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bBishop1
            // 
            this.bBishop1.BackColor = System.Drawing.Color.Black;
            this.bBishop1.ForeColor = System.Drawing.Color.White;
            this.bBishop1.Location = new System.Drawing.Point(165, 55);
            this.bBishop1.Name = "bBishop1";
            this.bBishop1.Size = new System.Drawing.Size(54, 54);
            this.bBishop1.TabIndex = 2;
            this.bBishop1.Text = "bBishop1";
            this.bBishop1.UseVisualStyleBackColor = false;
            this.bBishop1.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bQueen
            // 
            this.bQueen.BackColor = System.Drawing.Color.Black;
            this.bQueen.ForeColor = System.Drawing.Color.White;
            this.bQueen.Location = new System.Drawing.Point(220, 55);
            this.bQueen.Name = "bQueen";
            this.bQueen.Size = new System.Drawing.Size(54, 54);
            this.bQueen.TabIndex = 3;
            this.bQueen.Text = "bQueen";
            this.bQueen.UseVisualStyleBackColor = false;
            this.bQueen.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bKing
            // 
            this.bKing.BackColor = System.Drawing.Color.Black;
            this.bKing.ForeColor = System.Drawing.Color.White;
            this.bKing.Location = new System.Drawing.Point(275, 55);
            this.bKing.Name = "bKing";
            this.bKing.Size = new System.Drawing.Size(54, 54);
            this.bKing.TabIndex = 4;
            this.bKing.Text = "bKing";
            this.bKing.UseVisualStyleBackColor = false;
            this.bKing.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bBishop2
            // 
            this.bBishop2.BackColor = System.Drawing.Color.Black;
            this.bBishop2.ForeColor = System.Drawing.Color.White;
            this.bBishop2.Location = new System.Drawing.Point(330, 55);
            this.bBishop2.Name = "bBishop2";
            this.bBishop2.Size = new System.Drawing.Size(54, 54);
            this.bBishop2.TabIndex = 5;
            this.bBishop2.Text = "bBishop2";
            this.bBishop2.UseVisualStyleBackColor = false;
            this.bBishop2.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bKnight2
            // 
            this.bKnight2.BackColor = System.Drawing.Color.Black;
            this.bKnight2.ForeColor = System.Drawing.Color.White;
            this.bKnight2.Location = new System.Drawing.Point(385, 55);
            this.bKnight2.Name = "bKnight2";
            this.bKnight2.Size = new System.Drawing.Size(54, 54);
            this.bKnight2.TabIndex = 6;
            this.bKnight2.Text = "bKnight2";
            this.bKnight2.UseVisualStyleBackColor = false;
            this.bKnight2.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bRook2
            // 
            this.bRook2.BackColor = System.Drawing.Color.Black;
            this.bRook2.ForeColor = System.Drawing.Color.White;
            this.bRook2.Location = new System.Drawing.Point(440, 55);
            this.bRook2.Name = "bRook2";
            this.bRook2.Size = new System.Drawing.Size(54, 54);
            this.bRook2.TabIndex = 7;
            this.bRook2.Text = "bRook2";
            this.bRook2.UseVisualStyleBackColor = false;
            this.bRook2.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wRook2
            // 
            this.wRook2.Location = new System.Drawing.Point(440, 440);
            this.wRook2.Name = "wRook2";
            this.wRook2.Size = new System.Drawing.Size(54, 54);
            this.wRook2.TabIndex = 15;
            this.wRook2.Text = "wRook2";
            this.wRook2.UseVisualStyleBackColor = true;
            this.wRook2.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wKnight2
            // 
            this.wKnight2.Location = new System.Drawing.Point(385, 440);
            this.wKnight2.Name = "wKnight2";
            this.wKnight2.Size = new System.Drawing.Size(54, 54);
            this.wKnight2.TabIndex = 14;
            this.wKnight2.Text = "wKnight2";
            this.wKnight2.UseVisualStyleBackColor = true;
            this.wKnight2.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wBishop2
            // 
            this.wBishop2.Location = new System.Drawing.Point(330, 440);
            this.wBishop2.Name = "wBishop2";
            this.wBishop2.Size = new System.Drawing.Size(54, 54);
            this.wBishop2.TabIndex = 13;
            this.wBishop2.Text = "wBishop2";
            this.wBishop2.UseVisualStyleBackColor = true;
            this.wBishop2.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wKing
            // 
            this.wKing.Location = new System.Drawing.Point(275, 440);
            this.wKing.Name = "wKing";
            this.wKing.Size = new System.Drawing.Size(54, 54);
            this.wKing.TabIndex = 12;
            this.wKing.Text = "wKing";
            this.wKing.UseVisualStyleBackColor = true;
            this.wKing.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wQueen
            // 
            this.wQueen.Location = new System.Drawing.Point(220, 440);
            this.wQueen.Name = "wQueen";
            this.wQueen.Size = new System.Drawing.Size(54, 54);
            this.wQueen.TabIndex = 11;
            this.wQueen.Text = "wQueen";
            this.wQueen.UseVisualStyleBackColor = true;
            this.wQueen.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wBishop1
            // 
            this.wBishop1.Location = new System.Drawing.Point(165, 440);
            this.wBishop1.Name = "wBishop1";
            this.wBishop1.Size = new System.Drawing.Size(54, 54);
            this.wBishop1.TabIndex = 10;
            this.wBishop1.Text = "wBishop1";
            this.wBishop1.UseVisualStyleBackColor = true;
            this.wBishop1.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wKnight1
            // 
            this.wKnight1.Location = new System.Drawing.Point(110, 440);
            this.wKnight1.Name = "wKnight1";
            this.wKnight1.Size = new System.Drawing.Size(54, 54);
            this.wKnight1.TabIndex = 9;
            this.wKnight1.Text = "wKnight1";
            this.wKnight1.UseVisualStyleBackColor = true;
            this.wKnight1.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wRook1
            // 
            this.wRook1.Location = new System.Drawing.Point(55, 440);
            this.wRook1.Name = "wRook1";
            this.wRook1.Size = new System.Drawing.Size(54, 54);
            this.wRook1.TabIndex = 8;
            this.wRook1.Text = "wRook1";
            this.wRook1.UseVisualStyleBackColor = true;
            this.wRook1.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wPawn8
            // 
            this.wPawn8.Location = new System.Drawing.Point(440, 385);
            this.wPawn8.Name = "wPawn8";
            this.wPawn8.Size = new System.Drawing.Size(54, 54);
            this.wPawn8.TabIndex = 23;
            this.wPawn8.Text = "wPawn8";
            this.wPawn8.UseVisualStyleBackColor = true;
            this.wPawn8.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wPawn7
            // 
            this.wPawn7.Location = new System.Drawing.Point(385, 385);
            this.wPawn7.Name = "wPawn7";
            this.wPawn7.Size = new System.Drawing.Size(54, 54);
            this.wPawn7.TabIndex = 22;
            this.wPawn7.Text = "wPawn7";
            this.wPawn7.UseVisualStyleBackColor = true;
            this.wPawn7.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wPawn6
            // 
            this.wPawn6.Location = new System.Drawing.Point(330, 385);
            this.wPawn6.Name = "wPawn6";
            this.wPawn6.Size = new System.Drawing.Size(54, 54);
            this.wPawn6.TabIndex = 21;
            this.wPawn6.Text = "wPawn6";
            this.wPawn6.UseVisualStyleBackColor = true;
            this.wPawn6.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wPawn5
            // 
            this.wPawn5.Location = new System.Drawing.Point(275, 385);
            this.wPawn5.Name = "wPawn5";
            this.wPawn5.Size = new System.Drawing.Size(54, 54);
            this.wPawn5.TabIndex = 20;
            this.wPawn5.Text = "wPawn5";
            this.wPawn5.UseVisualStyleBackColor = true;
            this.wPawn5.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wPawn4
            // 
            this.wPawn4.Location = new System.Drawing.Point(220, 385);
            this.wPawn4.Name = "wPawn4";
            this.wPawn4.Size = new System.Drawing.Size(54, 54);
            this.wPawn4.TabIndex = 19;
            this.wPawn4.Text = "wPawn4";
            this.wPawn4.UseVisualStyleBackColor = true;
            this.wPawn4.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wPawn3
            // 
            this.wPawn3.Location = new System.Drawing.Point(165, 385);
            this.wPawn3.Name = "wPawn3";
            this.wPawn3.Size = new System.Drawing.Size(54, 54);
            this.wPawn3.TabIndex = 18;
            this.wPawn3.Text = "wPawn3";
            this.wPawn3.UseVisualStyleBackColor = true;
            this.wPawn3.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wPawn2
            // 
            this.wPawn2.Location = new System.Drawing.Point(110, 385);
            this.wPawn2.Name = "wPawn2";
            this.wPawn2.Size = new System.Drawing.Size(54, 54);
            this.wPawn2.TabIndex = 17;
            this.wPawn2.Text = "wPawn2";
            this.wPawn2.UseVisualStyleBackColor = true;
            this.wPawn2.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // wPawn1
            // 
            this.wPawn1.Location = new System.Drawing.Point(55, 385);
            this.wPawn1.Name = "wPawn1";
            this.wPawn1.Size = new System.Drawing.Size(54, 54);
            this.wPawn1.TabIndex = 16;
            this.wPawn1.Text = "wPawn1";
            this.wPawn1.UseVisualStyleBackColor = true;
            this.wPawn1.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bPawn8
            // 
            this.bPawn8.BackColor = System.Drawing.Color.Black;
            this.bPawn8.ForeColor = System.Drawing.Color.White;
            this.bPawn8.Location = new System.Drawing.Point(440, 110);
            this.bPawn8.Name = "bPawn8";
            this.bPawn8.Size = new System.Drawing.Size(54, 54);
            this.bPawn8.TabIndex = 31;
            this.bPawn8.Text = "bPawn8";
            this.bPawn8.UseVisualStyleBackColor = false;
            this.bPawn8.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bPawn7
            // 
            this.bPawn7.BackColor = System.Drawing.Color.Black;
            this.bPawn7.ForeColor = System.Drawing.Color.White;
            this.bPawn7.Location = new System.Drawing.Point(385, 110);
            this.bPawn7.Name = "bPawn7";
            this.bPawn7.Size = new System.Drawing.Size(54, 54);
            this.bPawn7.TabIndex = 30;
            this.bPawn7.Text = "bPawn7";
            this.bPawn7.UseVisualStyleBackColor = false;
            this.bPawn7.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bPawn6
            // 
            this.bPawn6.BackColor = System.Drawing.Color.Black;
            this.bPawn6.ForeColor = System.Drawing.Color.White;
            this.bPawn6.Location = new System.Drawing.Point(330, 110);
            this.bPawn6.Name = "bPawn6";
            this.bPawn6.Size = new System.Drawing.Size(54, 54);
            this.bPawn6.TabIndex = 29;
            this.bPawn6.Text = "bPawn6";
            this.bPawn6.UseVisualStyleBackColor = false;
            this.bPawn6.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bPawn5
            // 
            this.bPawn5.BackColor = System.Drawing.Color.Black;
            this.bPawn5.ForeColor = System.Drawing.Color.White;
            this.bPawn5.Location = new System.Drawing.Point(275, 110);
            this.bPawn5.Name = "bPawn5";
            this.bPawn5.Size = new System.Drawing.Size(54, 54);
            this.bPawn5.TabIndex = 28;
            this.bPawn5.Text = "bPawn5";
            this.bPawn5.UseVisualStyleBackColor = false;
            this.bPawn5.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bPawn4
            // 
            this.bPawn4.BackColor = System.Drawing.Color.Black;
            this.bPawn4.ForeColor = System.Drawing.Color.White;
            this.bPawn4.Location = new System.Drawing.Point(220, 110);
            this.bPawn4.Name = "bPawn4";
            this.bPawn4.Size = new System.Drawing.Size(54, 54);
            this.bPawn4.TabIndex = 27;
            this.bPawn4.Text = "bPawn4";
            this.bPawn4.UseVisualStyleBackColor = false;
            this.bPawn4.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bPawn3
            // 
            this.bPawn3.BackColor = System.Drawing.Color.Black;
            this.bPawn3.ForeColor = System.Drawing.Color.White;
            this.bPawn3.Location = new System.Drawing.Point(165, 110);
            this.bPawn3.Name = "bPawn3";
            this.bPawn3.Size = new System.Drawing.Size(54, 54);
            this.bPawn3.TabIndex = 26;
            this.bPawn3.Text = "bPawn3";
            this.bPawn3.UseVisualStyleBackColor = false;
            this.bPawn3.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bPawn2
            // 
            this.bPawn2.BackColor = System.Drawing.Color.Black;
            this.bPawn2.ForeColor = System.Drawing.Color.White;
            this.bPawn2.Location = new System.Drawing.Point(110, 110);
            this.bPawn2.Name = "bPawn2";
            this.bPawn2.Size = new System.Drawing.Size(54, 54);
            this.bPawn2.TabIndex = 25;
            this.bPawn2.Text = "bPawn2";
            this.bPawn2.UseVisualStyleBackColor = false;
            this.bPawn2.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bPawn1
            // 
            this.bPawn1.BackColor = System.Drawing.Color.Black;
            this.bPawn1.ForeColor = System.Drawing.Color.White;
            this.bPawn1.Location = new System.Drawing.Point(55, 110);
            this.bPawn1.Name = "bPawn1";
            this.bPawn1.Size = new System.Drawing.Size(54, 54);
            this.bPawn1.TabIndex = 24;
            this.bPawn1.Text = "bPawn1";
            this.bPawn1.UseVisualStyleBackColor = false;
            this.bPawn1.Click += new System.EventHandler(this.button_down_on_piece);
            // 
            // bTime
            // 
            this.bTime.AutoSize = true;
            this.bTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTime.Location = new System.Drawing.Point(554, 40);
            this.bTime.Name = "bTime";
            this.bTime.Size = new System.Drawing.Size(74, 36);
            this.bTime.TabIndex = 32;
            this.bTime.Text = "5:00";
            // 
            // wTime
            // 
            this.wTime.AutoSize = true;
            this.wTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wTime.Location = new System.Drawing.Point(554, 345);
            this.wTime.Name = "wTime";
            this.wTime.Size = new System.Drawing.Size(74, 36);
            this.wTime.TabIndex = 33;
            this.wTime.Text = "5:00";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(553, 224);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 34;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(550, 151);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(35, 13);
            this.debugLabel.TabIndex = 35;
            this.debugLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 529);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.wTime);
            this.Controls.Add(this.bTime);
            this.Controls.Add(this.bPawn8);
            this.Controls.Add(this.bPawn7);
            this.Controls.Add(this.bPawn6);
            this.Controls.Add(this.bPawn5);
            this.Controls.Add(this.bPawn4);
            this.Controls.Add(this.bPawn3);
            this.Controls.Add(this.bPawn2);
            this.Controls.Add(this.bPawn1);
            this.Controls.Add(this.wPawn8);
            this.Controls.Add(this.wPawn7);
            this.Controls.Add(this.wPawn6);
            this.Controls.Add(this.wPawn5);
            this.Controls.Add(this.wPawn4);
            this.Controls.Add(this.wPawn3);
            this.Controls.Add(this.wPawn2);
            this.Controls.Add(this.wPawn1);
            this.Controls.Add(this.wRook2);
            this.Controls.Add(this.wKnight2);
            this.Controls.Add(this.wBishop2);
            this.Controls.Add(this.wKing);
            this.Controls.Add(this.wQueen);
            this.Controls.Add(this.wBishop1);
            this.Controls.Add(this.wKnight1);
            this.Controls.Add(this.wRook1);
            this.Controls.Add(this.bRook2);
            this.Controls.Add(this.bKnight2);
            this.Controls.Add(this.bBishop2);
            this.Controls.Add(this.bKing);
            this.Controls.Add(this.bQueen);
            this.Controls.Add(this.bBishop1);
            this.Controls.Add(this.bKnight1);
            this.Controls.Add(this.bRook1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bRook1;
        private System.Windows.Forms.Button bKnight1;
        private System.Windows.Forms.Button bBishop1;
        private System.Windows.Forms.Button bQueen;
        private System.Windows.Forms.Button bKing;
        private System.Windows.Forms.Button bBishop2;
        private System.Windows.Forms.Button bKnight2;
        private System.Windows.Forms.Button bRook2;
        private System.Windows.Forms.Button wRook2;
        private System.Windows.Forms.Button wKnight2;
        private System.Windows.Forms.Button wBishop2;
        private System.Windows.Forms.Button wKing;
        private System.Windows.Forms.Button wQueen;
        private System.Windows.Forms.Button wBishop1;
        private System.Windows.Forms.Button wKnight1;
        private System.Windows.Forms.Button wRook1;
        private System.Windows.Forms.Button wPawn8;
        private System.Windows.Forms.Button wPawn7;
        private System.Windows.Forms.Button wPawn6;
        private System.Windows.Forms.Button wPawn5;
        private System.Windows.Forms.Button wPawn4;
        private System.Windows.Forms.Button wPawn3;
        private System.Windows.Forms.Button wPawn2;
        private System.Windows.Forms.Button wPawn1;
        private System.Windows.Forms.Button bPawn8;
        private System.Windows.Forms.Button bPawn7;
        private System.Windows.Forms.Button bPawn6;
        private System.Windows.Forms.Button bPawn5;
        private System.Windows.Forms.Button bPawn4;
        private System.Windows.Forms.Button bPawn3;
        private System.Windows.Forms.Button bPawn2;
        private System.Windows.Forms.Button bPawn1;
        private System.Windows.Forms.Label bTime;
        private System.Windows.Forms.Label wTime;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label debugLabel;
    }
}

