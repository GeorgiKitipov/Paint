using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pain_Version_0._3
{
    public partial class Paint : Form
    {
        string path;
        Point current = new Point();
        Point old = new Point();
        Pen pen = new Pen(Color.Black, 5);
        Pen guma = new Pen(Color.White, 5);
        Graphics g;
        Bitmap surface;
        Graphics graph;
        string s = "Picture";
        int i = 1;
        SolidBrush sb = new SolidBrush(Color.Black);
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        bool startPaint = false;

        public Paint()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            surface = new Bitmap(panel1.Width, panel1.Height);
            graph = Graphics.FromImage(surface);
            panel1.BackgroundImage = surface;
            panel1.BackgroundImageLayout = ImageLayout.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            panel1.Cursor = Cursors.Cross;

            startPaint = true;
            if (drawSquare)
            {
                graph.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                graph.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                graph.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           if(e.Button == MouseButtons.Left)
            {
                current = e.Location;
                graph.DrawLine(pen, old, current );
                old = current;
                panel1.Invalidate();
            }
            if (e.Button == MouseButtons.Right)
            {
                current = e.Location;
                graph.DrawLine(guma, old, current);
                old = current;
                panel1.Invalidate();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                pen.Color = cd.Color;
                sb.Color = cd.Color;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pen = new Pen(Color.Black, 1);
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pen = new Pen(Color.Black, 2);
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pen = new Pen(Color.Black, 3);
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pen = new Pen(Color.Black, 4);
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                pen = new Pen(Color.Black, 5);
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                pen = new Pen(Color.Black, 10);
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                guma = new Pen(Color.White, 2);

            }
            if (comboBox2.SelectedIndex == 1)
            {
                guma = new Pen(Color.White, 7);

            }
            if (comboBox2.SelectedIndex == 2)
            {
                guma = new Pen(Color.White, 17);

            }
            if (comboBox2.SelectedIndex == 3)
            {
                guma = new Pen(Color.White, 20);

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            guma = new Pen(Color.White, 5);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            graph.Clear(Color.White);
            Refresh();
            
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JEPG Document|*.Jpeg", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            s = sfd.FileName;
                            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                            {
                                await sw.WriteLineAsync(s);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path))
                    {
                        await sw.WriteLineAsync(panel1.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            surface.Save(s);
            s += i;
            i++;
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JEPG Document|*.Jpeg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName))
                        {
                            s = ofd.FileName;
                            Task<string> text = sr.ReadToEndAsync();
                            
                             

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void saveUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JEPG Document|*.Jpeg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        s = sfd.FileName;
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName))
                        {
                            
                            await sw.WriteLineAsync(s);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            surface.Save(s);
            s += i;
            i++;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openOldProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OldProject frm = new OldProject())
            {
                frm.ShowDialog();
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.CadetBlue;
            pictureBox3.Cursor = Cursors.Hand;

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Gray;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Gray;
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 28);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                pen = new Pen(Color.Black, 15);
                
            }
            if (comboBox3.SelectedIndex == 1)
            {
                pen = new Pen(Color.Black, 20);
            }
        }

        private void Brush_MouseHover(object sender, EventArgs e)
        {
            Brush.BackColor = Color.CadetBlue;
            Brush.Cursor = Cursors.Hand;
        }

        private void Brush_MouseLeave(object sender, EventArgs e)
        {
            Brush.BackColor = Color.Gray;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }
    }
}
