using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo2
{
   public class MyDataViewModel : IDisposable
   {
      private SandBoxEntities db;

      public MyDataViewModel() => db = new SandBoxEntities();

      public System.Windows.Forms.BindingSource MyDataBindingSource { get; set; }

      public void Load()
      {
         db.tblMVVMTest.Load();

         MyDataBindingSource.DataSource = db.tblMVVMTest.Local.ToBindingList();
      }

      public void Delete() => MyDataBindingSource.RemoveCurrent();

      public void New() => MyDataBindingSource.AddNew();

      public void Save()
      {

         MyDataBindingSource.EndEdit();

         db.SaveChanges();

      }//Save

      public void Dispose()
      {
         db.Dispose();
      }
   }//MyDataViewModel
}//MVVMDemo2
