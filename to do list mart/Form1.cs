using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do_list_mart
{
    public partial class TODOLIST : Form
    {
        public TODOLIST()
        {
            InitializeComponent();
        }

        DataTable todolist = new DataTable();
        bool isEditing = false;
        private void TODOLIST_Load(object sender, EventArgs e)
        {
            // create col.
            todolist.Columns.Add("Title");
            todolist.Columns.Add("Description");

            ToDoListVeiw.DataSource = todolist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            Description.Text = "";
        }

        private void EditB_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // fill text field from data from table
            titleTextBox.Text = todolist.Rows[ToDoListVeiw.CurrentCell.RowIndex].ItemArray[0].ToString();
            Description.Text = todolist.Rows[ToDoListVeiw.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                todolist.Rows[ToDoListVeiw.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todolist.Rows[ToDoListVeiw.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todolist.Rows[ToDoListVeiw.CurrentCell.RowIndex]["Description"] = Description.Text;
            }
            else
            {
                todolist.Rows.Add(titleTextBox.Text, Description.Text);

            }
            //Clear fields
            titleTextBox.Text = "";
            Description.Text = "";
            isEditing = false;
        }
    }
}
