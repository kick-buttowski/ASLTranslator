using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASLTranslator
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse
        );

        List<PictureBox> disposePb = new List<PictureBox>();
        List<Label> specialSign = new List<Label>();
        public MainForm()
        {
            InitializeComponent();
            formalAndInformalGreetings.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, formalAndInformalGreetings.Width, formalAndInformalGreetings.Height, 12, 12));
            formalAndInformalFarewell.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, formalAndInformalFarewell.Width, formalAndInformalFarewell.Height, 12, 12));
            historyOfTranslation.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, historyOfTranslation.Width, historyOfTranslation.Height, 12, 12));
            flowLayoutPanel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel2.Width, flowLayoutPanel2.Height, 12, 12));
            transTextBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, transTextBox.Width, transTextBox.Height, 12, 12));
            addNewBoxBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, addNewBoxBtn.Width, addNewBoxBtn.Height, 5, 5));
            button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 5, 5));
            button2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 5, 5));
            button3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 5, 5));
            clearBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, clearBtn.Width, clearBtn.Height, 5, 5));
            translateBtn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, translateBtn.Width, translateBtn.Height, 5, 5));
            flowLayoutPanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height, 12, 12));
            grammarBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, grammarBox.Width, grammarBox.Height, 12, 12));

        }

        private void compatibleWordsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transTextBox.Text = transTextBox.Text + (transTextBox.Text == ""?"":" ") + formalAndInformalGreetings.SelectedItem.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            transTextBox.Text = "";
            clearAndDispose();
        }

        private void historyOfTranslation_SelectedIndexChanged(object sender, EventArgs e)
        {
            transTextBox.Text = historyOfTranslation.SelectedItem.ToString();
        }

        private void formalAndInformalFarewell_SelectedIndexChanged(object sender, EventArgs e)
        {
            transTextBox.Text = transTextBox.Text + (transTextBox.Text == "" ? "" : " ") + formalAndInformalFarewell.SelectedItem.ToString();
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            if (transTextBox.Text.Trim().Length == 0)
                return;

            clearAndDispose();

            foreach (Char c in transTextBox.Text.ToUpper()){
                if ((int)c >= 65 && (int)c <= 90)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = getRelImage(c);
                    pb.Margin = new Padding(0);
                    pb.Size = new Size(30 + (zoomTrack.Value - 50) / 2, 40 + (zoomTrack.Value - 50) / 2);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;

                    flowLayoutPanel2.Controls.Add(pb);
                    disposePb.Add(pb);
                }
                else
                {
                    if(c == ' ')
                    {
                        Label lbl = new Label();
                        lbl.Size = new Size(20 + (zoomTrack.Value - 50) / 2, 40 + (zoomTrack.Value - 50) / 2);
                        lbl.Text = "";
                        flowLayoutPanel2.Controls.Add(lbl);
                        specialSign.Add(lbl);
                    }
                    else
                    {
                        Label lbl = new Label();
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Font = new Font("Ariel", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lbl.Size = new Size(20 + (zoomTrack.Value - 50) / 2, 40 + (zoomTrack.Value - 50) / 2);
                        lbl.Text = c.ToString();
                        flowLayoutPanel2.Controls.Add(lbl);
                        specialSign.Add(lbl);
                    }
                }
            }

            Boolean isPresent = false;
            foreach(string s in historyOfTranslation.Items)
            {
                if (s.Equals(transTextBox.Text)) { 
                    isPresent = true;
                }
            }
            if(!isPresent) this.historyOfTranslation.Items.AddRange(new object[] {transTextBox.Text});
        }

        private void clearAndDispose()
        {
            flowLayoutPanel2.Controls.Clear();
            foreach (PictureBox pb in disposePb)
            {
                try
                {
                    pb.Dispose();
                    GC.Collect();
                }
                catch { }
            }
            disposePb.Clear();
        }

        private Image getRelImage(char c)
        {
            switch (c)
            {
                case 'A':
                    return global::ASLTranslator.Properties.Resources.A;
                case 'B':
                    return global::ASLTranslator.Properties.Resources.B;
                case 'C':
                    return global::ASLTranslator.Properties.Resources.C;
                case 'D':
                    return global::ASLTranslator.Properties.Resources.D;
                case 'E':
                    return global::ASLTranslator.Properties.Resources.E;
                case 'F':
                    return global::ASLTranslator.Properties.Resources.F;
                case 'G':
                    return global::ASLTranslator.Properties.Resources.G;
                case 'H':
                    return global::ASLTranslator.Properties.Resources.H;
                case 'I':
                    return global::ASLTranslator.Properties.Resources.I;
                case 'J':
                    return global::ASLTranslator.Properties.Resources.J;
                case 'K':
                    return global::ASLTranslator.Properties.Resources.K;
                case 'L':
                    return global::ASLTranslator.Properties.Resources.L;
                case 'M':
                    return global::ASLTranslator.Properties.Resources.M;
                case 'N':
                    return global::ASLTranslator.Properties.Resources.N;
                case 'O':
                    return global::ASLTranslator.Properties.Resources.O;
                case 'P':
                    return global::ASLTranslator.Properties.Resources.P;
                case 'Q':
                    return global::ASLTranslator.Properties.Resources.Q;
                case 'R':
                    return global::ASLTranslator.Properties.Resources.R;
                case 'S':
                    return global::ASLTranslator.Properties.Resources.S;
                case 'T':
                    return global::ASLTranslator.Properties.Resources.T;
                case 'U':
                    return global::ASLTranslator.Properties.Resources.U;
                case 'V':
                    return global::ASLTranslator.Properties.Resources.V;
                case 'W':
                    return global::ASLTranslator.Properties.Resources.W;
                case 'X':
                    return global::ASLTranslator.Properties.Resources.X;
                case 'Y':
                    return global::ASLTranslator.Properties.Resources.Y;
                case 'Z':
                    return global::ASLTranslator.Properties.Resources.Z;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formalAndInformalGreetings.Sorted = !formalAndInformalGreetings.Sorted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formalAndInformalFarewell.Sorted = !formalAndInformalFarewell.Sorted;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grammarBox.Sorted = !grammarBox.Sorted;
        }

        private void grammarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            transTextBox.Text = transTextBox.Text + (transTextBox.Text == "" ? "" : " ") + grammarBox.SelectedItem.ToString();
        }

        private void zoomTrack_Scroll(object sender, EventArgs e)
        {
            if (zoomTrack.Value >= 100 || zoomTrack.Value <= 0)
                return;
            foreach (PictureBox pb in disposePb)
            {
                try
                {
                    pb.Size = new Size(30 + (zoomTrack.Value - 50)/2, 40 + (zoomTrack.Value - 50) / 2);
                }
                catch { }
            }
            foreach (Label lbl in specialSign)
            {
                try
                {
                    lbl.Size = new Size(25 + (zoomTrack.Value - 50) / 2, 40 + (zoomTrack.Value - 50) / 2);
                }
                catch { }
            }
        }
    }
}
