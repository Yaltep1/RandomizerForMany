using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizerService
{
    static class DBConnector
    {
        public static int user_ID = -1;

        public static void controller() {

        }
        public static bool loginUser(string log, string pass)
        {
            using (var con = new Connection())
            {
               User user= con.Users.First(u => u.login == log&& u.password == pass);
                if (user == null) { return false; }
                else { user_ID = user.Id; return true; }
               
              
            }
        }

        public static void logout() { user_ID = -1; }

        public static ArrayList getRequests()
        {
            using (var con = new Connection())
            {
                ArrayList list = new ArrayList();

                foreach (Request req in con.Requests)
                {
                    if (req.user_id == user_ID)
                    {

                        list.Add("Nums: " + "(" + req.start + ") - (" + req.finish + "); Date: " + req.date + " ;");
                    }
                }
                return list;
            }
        }

        public static Stack<string> randomize(string start, string end)
        {
            int s;
            int e;
            Int32.TryParse(start, out s);
            Int32.TryParse(end, out e);
            RandomNums rn = new RandomNums(s, e);
            return rn.doRandom();
        }

        public static bool tryIncertReq(string start, string end)
        {
            using (var con = new Connection())
            {
                int s;
                int e;
                if (Int32.TryParse(start, out s) && Int32.TryParse(end, out e))
                {
                    if (e >= s)
                    {
                        Request req = new Request();
                        req.start = s;
                        req.finish = e;
                        req.user_id = user_ID;
                        req.date = DateTime.Now.ToShortDateString();
                        con.Requests.Add(req);
                        con.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
