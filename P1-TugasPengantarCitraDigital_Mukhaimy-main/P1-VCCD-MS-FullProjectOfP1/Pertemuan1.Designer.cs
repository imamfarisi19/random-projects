namespace P1_VCCD_MS_FullProjectOfP1
{
   partial class Pertemuan1
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
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.button5 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(12, 12);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "Open";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(93, 12);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "Save";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Location = new System.Drawing.Point(12, 39);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(265, 269);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // saveFileDialog1
         // 
         this.saveFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif|All files|*.*";
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.Filter = "JPG|*.jpg|BMP|*.bmp|PNG|*.png|GIF|*.gif|All files|*.*";
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(174, 13);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 3;
         this.button3.Text = "GrayScale";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(255, 12);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(75, 23);
         this.button4.TabIndex = 4;
         this.button4.Text = "Invert";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // pictureBox2
         // 
         this.pictureBox2.Location = new System.Drawing.Point(285, 39);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(265, 269);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox2.TabIndex = 5;
         this.pictureBox2.TabStop = false;
         // 
         // button5
         // 
         this.button5.Location = new System.Drawing.Point(336, 12);
         this.button5.Name = "button5";
         this.button5.Size = new System.Drawing.Size(214, 23);
         this.button5.TabIndex = 6;
         this.button5.Text = "Left GrayScale and Right Invert";
         this.button5.UseVisualStyleBackColor = true;
         this.button5.Click += new System.EventHandler(this.button5_Click);
         // 
         // Pertemuan1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(562, 320);
         this.Controls.Add(this.button5);
         this.Controls.Add(this.pictureBox2);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.pictureBox1);
         this.Name = "Pertemuan1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Pertemuan 1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.SaveFileDialog saveFileDialog1;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.Button button5;
   }
}

