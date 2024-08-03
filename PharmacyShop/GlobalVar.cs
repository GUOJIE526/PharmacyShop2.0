using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace PharmacyShop
{
    public static class GlobalVar
    {
        public static string image_dir = @"D:\資策會課程\Project\PharmacyShop\assets";
        public static string User = "";
        public static int id = 0;
        public static string strDBConnectionString = "";
        public static int CustPrivilage = 0;//1 正常 0黑名單
        public static List<ArrayList> listProductCollection = new List<ArrayList>();
    }
}
