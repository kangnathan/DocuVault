using DocumentManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class formHistory : Form
    {
        public ListView LvAuditTrail { get; private set; }
        private int _loggedInUserId;
        private AuditTrailService auditTrailService = new AuditTrailService();

        public formHistory(int loggedInUserId)
        {
            InitializeComponent();
            LvAuditTrail = lvAuditTrail;

        }

        private void formHistory_Load(object sender, EventArgs e)
        {
            auditTrailService.LoadAuditTrail(_loggedInUserId, lvAuditTrail);
        }



        private void lvAuditTrail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
