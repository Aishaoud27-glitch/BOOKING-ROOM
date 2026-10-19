using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKING_ROOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text;
            int age, nights, guests;

            if (string.IsNullOrWhiteSpace(guestName) ||
                !int.TryParse(txtGuestAge.Text, out age) ||
                !int.TryParse(txtNumberOfNights.Text, out nights) ||
                !int.TryParse(txtNumberOfGuest.Text, out guests))
            {
                MessageBox.Show("Please enter valid information.");
                return;
            }

            if (age <= 0 || nights <= 0 || guests <= 0)
            {
                MessageBox.Show("Please enter positive numbers.");
                return;
            }

            double roomPrice = 0;

            if (rdoStandard.Checked)
                roomPrice = 30;
            else if (rdoNormal.Checked)
                roomPrice = 50;
            else if (rdnHigh.Checked)
                roomPrice = 80;
            else
            {
                MessageBox.Show("Please select room type.");
                return;
            }

            double roomCost = roomPrice * nights;
            double breakfast = chkBreakfast.Checked
                ? 10 * guests * nights : 0;

            double total = roomCost + breakfast;

            lstBooking.Items.Add("Guest Name: " + guestName);
            lstBooking.Items.Add("Guest Age: " + age);
            lstBooking.Items.Add("Number of Nights: " + nights);
            lstBooking.Items.Add("Number of Guests: " + guests);
            lstBooking.Items.Add("Room Cost: $" + roomCost);
            lstBooking.Items.Add("Breakfast: $" + breakfast);
            lstBooking.Items.Add("Total Amount: $" + total);
            lstBooking.Items.Add("-------------------------");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNumberOfNights.Clear();
            txtNumberOfGuest.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdnHigh.Checked = false;
            chkBreakfast.Checked = false;

            lstBooking.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    }
    

