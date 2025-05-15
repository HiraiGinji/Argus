using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argus
{
    internal class settersGetters
    {
        public static string uid, user, voidpid;
        public static int price;

        public string sg_uid
        {
            set { uid = value; }
            get { return uid; }
        }

        public string sg_user
        {
            set { user = value; }
            get { return user; }
        }

        public string sg_voidpid
        {
            set { voidpid = value; }
            get { return voidpid; }
        }

        public int sg_price
        {
            set { price = value; }
            get { return price; }
        }
    }
}
