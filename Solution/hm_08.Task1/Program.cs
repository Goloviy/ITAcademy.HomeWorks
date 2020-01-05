using System;
using System.Text;
namespace hm_08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "1a!2.3!!..4.!.? 6 7!.. ?";
            int index = txt.IndexOf('?');
            StringBuilder sb_01 = new StringBuilder(txt.Substring(0, index));
            
            for (int i = 0; i < sb_01.Length; i++)
            {
                if (sb_01[i] == '!' || sb_01[i] == '.')
                {
                    sb_01.Remove(i, 1);
                    i--;
                }
            }        
            
            StringBuilder sb_02 = new StringBuilder(txt.Substring(index));
            sb_02.Replace(' ', '_');
            StringBuilder sb_03 = new StringBuilder();
            sb_03.Append(sb_01); ;
            sb_03.Append(sb_02);            
            Console.WriteLine(sb_03);
        }
    }
}
