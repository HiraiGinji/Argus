using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Argus
{
    public partial class SearchUserControl : UserControl
    {
        DatabaseOperations connect = new DatabaseOperations();
        public SearchUserControl()
        {
            InitializeComponent();
        }


        FilterInfoCollection FIC;
        VideoCaptureDevice VCD;

        private void SearchUserControl_Load(object sender, EventArgs e)
        {
            FIC = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in FIC)
            {
                CameraListbox.Items.Add(device.Name);
            }
            CameraListbox.SelectedIndex = 0;
        }

        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            string searchText = txt_searchuser.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a Product ID or Product Name to search.");
                return;
            }

            DatabaseOperations dbOps = new DatabaseOperations();

            dbOps.DisplaySearchResults(searchText, dataGridView1);

            lst_suggestions.Visible = false;
        }

        private void txt_searchuser_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_searchuser.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                List<string> suggestions = connect.ProductSearchSuggestions(searchText);

                if (suggestions.Any())
                {
                    lst_suggestions.Items.Clear();
                    lst_suggestions.Items.AddRange(suggestions.ToArray());
                    lst_suggestions.Visible = true;
                }
                else
                {
                    lst_suggestions.Visible = false;
                }
            }
            else
            {
                lst_suggestions.Visible = false;
            }
        }

        private void lst_suggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_suggestions.SelectedItem != null)
            {
                string selectedSuggestion = lst_suggestions.SelectedItem.ToString();
                string[] suggestionParts = selectedSuggestion.Split(new string[] { " - " }, StringSplitOptions.None);
                string productID = suggestionParts[0];
                string productName = suggestionParts[1];

                txt_searchuser.Text = productName;
                lst_suggestions.Items.Clear();
                lst_suggestions.Visible = false;
            }
        }

        private void txt_Barcode_TextChanged(object sender, EventArgs e)
        {
            PassBarcode();
        }

        private void PassBarcode()
        {
            string productId = txt_Barcode.Text;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            connect.DisplaySearchResults(productId, dataGridView1);
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txt_Barcode.Invoke(new MethodInvoker(delegate ()
                {
                    txt_Barcode.Text = result.ToString();
                }));
            }
            pictureBox1.Image = bitmap;
        }
        private void CameraListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VCD = new VideoCaptureDevice(FIC[CameraListbox.SelectedIndex].MonikerString);
            VCD.NewFrame += VideoCaptureDevice_NewFrame;
            VCD.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CameraListbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VCD = new VideoCaptureDevice(FIC[CameraListbox.SelectedIndex].MonikerString);
            VCD.NewFrame += VideoCaptureDevice_NewFrame;
            VCD.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
