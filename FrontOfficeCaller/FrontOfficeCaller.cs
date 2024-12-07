using Common_Utility.Common;
using FrontOffice.Forms.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontOfficeCaller
{
    public partial class FrontOfficeCaller : Form
    {
        
        public FrontOfficeCaller()
        {
            InitializeComponent();
        }

        private void FrontOfficeCaller_Load(object sender, EventArgs e)
        {
            FrontOfficeMain iFrontOfficeMain = new FrontOfficeMain();
            Security.IsFromCaller = true;
            Security.iUserID = "admin";
            iFrontOfficeMain.ShowDialog();
            this.Dispose();
            this.Close();
        }
    }
}
