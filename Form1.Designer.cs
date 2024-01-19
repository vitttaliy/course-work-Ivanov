namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.apple = new System.Windows.Forms.PictureBox();
            this.banana = new System.Windows.Forms.PictureBox();
            this.grape = new System.Windows.Forms.PictureBox();
            this.orange = new System.Windows.Forms.PictureBox();
            this.plum = new System.Windows.Forms.PictureBox();
            this.watermelon = new System.Windows.Forms.PictureBox();
            this.mainpicture = new System.Windows.Forms.PictureBox();
            this.startlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watermelon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // apple
            // 
            this.apple.Image = global::Project.Properties.Resources.apple;
            this.apple.Location = new System.Drawing.Point(15, 240);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(120, 120);
            this.apple.TabIndex = 1;
            this.apple.TabStop = false;
            this.apple.Click += new System.EventHandler(this.apple_Click);
            // 
            // banana
            // 
            this.banana.Image = global::Project.Properties.Resources.banana;
            this.banana.Location = new System.Drawing.Point(141, 240);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(120, 120);
            this.banana.TabIndex = 2;
            this.banana.TabStop = false;
            this.banana.Click += new System.EventHandler(this.banana_Click);
            // 
            // grape
            // 
            this.grape.Image = global::Project.Properties.Resources.grape;
            this.grape.Location = new System.Drawing.Point(267, 240);
            this.grape.Name = "grape";
            this.grape.Size = new System.Drawing.Size(120, 120);
            this.grape.TabIndex = 3;
            this.grape.TabStop = false;
            this.grape.Click += new System.EventHandler(this.grape_Click);
            // 
            // orange
            // 
            this.orange.Image = global::Project.Properties.Resources.orange;
            this.orange.Location = new System.Drawing.Point(393, 240);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(120, 120);
            this.orange.TabIndex = 4;
            this.orange.TabStop = false;
            this.orange.Click += new System.EventHandler(this.orange_Click);
            // 
            // plum
            // 
            this.plum.Image = global::Project.Properties.Resources.plum;
            this.plum.Location = new System.Drawing.Point(520, 240);
            this.plum.Name = "plum";
            this.plum.Size = new System.Drawing.Size(120, 120);
            this.plum.TabIndex = 5;
            this.plum.TabStop = false;
            this.plum.Click += new System.EventHandler(this.plum_Click);
            // 
            // watermelon
            // 
            this.watermelon.Image = global::Project.Properties.Resources.watermelon;
            this.watermelon.Location = new System.Drawing.Point(650, 240);
            this.watermelon.Name = "watermelon";
            this.watermelon.Size = new System.Drawing.Size(120, 120);
            this.watermelon.TabIndex = 6;
            this.watermelon.TabStop = false;
            this.watermelon.Click += new System.EventHandler(this.watermelon_Click);
            // 
            // mainpicture
            // 
            this.mainpicture.Image = global::Project.Properties.Resources.apple;
            this.mainpicture.Location = new System.Drawing.Point(340, 70);
            this.mainpicture.Name = "mainpicture";
            this.mainpicture.Size = new System.Drawing.Size(120, 120);
            this.mainpicture.TabIndex = 8;
            this.mainpicture.TabStop = false;
            this.mainpicture.Visible = false;
            // 
            // startlabel
            // 
            this.startlabel.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startlabel.Location = new System.Drawing.Point(15, 70);
            this.startlabel.Margin = new System.Windows.Forms.Padding(0);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(755, 120);
            this.startlabel.TabIndex = 9;
            this.startlabel.Text = "PLAY";
            this.startlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startlabel.Click += new System.EventHandler(this.startlabel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 403);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 469);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 53);
            this.label2.TabIndex = 11;
            this.label2.Text = "Best score:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(215, 403);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 53);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(215, 469);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 53);
            this.label4.TabIndex = 13;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(204, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 54);
            this.label5.TabIndex = 14;
            this.label5.Text = "Іванов Віталій КН-22";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.mainpicture);
            this.Controls.Add(this.watermelon);
            this.Controls.Add(this.plum);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.grape);
            this.Controls.Add(this.banana);
            this.Controls.Add(this.apple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watermelon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox apple;
        private System.Windows.Forms.PictureBox banana;
        private System.Windows.Forms.PictureBox grape;
        private System.Windows.Forms.PictureBox orange;
        private System.Windows.Forms.PictureBox plum;
        private System.Windows.Forms.PictureBox watermelon;
        private System.Windows.Forms.PictureBox mainpicture;
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

