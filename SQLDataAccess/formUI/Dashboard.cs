using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            PeopleListBox.DataSource = people;
            PeopleListBox.DisplayMember = "FullInfo";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(txtLastName.Text);
            PeopleListBox.DataSource = people;
            PeopleListBox.DisplayMember = "FullInfo";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertUser(txtFirstName.Text, txtLstName.Text, txtEmailAdress.Text, txtPhoneNumber.Text);
            txtPhoneNumber.Text = null;
            txtLstName.Text = null;
            txtEmailAdress.Text = null;
            txtFirstName.Text = null;
        }
    }
}
