using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildStore.Models
{
    public class Users
    {
        public string Id;
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Phone;
        public string Address;
        public string Image;
        public string Post = ""; // оставить поле пустым, если это клиент

        public string Login;
        public string Password;
        public string Secret;
    }
}
