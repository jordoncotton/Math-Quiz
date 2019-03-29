namespace Math_Quiz
{
    partial class MathQuiz
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.Symbol = new System.Windows.Forms.PictureBox();
            this.equal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Symbol)).BeginInit();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(37, 46);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(65, 25);
            this.num1.TabIndex = 0;
            this.num1.Text = "num1";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(328, 46);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(65, 25);
            this.num2.TabIndex = 1;
            this.num2.Text = "num2";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(568, 46);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(53, 25);
            this.total.TabIndex = 2;
            this.total.Text = "total";
            // 
            // Symbol
            // 
            this.Symbol.Image = global::Math_Quiz.Properties.Resources.qq;
            this.Symbol.Location = new System.Drawing.Point(178, 29);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(62, 42);
            this.Symbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Symbol.TabIndex = 3;
            this.Symbol.TabStop = false;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(477, 46);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(24, 25);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press P for plus, M for minus, X for multiply and D for divide";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(549, 133);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(65, 25);
            this.score.TabIndex = 6;
            this.score.Text = "score";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(71, 179);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(134, 46);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(368, 179);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(133, 46);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // MathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 237);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.total);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "MathQuiz";
            this.Text = "MathQuiz";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyisDown);
            ((System.ComponentModel.ISupportInitialize)(this.Symbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.PictureBox Symbol;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

