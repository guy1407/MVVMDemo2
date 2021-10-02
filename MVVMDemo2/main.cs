using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMDemo2
{
   public partial class frmMain : Form
   {

      private MyDataViewModel vm;

      public frmMain()
      {
         InitializeComponent();

         vm = new MyDataViewModel();

         vm.MyDataBindingSource = mydataBindingSource;

         vm.MyDataBindingSource = mydataBindingSource;

         this.Load += delegate {vm.Load();};

         cmdNew.Click += delegate { vm.New(); };

         cmdDelete.Click += delegate { vm.Delete(); };

         cmdSave.Click += delegate { vm.Save(); };

         this.FormClosing += delegate { vm.Dispose(); };
      }
   }
}
