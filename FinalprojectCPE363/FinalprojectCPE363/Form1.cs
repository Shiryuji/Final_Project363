using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalprojectCPE363
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet data = new DataSet(); // สร้าง DataSet เพื่อเก็บข้อมูลจากฐานข้อมูล
        string conStr = "Provider=Microsoft.Jet.OleDb.4.0;" + @"Data Source=\\Mac\Home\Documents\Database\Student.mdb";

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(conStr); // สร้างการเชื่อมต่อฐานข้อมูล
            conn.Open();

            // ดึงข้อมูลจากตาราง Student
            string sql = "SELECT * FROM student";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(data, "Student");
            dataGridView1.DataSource = data.Tables["Student"];

            // ดึงข้อมูลจากตาราง Branch
            sql = "SELECT * FROM branch";
            cmd = new OleDbCommand(sql, conn);
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(data, "Branch");

            combo_branch.DisplayMember = "branch_name";
            combo_branch.ValueMember = "branch_id";
            combo_branch.DataSource = data.Tables["Branch"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            // ดึงข้อมูลจาก DataGridView ไปยัง TextBox และ ComboBox เมื่อคลิกที่แถว
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];
            txtstd_id.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtstd_name.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtstd_lname.Text = dataGridViewRow.Cells[2].Value.ToString();
            combo_branch.SelectedValue = dataGridViewRow.Cells[3].Value.ToString();

            dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีข้อมูลใน DataSet หรือไม่
            DataRow[] dataRows = data.Tables["Student"].Select("std_id='" + txtstd_id.Text + "'");
            if (dataRows.Length == 0)
            {
                // หากไม่มี ให้เพิ่มข้อมูลใหม่
                DataRow dataRow = data.Tables["Student"].NewRow();
                dataRow["std_id"] = txtstd_id.Text;
                dataRow["std_name"] = txtstd_name.Text;
                dataRow["std_lname"] = txtstd_lname.Text;
                dataRow["branch_id"] = combo_branch.SelectedValue;
                data.Tables["Student"].Rows.Add(dataRow);
            }
            else
            {
                // หากมี ให้แก้ไขข้อมูลเดิม
                dataRows[0]["std_name"] = txtstd_name.Text;
                dataRows[0]["std_lname"] = txtstd_lname.Text;
                dataRows[0]["branch_id"] = combo_branch.SelectedValue;
            }
            dataGridView1.DataSource = data.Tables["Student"];
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(conStr);
            conn.Open();

            DataRow[] dataRows = data.Tables["Student"].Select("std_id='" + txtstd_id.Text + "'");
            if (dataRows.Length == 0)
            {
                MessageBox.Show("ไม่พบข้อมูล");
            }
            else
            {
                dataRows[0].Delete();

                string sql = "SELECT * FROM student";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                OleDbCommandBuilder cmb = new OleDbCommandBuilder(adapter);
                adapter.Update(data, "Student");

                data.Tables["Student"].AcceptChanges();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(conStr);
            conn.Open();
            string sql = "SELECT * FROM student";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            OleDbCommandBuilder cmb = new OleDbCommandBuilder(adapter);
            adapter.Update(data, "Student");
        }
    }
}
// 6401174 ชัชชิน ใหม่เงิน
