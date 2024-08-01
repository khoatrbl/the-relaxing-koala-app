using RestaurantIS.DAO;
using RestaurantIS.DTO;
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
    public partial class fReservationManagement : Form
    {
        BindingSource reservationList = new BindingSource();
        public fReservationManagement()
        {
            InitializeComponent();

            dtgvReservationList.DataSource = reservationList;
            LoadListOfReservation();
            LoadReservationBinding();
            LoadTimePicker();
        }

        #region Methods

        private void LoadListOfReservation()
        {
            ClearBindings();
            ClearData();
            List<Reservation> listOfReservation = ReservationDAO.Instance.GetListOfReservations();
            reservationList.DataSource = listOfReservation;
        }

        private void LoadReservationBinding()
        {
            
            txbReservationId.DataBindings.Add(new Binding("Text", dtgvReservationList.DataSource, "id"));
            txbReservationTableId.DataBindings.Add(new Binding("Text", dtgvReservationList.DataSource, "tableId"));
            txbReservationName.DataBindings.Add(new Binding("Text", dtgvReservationList.DataSource, "CustomerName"));
            txbReservationPhone.DataBindings.Add(new Binding("Text", dtgvReservationList.DataSource, "Phone"));
            dtpkReservationDate.DataBindings.Add(new Binding("Value", dtgvReservationList.DataSource, "date"));
            txbReservationTime.DataBindings.Add(new Binding("Text", dtgvReservationList.DataSource, "Time"));
            numericReservationSeats.DataBindings.Add(new Binding("Value", dtgvReservationList.DataSource, "Seats"));
            txbReservationEmail.DataBindings.Add(new Binding("Text", dtgvReservationList.DataSource, "Email"));
        }

        private void ClearData()
        {
            txbReservationId.Text = string.Empty;
            txbReservationTableId.Text = string.Empty;
            txbReservationName.Text = string.Empty;
            txbReservationPhone.Text = string.Empty;
            dtpkReservationDate.Value = DateTime.Now;
            txbReservationTime.Text = string.Empty;
            numericReservationSeats.Value = 0;
            txbReservationEmail.Text = string.Empty;

        }

        private void ClearBindings()
        {
            // Clear all existing bindings to avoid issues with invalid data
            txbReservationId.DataBindings.Clear();
            txbReservationTableId.DataBindings.Clear();
            txbReservationName.DataBindings.Clear();
            txbReservationPhone.DataBindings.Clear();
            dtpkReservationDate.DataBindings.Clear();
            txbReservationTime.DataBindings.Clear();
            numericReservationSeats.DataBindings.Clear();
            txbReservationEmail.DataBindings.Clear();
        }

        private void LoadTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private bool UpdateReservation(int id, string name, string phone, string date, string time, int seats, string email)
        {
            return ReservationDAO.Instance.UpdateReservation(id, name, phone, date, time, seats, email);
        }

        private bool DeleteReservation(int id)
        {
            return ReservationDAO.Instance.DeleteReservation(id);
        }

        #endregion

        #region Events

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListOfReservation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbReservationId.Text);
            string name = txbReservationName.Text;
            string phone = txbReservationPhone.Text;
            DateTime date = dtpkReservationDate.Value;
            string time = txbReservationTime.Text;
            string email = txbReservationEmail.Text;
            int seats = (int)numericReservationSeats.Value;

            if (date < DateTime.Now.Date)
            {
                MessageBox.Show("Reservation date can't be in the past.");
                return;
            }

            string dateAsString = date.ToString();

            if (UpdateReservation(id, name, phone, dateAsString, time, seats, email))
            {
                MessageBox.Show("Reservation updated successfully!");
                LoadListOfReservation();
            }
            else
            {
                MessageBox.Show("Failed to update reservation.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbReservationId.Text);

            if (DeleteReservation(id))
            {
                MessageBox.Show("Reservation deleted successfully!");
                LoadListOfReservation();
            }
            else
            {
                MessageBox.Show("Failed to delete reservation.");
            }
        }

        private void dtgvReservationList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Check if the data source is empty
            if (reservationList.Count == 0)
            {
                // Set the DateTimePicker to a default date to avoid invalid value
                dtpkReservationDate.Value = DateTime.Now;
            }
        }

        #endregion

    }
}
