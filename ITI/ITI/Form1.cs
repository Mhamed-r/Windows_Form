using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace ITI
{

    public partial class Form1 : Form
    {
        //1-
        SqlConnection conn = new SqlConnection();
        int selectedID = 0;

        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = "Server=desktop-gtd3iip\\sqlexpress;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Course();
            GetTopic();
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;


        }

        private void Load_Course()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("select C.Crs_Id,C.Crs_Name,C.Crs_Duration,T.Top_Name,C.Top_Id from Course C ,Topic T Where T.Top_Id=C.Top_Id", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                conn.Close();
                DGV_data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_crname.Text))
            {
                MessageBox.Show("Please Enter Course Name");
            }
            else if (nud_crduration.Value > 100 || nud_crduration.Value < 20)
            {
                MessageBox.Show("Please Enter Course Duration Between 20 and 100");
            }
            else if (cb_topic.SelectedValue is null)
            {
                MessageBox.Show("Please Enter Topic");

            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand($"Insert into Course Values('{txt_crname.Text}',{nud_crduration.Value},{cb_topic.SelectedValue})", conn);
                    conn.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show($"Course: '{txt_crname.Text}' Inserted Successfully");

                    }
                    else { MessageBox.Show("Something Wrong"); }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                Load_Course();

            }
        }

        private void GetTopic()
        {



            try
            {
                SqlCommand cmd = new SqlCommand("select * From Topic", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                conn.Close();
                cb_topic.DataSource = dt;
                cb_topic.DisplayMember = "Top_Name";
                cb_topic.ValueMember = "Top_Id";
                cb_topic.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void DGV_data_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow Row = DGV_data.SelectedRows[0];
                txt_crname.Text = Row.Cells["Crs_Name"].Value.ToString();
                nud_crduration.Value = (int)Row.Cells["Crs_Duration"].Value;
                cb_topic.SelectedValue = (int)Row.Cells["Top_Id"].Value;
                //cb_topic.SelectedText = Row.Cells["Top_Name"].Value.ToString();      
                selectedID = (int)Row.Cells["Crs_Id"].Value;
                btn_add.Visible = false;
                btn_delete.Visible = true;
                btn_update.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            txt_crname.Text = "";
            nud_crduration.Value = 0;
            cb_topic.SelectedValue = 0;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //update Course
            //Set Crs_Name = 'Css'
            //where id = 1200

            if (string.IsNullOrWhiteSpace(txt_crname.Text))
            {
                MessageBox.Show("Please Enter Course Name");
            }
            else if (nud_crduration.Value > 100 || nud_crduration.Value < 20)
            {
                MessageBox.Show("Please Enter Course Duration Between 20 and 100");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand($"update Course Set Crs_Name='{txt_crname.Text}',Crs_Duration={nud_crduration.Value},Top_Id={cb_topic.SelectedValue}where Crs_Id={selectedID}", conn);
                    conn.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show($"Course: '{txt_crname.Text}' Updated Successfully");

                    }
                    else { MessageBox.Show("Something Wrong"); }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                Load_Course();

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_crname.Text))
            {
                MessageBox.Show("Please Enter Course Name");
            }
            else if (nud_crduration.Value > 100 || nud_crduration.Value < 20)
            {
                MessageBox.Show("Please Enter Course Duration Between 20 and 100");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand($"DELETE FROM Course where Crs_Id={selectedID}", conn);
                    conn.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show($"Course: '{txt_crname.Text}' Deleted Successfully");

                    }
                    else { MessageBox.Show("Something Wrong"); }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                Load_Course();

            }
        }
    }
}
