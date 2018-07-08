using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_InformationApp
{
    public partial class Form1 : Form
    {
        String firstNameValue = "";
        String lastNameValue = "";
        String fatherNameValue = "";
        String motherNameValue = "";
        String addressValue = "";
        String fullNameValue = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            firstNameValue = firstNameTextBox.Text;
            lastNameValue = lastNameTextBox.Text;
            fullNameValue = firstNameValue +" "+ lastNameValue;
            fatherNameValue = fatherNameTextBox.Text;
            motherNameValue = motherNameTextBox.Text;
            addressValue = AddressTextBox.Text;
//            string fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            MessageBox.Show("Save Successfully !");

        }

        private void ShowAll_InformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Full Name : " + firstNameValue + " " + lastNameValue + "\n" + "Father's Name : " + fatherNameValue + "\n" + "Mother's Name : " + motherNameValue + "\n" + "Address : " + addressValue + "\n");

        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Full Name is : " + fullNameValue);
        }

        private void ParentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father's Name : " + fatherNameValue + "\n" + "Mother's Name : " + motherNameValue);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address : " + addressValue);
        }
    }
}
