
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//це проміжний клас між інтерфейсом і классами, що пов'язані з бд, у клієнт-серверному застосунку я перероблю його під роутер
namespace RandomizerService
{
    public class Controller:IController
    {
        private  static int user_ID;
     


        public bool loginUser(string log, string pass)
        {
           return  DBConnector.loginUser(log, pass);
            
        }

        public void logout() { DBConnector.user_ID = -1; }

        public ArrayList getRequests()
        {
            return DBConnector.getRequests();
            
        }

        public Stack<string> randomize(string start, string end)
        {
            return DBConnector.randomize(start, end);
        }

        public bool tryIncertReq(string start, string end)
        {

            return DBConnector.tryIncertReq(start, end);
        }

        public void controller()
        {
            DBConnector.user_ID = -1;
       
           
        }
    }
}


