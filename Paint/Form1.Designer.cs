namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.bnt_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.bnt_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 661);
            this.panel1.TabIndex = 0;
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(3, 157);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(155, 47);
            this.pic_color.TabIndex = 3;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(161, 645);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 16);
            this.panel2.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(3, 579);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(152, 33);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(3, 618);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(152, 31);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // color_picker
            // 
            this.color_picker.Image = global::Paint.Properties.Resources.Color_pic;
            this.color_picker.Location = new System.Drawing.Point(0, 0);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(158, 151);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 13;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_color.BackgroundImage = global::Paint.Properties.Resources.color;
            this.btn_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_color.Location = new System.Drawing.Point(3, 286);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(70, 70);
            this.btn_color.TabIndex = 4;
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fill.BackgroundImage = global::Paint.Properties.Resources.fill;
            this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fill.Location = new System.Drawing.Point(88, 286);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(70, 70);
            this.btn_fill.TabIndex = 5;
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // bnt_pencil
            // 
            this.bnt_pencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnt_pencil.BackgroundImage = global::Paint.Properties.Resources.pencil;
            this.bnt_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.bnt_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.bnt_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_pencil.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnt_pencil.ForeColor = System.Drawing.Color.White;
            this.bnt_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnt_pencil.Location = new System.Drawing.Point(3, 210);
            this.bnt_pencil.Name = "bnt_pencil";
            this.bnt_pencil.Size = new System.Drawing.Size(70, 70);
            this.bnt_pencil.TabIndex = 6;
            this.bnt_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt_pencil.UseVisualStyleBackColor = false;
            this.bnt_pencil.Click += new System.EventHandler(this.bnt_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eraser.BackgroundImage = global::Paint.Properties.Resources.eraser;
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eraser.Location = new System.Drawing.Point(88, 210);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(70, 70);
            this.btn_eraser.TabIndex = 7;
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ellipse.BackgroundImage = global::Paint.Properties.Resources.ellipse;
            this.btn_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ellipse.Location = new System.Drawing.Point(88, 362);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(70, 70);
            this.btn_ellipse.TabIndex = 8;
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_rect.BackgroundImage = global::Paint.Properties.Resources.rectangular;
            this.btn_rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rect.Location = new System.Drawing.Point(3, 362);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(70, 70);
            this.btn_rect.TabIndex = 9;
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_line.BackgroundImage = global::Paint.Properties.Resources.line;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_line.Location = new System.Drawing.Point(3, 438);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(70, 70);
            this.btn_line.TabIndex = 10;
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(884, 661);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(161, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 16);
            this.panel3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button bnt_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Panel panel3;
    }
}

