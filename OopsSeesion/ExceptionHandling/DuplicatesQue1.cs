using System;
using System.Collections;

namespace OopsSeesion.ExceptionHandling
{
    class DuplicatesQue1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("sun");
            al.Add("mon");
            al.Add("sat");
            al.Add("sun");
            al.Add("mon");
            al.Add("sat");
    
            al.Add("sun");
            al.Add("sat");
            al.Add("sun");
            al.Add("mon");

        
           /* foreach (string dup in al)
            {
                if (!al.Contains(dup))
                {
                    al.Add(dup);

                }

            }*/

        }
    }
}
