using Common_Utility.Common;
using FrontOffice.Forms.Transactional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontOffice.Forms.Transactions
{
    public partial class FrontOfficeMain : Form
    {
        public FrontOfficeMain()
        {
            InitializeComponent();
        }

        private void reservationEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationEntry iReservationEntry = new ReservationEntry();

            Security.iUserID = "admin";
            iReservationEntry.ShowDialog();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void mnuItemGroupBooking_Click(object sender, EventArgs e)
        {
            GroupReservationEntry iGroupReservationEntry = new GroupReservationEntry();

            Security.iUserID = "admin";
            iGroupReservationEntry.ShowDialog();
        }

        private void mnuItemCheckIn_Click(object sender, EventArgs e)
        {
            Registration iRegistration = new Registration();

            Security.iUserID = "admin";
            iRegistration.ShowDialog();
        }

        private void mnuItemCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut iCheckOut = new CheckOut();

            Security.iUserID = "admin";
            iCheckOut.ShowDialog();
        }

        private void mnuItemServiceEntry_Click(object sender, EventArgs e)
        {
            ServiceEntry iServiceEntry = new ServiceEntry();

            Security.iUserID = "admin";
            iServiceEntry.ShowDialog();
        }

        private void mnuItemBillPayment_Click(object sender, EventArgs e)
        {
            BillPayment iBillPayment = new BillPayment();

            Security.iUserID = "admin";
            iBillPayment.ShowDialog();
        }

        private void mnuItemBillTransfer_Click(object sender, EventArgs e)
        {
            BillTransfer iBillTransfer = new BillTransfer();

            Security.iUserID = "admin";
            iBillTransfer.ShowDialog();

        }

        private void roomTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomTransfer iRoomTransfer = new RoomTransfer();

            Security.iUserID = "admin";
            iRoomTransfer.ShowDialog();
        }
    }
}
