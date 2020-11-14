using System;
using System.Windows.Forms;
using System.Net;
using BusinessRules;

namespace Interface
{
    public partial class PickLocation : Form
    {
        public PickLocation()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true; // takes out script errors' pop ups
        }

        #region GTFO
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void search_data_Click(object sender, EventArgs e)
        {
            //         Fields of form
            string street = txt_street.Text;
            string city = txt_city.Text;
            string state = txt_state.Text;
            string zip = txt_zip.Text;

            try
            {
                //              URL Search's components
                string queryAddress = "http://maps.google.com/maps?q=";
                string filterSearch= string.Empty;

                //       Addition of values for each criteria       
                if (street != string.Empty)
                {
                    filterSearch = street + " ";
                }

                if (city != string.Empty)
                {
                    if (filterSearch != string.Empty) filterSearch += city;
                    else filterSearch = city;
                }

                if (state != string.Empty)
                {
                    if (filterSearch != string.Empty) filterSearch += state;
                    else filterSearch = state;
                }

                if (zip != string.Empty)
                {
                    if (filterSearch != string.Empty) filterSearch += zip;
                    else filterSearch = zip;
                }

                // Final url treatment
                filterSearch = WebUtility.UrlEncode(filterSearch); // encoding of inputed search
                string fullUrl = queryAddress + filterSearch; // junction of url "header" with search filter

                MessageBox.Show(fullUrl); // Only for tests
                webBrowser1.Navigate(fullUrl); // Execution of url command

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitBotton(object sender, EventArgs e)
        {
            ShowResults switchForm = new ShowResults();
            this.Hide();
            DataAcess.LoadRestaurants();
            switchForm.Show();

        }
    }
}
