using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfControllerStudy.Models
{
    class User
    {
        private string? name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string? userImg;

        public string UserImg
        {
            get { return userImg; }
            set { string userImg = value; }
        }

        private int userAge;

        public int UserAge
        {
            get { return userAge; }
            set { userAge = value; }
        }


    }
}
