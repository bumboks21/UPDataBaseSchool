using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolDb.DbEntity;

namespace SchoolDb.ViewModel
{
    public class AppVM : BaseVM
    {
        private User _user;

        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public Microsoft.Azure.Documents.User User { get; }

        public AppVM(User user)
        {

            Name = user.UserInfo.Name;
            Surname = user.UserInfo.Surname;
            Age = (int)user.UserInfo.Age;
        }

        public AppVM(Microsoft.Azure.Documents.User user)
        {
            User = user;
        }

        //private void LoadData()
        //{
        //    using (var db = new SchoolDbEntities())
        //    {
        //        var result = db.U
        //    }
        //}
    }
}
