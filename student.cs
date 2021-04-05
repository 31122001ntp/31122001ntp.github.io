using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppOOP
{

    class Student
    {
        private string Name;

        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public Student()
        {
            Name = stName;
        }
        public virtual void Talk()
        {
            MessageBox.Show("NguyenThanhPhuong");
        }

    }
}
