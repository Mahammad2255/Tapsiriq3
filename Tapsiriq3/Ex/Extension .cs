using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapsiriq3.Ex
{
    public static class Extension
    {
        
        public static bool Yoxla(this string word, string axtar)
        {
            string n = axtar.ToLower();
            string m = word.ToLower();
            //Contains metodunu arasdirib yazdim, basqa cur de yazmaga calisdim ancaq "Hello World"
            //yazdigdan sonra Hell yoxlayanda true, Hellt meselen yoxlayanda da true verirdi, ona gore bu usulla yazdim
            if(m.Contains(n) == true)
            {
                return true;
            }
            return false;
            //string[] arr = word.Split(' ');
            //StringBuilder sb2 = new StringBuilder(axtar);
            //StringBuilder sb = new StringBuilder(word);

            //for (int i = 0, b=0; i < arr.Length; i++, b++)
            //{

            //    if(sb[i] == sb2[b])
            //    {
            //        return true;
            //    }
            //}
            //string[] arr = word.Split(' ');
            //StringBuilder sb2 = new StringBuilder(axtar);

            //foreach (var item in arr)
            //{

            //   if(item == axtar)
            //    {
            //        return true;
            //    }
            //    int i = 0;
            //    int b = 0;



            //---------------------------------------
            //    if (item[i] == sb2[b])
            //    {
            //        i++;
            //        b++;
            //        for (int k = 0, j=0; k < sb2.Length; j++,k++)
            //        {
            //            if(item[j] == sb2[k])
            //            {
            //                return true;

            //            }
            //            return false;
            //        }
            //        //return true;
            //    }
            //}

            
        }
    }
}
