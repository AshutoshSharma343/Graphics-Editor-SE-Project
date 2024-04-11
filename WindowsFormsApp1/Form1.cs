using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl = "http://localhost:5000";
        public Form1()
        {
            InitializeComponent();
            // Initialize the HttpClient
            httpClient = new HttpClient();


            pictureBox.MouseDown += PictureBoxMouseDown;
            pictureBox.MouseMove += PictureBoxMouseMove;
            pictureBox.MouseUp += PictureBoxMouseUp;
            btn_pencil.Click += PencilButtonClick;

            this.Width = 940;
            this.Height = 800;
            bm = new Bitmap(pictureBox.Width, pictureBox.Height);
            //allows you to perform drawing operations on the image using the Graphics object.
            //to do drawing we need a drawing surface --> bitmap
            //using Graphics .FromImage we get a graphics object to perform drawing operations on bm.
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
           
            pictureBox.Image = bm;
            //i can change the backcolor of pictureBox, if the g.Clear(Color.Black); is not active.
            //pictureBox.BackColor = Color.Yellow;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen Pn = new Pen(Color.Black, 1);
        Pen Er = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        
        //This metod is used to create the visual creation of objects
        //Paint EVENTS
        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if(paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(Pn, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(Pn, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(Pn, cX, cY, x, y);
                }
            }
        }

        private void validate(Bitmap bm, Stack<Point> sp,int x, int y,Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        
        public void Fill(Bitmap bm,int x,int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if(old_color == new_clr)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if(pt.X > 0 && pt.X < bm.Width -1 && pt.Y > 0 && pt.Y < bm.Height-1)
                {
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                }

            }


        }
        //if the user clicks on the picture canvas then set the paint bool value as true 
        //& assign the click point to pY

        //MOUSE EVENTS--->
        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            //storing the current mouse position in pY
            py = e.Location;
            
            //for drawing an ellipse
            cX= e.X;
            cY = e.Y;
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(Pn, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(Er, px, py);
                    py = px;
                }
            }
            pictureBox.Refresh();

            x = e.X;
            y = e.Y;
            sX = x - cX;
            sY = y - cY;
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            //means that the drwaing is completed
            paint = false;

            sX = e.X - cX;
            sY = e.Y - cY;

            if (index == 3)
            {
                //cx,cy are the coordinates of the top left corner of the bounding rectangle
                //sx,sy are the width and height of the bounding rectangle
                g.DrawEllipse(Pn, cX, cY, sX, sY);
            }

            if(index == 4)
            {
                g.DrawRectangle(Pn, cX, cY, sX, sY);
            }

            if(index == 5)
            {
                g.DrawLine(Pn, cX, cY, e.X, e.Y);
            }

        }

        //CLICK EVENTS
        //on click of the pencil button set the index value as 1
        private void PencilButtonClick(object sender, EventArgs e)
        {
            index = 1;
        }
        private void Btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void Btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void Btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void Btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox.Refresh();
            pictureBox.Image = bm;
            //i.e no button is selected
            index = 0;
        }

        private Point Set_Point(PictureBox pb ,Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;

            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));

        }

        private void Color_picker_mouse_click(object sender, MouseEventArgs e)
        {
            Point point = Set_Point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            Pn.Color = new_color;
        }

        private void PictureBox_Mouse_Click(object sender, MouseEventArgs e)
        {
            if(index == 6)
            {
                Point point = Set_Point(pictureBox, e.Location);
                Fill(bm, point.X, point.Y, new_color);
                pictureBox.Refresh();
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Get text entered by the user
                string userInput = textBox1.Text;

                // Create JSON content with the user input
                var jsonContent = new StringContent(
                    $"{{ \"content\": \"{userInput}\" }}",
                    System.Text.Encoding.UTF8,
                    "application/json"
                );

                // Make POST request to Flask API endpoint
                HttpResponseMessage response = await httpClient.PostAsync(baseUrl + "/prompt", jsonContent);

                // Check if request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read response content
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Format the response with proper spacing and line breaks
                    string formattedText = FormatText(responseBody);

                    // Assign the formatted text to textBox2
                    textBox2.Text = formattedText;
                }
                else
                {
                    // Display error message if request failed
                    textBox2.Text = $"Failed to Get the Prompt: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                // Display exception message if an error occurred
                textBox2.Text = $"An error occurred: {ex.Message}";
            }

       }

        private string FormatText(string text)
        {
            // Replace periods with periods followed by a line break
            return text.Replace(".", ".\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of HttpClient when the form is closing
            httpClient.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            //if color btn is pressed then open the color dialog box
            //and set the selected color as the new_color,pen ,  ...etc
            cd.ShowDialog();
            new_color = cd.Color;
            //pictureBox.BackColor = new_color;
            Pn.Color = new_color;
            pic_color.BackColor = new_color;
        }

        //if save btn is clicked then open the saveFileDialog to save img

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Bitmap Image|*.bmp|JPEG Image|*.jpg|PNG Image|*.png|All Files|*.*";
            saveDialog.Title = "Save an Image File";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file name and extension chosen by the user
                string fileName = saveDialog.FileName;

                Bitmap savedImage = new Bitmap(pictureBox.Width, pictureBox.Height);

                Graphics savedGraphics = Graphics.FromImage(savedImage);
                // Draw the content of the PictureBox onto the new bitmap
                savedGraphics.DrawImage(pictureBox.Image, Point.Empty);

                // Save the new bitmap to the specified file
                savedImage.Save(fileName);

                // Dispose of the Graphics objects
                savedGraphics.Dispose();

                pictureBox.Image.Save(fileName);

                MessageBox.Show("Image saved successfully!", "Save Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //MOUSE HOVER EVENTS.
        private void Clear_Button_Mouse_Enter(object sender, EventArgs e)
        {
            Clear_Button.BackColor = Color.Black;
            Clear_Button.ForeColor = Color.Green;
        }

        private void Clear_Button_Mouse_Leave(object sender, EventArgs e)
        {
            // Revert to the original appearance when the mouse leaves
            Clear_Button.BackColor = Color.Red;
            Clear_Button.ForeColor = Color.Black;
        }
        private void Save_Button_Mouse_Enter(object sender, EventArgs e)
        {
            Save_Button.BackColor = Color.Black;
            Save_Button.ForeColor = Color.Green;
        }

        private void Save_Button_Mouse_Leave(object sender, EventArgs e)
        {
            Save_Button.BackColor = Color.LimeGreen;
            Save_Button.ForeColor = Color.Black;
        }
    }
}
