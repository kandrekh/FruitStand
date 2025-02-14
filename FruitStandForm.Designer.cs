namespace FruitStand
{
    partial class FruitStandForm
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
            banana_img = new PictureBox();
            apple_img = new PictureBox();
            pear_img = new PictureBox();
            orange_img = new PictureBox();
            total_label = new Label();
            reset_btn = new Button();
            exit_btn = new Button();
            total_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)banana_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)apple_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pear_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orange_img).BeginInit();
            SuspendLayout();
            // 
            // banana_img
            // 
            banana_img.Image = Properties.Resources.BananaPrice;
            banana_img.Location = new Point(12, 12);
            banana_img.Name = "banana_img";
            banana_img.Size = new Size(129, 156);
            banana_img.SizeMode = PictureBoxSizeMode.AutoSize;
            banana_img.TabIndex = 0;
            banana_img.TabStop = false;
            banana_img.Click += banana_img_Click;
            // 
            // apple_img
            // 
            apple_img.Image = Properties.Resources.ApplePrice;
            apple_img.Location = new Point(147, 12);
            apple_img.Name = "apple_img";
            apple_img.Size = new Size(129, 156);
            apple_img.SizeMode = PictureBoxSizeMode.AutoSize;
            apple_img.TabIndex = 1;
            apple_img.TabStop = false;
            apple_img.Click += apple_img_Click;
            // 
            // pear_img
            // 
            pear_img.Image = Properties.Resources.PearPrice;
            pear_img.Location = new Point(147, 174);
            pear_img.Name = "pear_img";
            pear_img.Size = new Size(129, 156);
            pear_img.SizeMode = PictureBoxSizeMode.AutoSize;
            pear_img.TabIndex = 3;
            pear_img.TabStop = false;
            pear_img.Click += pear_img_Click;
            // 
            // orange_img
            // 
            orange_img.Image = Properties.Resources.OrangePrice;
            orange_img.Location = new Point(12, 174);
            orange_img.Name = "orange_img";
            orange_img.Size = new Size(129, 156);
            orange_img.SizeMode = PictureBoxSizeMode.AutoSize;
            orange_img.TabIndex = 2;
            orange_img.TabStop = false;
            orange_img.Click += orange_img_Click;
            // 
            // total_label
            // 
            total_label.AutoSize = true;
            total_label.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            total_label.Location = new Point(306, 14);
            total_label.Name = "total_label";
            total_label.Size = new Size(44, 20);
            total_label.TabIndex = 4;
            total_label.Text = "Total";
            // 
            // reset_btn
            // 
            reset_btn.FlatAppearance.BorderColor = Color.Gainsboro;
            reset_btn.FlatAppearance.BorderSize = 2;
            reset_btn.FlatStyle = FlatStyle.Flat;
            reset_btn.Location = new Point(293, 249);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(75, 30);
            reset_btn.TabIndex = 6;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.FlatAppearance.BorderColor = Color.DodgerBlue;
            exit_btn.FlatAppearance.BorderSize = 2;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Location = new Point(293, 285);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(75, 30);
            exit_btn.TabIndex = 7;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // total_txt
            // 
            total_txt.BorderStyle = BorderStyle.FixedSingle;
            total_txt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            total_txt.Location = new Point(293, 37);
            total_txt.Name = "total_txt";
            total_txt.ReadOnly = true;
            total_txt.Size = new Size(75, 23);
            total_txt.TabIndex = 8;
            total_txt.Text = "$0.00";
            total_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // FruitStandForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(381, 349);
            Controls.Add(total_txt);
            Controls.Add(exit_btn);
            Controls.Add(reset_btn);
            Controls.Add(total_label);
            Controls.Add(pear_img);
            Controls.Add(orange_img);
            Controls.Add(apple_img);
            Controls.Add(banana_img);
            Name = "FruitStandForm";
            Text = "Fruit Stand";
            ((System.ComponentModel.ISupportInitialize)banana_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)apple_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pear_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)orange_img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox banana_img;
        private PictureBox apple_img;
        private PictureBox pear_img;
        private PictureBox orange_img;
        private Label total_label;
        private Button reset_btn;
        private Button exit_btn;
        public TextBox total_txt;
    }
}
