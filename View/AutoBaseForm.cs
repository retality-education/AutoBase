using AutoBase.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBase.View
{
    public partial class AutoBaseForm : Form
    {
        internal AutoBaseController autoBaseController;
        public AutoBaseForm()
        {
            InitializeComponent();
        }
    }
}
