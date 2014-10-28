using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using Jackie_s_WordList;
using System.Diagnostics;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing.Layout;
using WeifenLuo.WinFormsUI.Docking;

namespace Jackie_Wordmaker
{
    public partial class Export : Form
    {
        CurrencyManager cm;

        public Export()
        {
            InitializeComponent();

            lstWords.DataSource = Editor.Instance.CurrentList.MiniList;
            lstWords.DisplayMember = "Name";

            cm = (CurrencyManager)BindingContext[Editor.Instance.CurrentList.MiniList];

            UpdateList();

            txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Jackie's WordMaker\";
        }

        public void UpdateList()
        {
            cm.Refresh();
        }

        private void buttExport_Click(object sender, EventArgs e)
        {
            List<Word> word2Print = new List<Word>();

            if (chkAll.Checked == true)
            {
                foreach (Word w in Editor.Instance.CurrentList.MyList)
                {
                    word2Print.Add(w);
                }

            }
            else if (chkSpec.Checked == true)
            {
                foreach (Word w in Editor.Instance.CurrentList.MiniList[lstWords.SelectedIndex].MyList)
                {
                    word2Print.Add(w);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtWords.Text))
                {
                    MessageBox.Show(@"You must enter a number", @"Error");
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                int max = int.Parse(txtWords.Text);

                if (max > Editor.Instance.CurrentList.MyList.Count)
                    max = Editor.Instance.CurrentList.MyList.Count;

                Random r = new Random();
                List<int> intList = new List<int>();

                for (int i = 0; i < max; i++)
                {
                    int rand = r.Next(Editor.Instance.CurrentList.MyList.Count);
                    while (intList.IndexOf(rand) != -1)
                    {
                        rand = r.Next(Editor.Instance.CurrentList.MyList.Count);
                    }
                    intList.Add(rand);
                }

                foreach (int i in intList)
                {
                    word2Print.Add(Editor.Instance.CurrentList.MyList[i]);
                }

                
            }

            int totalword = word2Print.Count;
            int count = 0;
            int pageat = 0;
                       
            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            List<PdfPage> page = new List<PdfPage>();
            page.Add(new PdfPage());
            page.Add(new PdfPage());

            page[pageat] = document.AddPage();
            pageat++;
            page[pageat] = document.AddPage();
            pageat--;

            // Create an empty page
            //PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page[pageat]);

            // Create a font
            XFont font = new XFont("Verdana", 8, XFontStyle.BoldItalic);
            XTextFormatter tf = new XTextFormatter(gfx);

            // Draw the text

            for (int i = 0; i < totalword; i++)
            {
                if (count > 15)
                {
                    count = 0;
                    page.Add(new PdfPage());
                    page.Add(new PdfPage());
                    pageat += 2;
                    page[pageat] = document.AddPage();
                    pageat++;
                    page[pageat] = document.AddPage();
                    pageat--;
                    gfx = XGraphics.FromPdfPage(page[pageat]);
                    tf = new XTextFormatter(gfx);
                }

                tf.Alignment = XParagraphAlignment.Center;

                if (count < 4)
                {
                    tf.DrawString(word2Print[i].Name, font, XBrushes.Black, new XRect(page[pageat].Width / 4 * count, 0, page[pageat].Width / 4, page[pageat].Height / 4), XStringFormats.TopLeft);
                }
                else if (count > 3 && count < 8)
                {
                    tf.DrawString(word2Print[i].Name, font, XBrushes.Black, new XRect(page[pageat].Width / 4 * (count - 4), page[pageat].Height / 4, page[pageat].Width / 4, page[pageat].Height / 4), XStringFormats.TopLeft);
                }
                else if (count > 7 && count < 12)
                {
                    tf.DrawString(word2Print[i].Name, font, XBrushes.Black, new XRect(page[pageat].Width / 4 * (count - 8), page[pageat].Height / 4 * 2, page[pageat].Width / 4, page[pageat].Height / 4), XStringFormats.TopLeft);
                }
                else
                {
                    tf.DrawString(word2Print[i].Name, font, XBrushes.Black, new XRect(page[pageat].Width / 4 * (count - 12), page[pageat].Height / 4 * 3, page[pageat].Width / 4, page[pageat].Height / 4), XStringFormats.TopLeft);
                }

                pageat++;
                gfx.Dispose();
                
                gfx = XGraphics.FromPdfPage(page[pageat]);
                tf = new XTextFormatter(gfx);

                if (count < 4)
                {
                    tf.DrawString(word2Print[i].Definition, font, XBrushes.Black, new XRect(page[pageat].Width / 4 * (3 - count), 0, page[pageat].Width / 4, page[pageat].Height / 4), XStringFormats.TopLeft);
                }
                else if (count > 3 && count < 8)
                {
                    tf.DrawString(word2Print[i].Definition, font, XBrushes.Black, new XRect(page[pageat].Width / 4 * (3 - (count - 4)), page[pageat].Height / 4, page[pageat].Width / 4, page[pageat].Height / 4), XStringFormats.TopLeft);
                }
                else if (count > 7 && count < 12)
                {
                    tf.DrawString(word2Print[i].Definition, font, XBrushes.Black, new XRect(page[pageat].Width / 4 * (3 - (count - 8)), page[pageat].Height / 4 * 2, page[pageat].Width / 4, page[pageat].Height / 4), XStringFormats.TopLeft);
                }
                else
                {
                    tf.DrawString(word2Print[i].Definition, font, XBrushes.Black, new XRect(page[pageat].Width / 4 * (3 - (count - 12)), page[pageat].Height / 4 * 3, page[pageat].Width / 4, page[pageat].Height / 4), XStringFormats.TopLeft);
                }

                pageat--;

                gfx.Dispose();

                gfx = XGraphics.FromPdfPage(page[pageat]);
                tf = new XTextFormatter(gfx);

                count++;
            }
            

            // Save the document...
            string filename = txtLocation.Text + txtName.Text + ".pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }

        private void chkAll_Click(object sender, EventArgs e)
        {
            chkAll.Checked = true;
            lstWords.Enabled = false;
            txtWords.Enabled = false;
            chkSpec.Checked = false;
            chkRan.Checked = false;
        }

        private void chkSpec_Click(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            lstWords.Enabled = true;
            UpdateList();

            txtWords.Enabled = false;
            chkSpec.Checked = true;
            chkRan.Checked = false;
        }

        private void chkRan_Click(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            lstWords.Enabled = false;
            txtWords.Enabled = true;
            chkSpec.Checked = false;
            chkRan.Checked = true;
        }

    }
}
