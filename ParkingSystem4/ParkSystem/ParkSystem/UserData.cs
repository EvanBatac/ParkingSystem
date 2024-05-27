using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkSystem
{
    internal class UserData
    {

      
    }

    class UserDetails
    {
        public string name;
        public int id;

        private static UserDetails instance;
        public static UserDetails Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDetails();
                return instance;
            }
            set
            {
                instance = value;
            }
        }


        public void setId(int Id)
        {
            id = Id;
        }
        public int getId()
        {
            return id;
        }


    }
}
