namespace WindowsFormsApp1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1279);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3076, 10);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 300);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(3076, 979);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Mouse_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Controls.Add(this.btn_eraser);
            this.panel3.Controls.Add(this.btn_ellipse);
            this.panel3.Controls.Add(this.btn_rect);
            this.panel3.Controls.Add(this.btn_fill);
            this.panel3.Controls.Add(this.btn_pencil);
            this.panel3.Controls.Add(this.btn_line);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(809, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 200);
            this.panel3.TabIndex = 3;
            // 
            // btn_eraser
            // 
            this.btn_eraser.AutoSize = true;
            this.btn_eraser.BackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Image = global::WindowsFormsApp1.Properties.Resources.eraser;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eraser.Location = new System.Drawing.Point(525, 21);
            this.btn_eraser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(145, 160);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.Btn_eraser_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.AutoSize = true;
            this.btn_ellipse.BackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::WindowsFormsApp1.Properties.Resources.circle;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(698, 23);
            this.btn_ellipse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(145, 160);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.Btn_ellipse_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.AutoSize = true;
            this.btn_rect.BackColor = System.Drawing.Color.Maroon;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::WindowsFormsApp1.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(870, 26);
            this.btn_rect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(145, 160);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.Btn_rect_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.AutoSize = true;
            this.btn_fill.BackColor = System.Drawing.Color.Maroon;
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = global::WindowsFormsApp1.Properties.Resources.bucket;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fill.Location = new System.Drawing.Point(184, 21);
            this.btn_fill.Margin = new System.Windows.Forms.Padding(2);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(145, 160);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = false;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.AutoSize = true;
            this.btn_pencil.BackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Image = global::WindowsFormsApp1.Properties.Resources.pencil;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pencil.Location = new System.Drawing.Point(352, 21);
            this.btn_pencil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(145, 160);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            // 
            // btn_line
            // 
            this.btn_line.AutoSize = true;
            this.btn_line.BackColor = System.Drawing.Color.Maroon;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::WindowsFormsApp1.Properties.Resources.line;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(1045, 26);
            this.btn_line.Margin = new System.Windows.Forms.Padding(2);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(145, 160);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.Btn_line_Click);
            // 
            // btn_color
            // 
            this.btn_color.AutoSize = true;
            this.btn_color.BackColor = System.Drawing.Color.Maroon;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Image = global::WindowsFormsApp1.Properties.Resources.color;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_color.Location = new System.Drawing.Point(18, 21);
            this.btn_color.Margin = new System.Windows.Forms.Padding(2);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(145, 160);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_color.Location = new System.Drawing.Point(634, 60);
            this.pic_color.Margin = new System.Windows.Forms.Padding(2);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(152, 117);
            this.pic_color.TabIndex = 0;
            this.pic_color.Text = "Selected Color";
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::WindowsFormsApp1.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(28, 11);
            this.color_picker.Margin = new System.Windows.Forms.Padding(2);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(588, 248);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_picker_mouse_click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.Red;
            this.Clear_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.Location = new System.Drawing.Point(2038, 145);
            this.Clear_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(175, 75);
            this.Clear_Button.TabIndex = 4;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Button_Clear_Click);
            this.Clear_Button.MouseEnter += new System.EventHandler(this.Clear_Button_Mouse_Enter);
            this.Clear_Button.MouseLeave += new System.EventHandler(this.Clear_Button_Mouse_Leave);
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.Color.LimeGreen;
            this.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Button.Location = new System.Drawing.Point(2038, 44);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(175, 75);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            this.Save_Button.MouseEnter += new System.EventHandler(this.Save_Button_Mouse_Enter);
            this.Save_Button.MouseLeave += new System.EventHandler(this.Save_Button_Mouse_Leave);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Save_Button);
            this.panel1.Controls.Add(this.Clear_Button);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3076, 300);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2903, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 75);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(2903, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 75);
            this.button2.TabIndex = 8;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(2229, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(631, 225);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(2395, 300);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(735, 1150);
            this.textBox2.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3076, 1289);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphicsEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

