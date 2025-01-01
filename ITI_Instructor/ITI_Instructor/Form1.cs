using Microsoft.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace ITI_Instructor
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter adapter;
        int selectedID = -1;
        string salary;


        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Server=desktop-gtd3iip\\sqlexpress;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True";
            dt = new DataTable();
            adapter = new SqlDataAdapter();
            Get_dept();
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;


        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Command = new SqlCommand("Select Ins_Id, Ins_Name,Ins_Degree,Salary,Dept_Id From Instructor", con);
                adapter.SelectCommand = Command;
                adapter.Fill(dt);
                DGV_getdata.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Name.Text))
            {
                MessageBox.Show("Please Enter Instructor Name");
            }
            else if (string.IsNullOrWhiteSpace(Txt_Degree.Text))
            {
                MessageBox.Show("Please Enter Instructor Degree");
            }
            else if (NUD_Salary.Value < 5000 || NUD_Salary.Value > 100000)
            {
                MessageBox.Show("Please Enter Salary Between 5000 and 100000");
            }
            else if (Cb_dept.SelectedValue is null)
            {
                MessageBox.Show("Please Enter Topic");

            }
            else
            {
                try
                {
                    salary = NUD_Salary.Value.ToString();
                    DataRow Rows = dt.NewRow();
                    int Num = dt.Rows.Count;
                    Rows[0] =++Num;
                    Rows["Ins_Name"] = Txt_Name.Text;
                    Rows["Ins_Degree"] = Txt_Degree.Text;
                    Rows["Salary"] = salary+".0000";
                    Rows["Dept_Id"] = Cb_dept.SelectedValue;
                    dt.Rows.Add(Rows);
                  //  MessageBox.Show($"Instructor : '{Txt_Name.Text}' Added Successfully ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
        public void Get_dept()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand Command = new SqlCommand("select Dept_Id,Dept_Name from Department", con);
                adapter.SelectCommand = Command;
                adapter.Fill(dt);
                Cb_dept.DataSource = dt;
                Cb_dept.DisplayMember = "Dept_Name";
                Cb_dept.ValueMember = "Dept_Id";
                Cb_dept.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }
        private void DGV_getdata_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow Row = DGV_getdata.SelectedRows[0];
                Txt_Name.Text = Row.Cells["Ins_Name"].Value.ToString();
                Txt_Degree.Text = Row.Cells["Ins_Degree"].Value.ToString();
                NUD_Salary.Value = (decimal)Row.Cells["Salary"].Value;
                Cb_dept.SelectedValue = (int)Row.Cells["Dept_Id"].Value;
                selectedID = (int)Row.Cells[0].Value;
                txt_id.Text = selectedID.ToString();
                btn_add.Visible = false;
                btn_delete.Visible = true;
                btn_update.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Name.Text))
            {
                MessageBox.Show("Please Enter Instructor Name");
            }
            else if (string.IsNullOrWhiteSpace(Txt_Degree.Text))
            {
                MessageBox.Show("Please Enter Instructor Degree");
            }
            else if (NUD_Salary.Value < 5000 || NUD_Salary.Value > 100000)
            {
                MessageBox.Show("Please Enter Salary Between 5000 and 100000");
            }
            else if (Cb_dept.SelectedValue is null)
            {
                MessageBox.Show("Please Enter Topic");

            }
            else
            {
                try
                {
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                    foreach (DataRow row in dt.Rows)
                    {
                        if ((int)row["Ins_Id"] == selectedID)
                        {
                            row["Ins_Name"] = Txt_Name.Text;
                            row["Ins_Degree"] = Txt_Degree.Text;
                            row["Salary"] = NUD_Salary.Value;
                            row["Dept_Id"] = Cb_dept.SelectedValue;
                        }
                    }
                    adapter.Update(dt);

                  //  MessageBox.Show($"Instructor : '{Txt_Name.Text}' Updated Successfully ");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
            DataRow delRow = dt.NewRow();
            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["Ins_Id"] == selectedID)
                {
                    delRow = row;
                }

            }
            delRow.Delete();
            adapter.Update(dt);
          //  MessageBox.Show($"Instructor : '{Txt_Name.Text}' Deleted Successfully ");

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
            Txt_Name.Text = null;
            Txt_Degree.Text = null;
            NUD_Salary.Value = 0;
            Cb_dept.SelectedValue = 0;
            selectedID = 0;
            txt_id.Text = null;
        }

        private void btn_updatedb_Click(object sender, EventArgs e)
        {
            SqlCommand insertcommand = new SqlCommand("insert into Instructor (Ins_Name, Ins_Degree, salary, Dept_Id) values (@Name, @Degree, @Salary, @Deptid);", con);
            insertcommand.Parameters.Add("Name", SqlDbType.NVarChar, 50, "Ins_Name");
            insertcommand.Parameters.Add("Degree", SqlDbType.NVarChar, 50, "Ins_Degree");
            insertcommand.Parameters.Add("Salary", SqlDbType.Money, 18, "Salary");
            insertcommand.Parameters.Add("Deptid", SqlDbType.Int, 4, "Dept_Id");
            adapter.InsertCommand = insertcommand;
           adapter.Update(dt);
           
            SqlCommand updatecommand = new SqlCommand("update Instructor set Ins_Name = '@Name' ,Ins_Degree='@Degree',salary=@Salary,Dept_Id=@Deptid where Ins_Id = @deptid;", con);
            updatecommand.Parameters.Add("Name", SqlDbType.NVarChar, 50, "Ins_Name");
            updatecommand.Parameters.Add("Degree", SqlDbType.NVarChar, 50, "Ins_Degree");
            updatecommand.Parameters.Add("Salary", SqlDbType.Money, 18, "Salary");
            updatecommand.Parameters.Add("Deptid", SqlDbType.Int, 4, "Dept_Id");
            updatecommand.Parameters.Add("id", SqlDbType.Int, 4, "Ins_Id");
            adapter.UpdateCommand = updatecommand;
           adapter.Update(dt);

            SqlCommand deletecommand = new SqlCommand("delete from Instructor where Ins_Id = @id;", con);
            deletecommand.Parameters.Add("id", SqlDbType.Int, 4, "Ins_Id");
            adapter.DeleteCommand = deletecommand;
            adapter.Update(dt);

            MessageBox.Show("Data Updated Successfully");

            btn_add_Click(null, null);
         

        }

    }

}
