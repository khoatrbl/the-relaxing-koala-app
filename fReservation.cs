using RestaurantIS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIS
{
    public partial class fReservation : Form
    {
        private int tableId;

        public fReservation(int tableId)
        {
            this.TableId = tableId;
            InitializeComponent();
        }

        public int TableId { get => tableId; set => tableId = value; }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            dtpkReservationDate.Format = DateTimePickerFormat.Custom;
            dtpkReservationDate.CustomFormat = "yyyy-MM-dd";

            string name = txbReservationName.Text;
            string phone = txbReservationPhone.Text;
            DateTime date = dtpkReservationDate.Value.Date;
            string time = txbReservationTime.Text;
            int seats = (int)numericNumberOfSeats.Value;
            string email = txbReservationEmail.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.", "Warning");
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter your phone number.", "Warning");
                return;
            }

            if (date < DateTime.Now.Date)
            {
                MessageBox.Show("Reservation date can't be in the past.");
                return;
            }

            if (string.IsNullOrWhiteSpace(time))
            {
                MessageBox.Show("Please enter your reservation time.", "Warning");
                return;
            }

            if (seats <= 0)
            {
                MessageBox.Show("The number of seats must be greater than 0.", "Warning");
                return;
            }

            string dateAsString = date.ToString("yyyy-MM-dd");

            if (ReserveTableById(tableId, name, phone, dateAsString, time, seats, email))
            {
                MessageBox.Show("Reservation made!");
            }
            else
            {
                MessageBox.Show("Failed to make reservation.");
            }
            this.Close();


        }

        private bool ReserveTableById(int tableId, string name, string phone, string date, string time, int seats, string email)
        {
            return ReservationDAO.Instance.ReserveTableById(tableId, name, phone, date, time, seats, email);
        }


    }
}
