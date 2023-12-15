using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Users
    {
        private string name;
        private string family;
        private string act;
        private string username;
        private string password;
        private string code;

        //constructor
        public Users(string name, string family, string act,  string username, string passowrd, string code)
        {
            setName(name);
            setFamily(family);
            setAct(act);
            setUsername(username);
            setPassword(password);
            setCode(code);
        }

    //default constructor
    public Users()
    {
        setName("test");
        setFamily("test");
        setAct("test");
        setUsername("test");
        setPassword("test");
        setCode("test");
        //setEmail("test");
        //setID(1);
    }
        //set
        public void setName(string name)
        {
            this.name = name;
        }
        public void setFamily(string family)
        {
            this.family = family;
        }
        public void setAct(string act)
        {
            this.act = act;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setCode(string code)
        {
            this.code = code;
        }
        //get
        public string getName()
        {
            return this.name;
        }
        public string getFamily()
        {
            return this.family;
        }
        public string getAct()
        {
            return this.act;
        }
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getCode()
        {
            return this.code;
        }
        //toString
        public string ToString()
        {
            return getName() + " " + getUsername() + " " + getPassword() + " " /* getEmail()+" "+getID()*/;
        }
    }
}
