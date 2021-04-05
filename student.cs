using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class Student
    {
        // 1.Định nghĩa trường Name
        private string Name;
        // 2.Định nghĩa thuộc tính StudentName từ trường Name
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
        public Student() {}
        //3.Định nghĩa phương thức khởi tạo Student(string stName)
        public void student(string stName)
        {

            Name = stName;
        }
        //4.Định nghĩa phương thức Talk() giới thiệu
        //Tên của sinh viên thông qua MessageBox
        public virtual void Talk()
        {
            MessageBox.Show("Chao Hai!");

        }
    }
}
