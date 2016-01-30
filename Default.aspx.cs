using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "test";
            string b = Caesar(a, 18); // Ok
            string c = Caesar(b, -18); // Ok

            string d = Caesar(a, 1); // Ok
            string ea = Caesar(d, -1); // Ok

            string f = "exxegoexsrgi";
            string g = Caesar(f, -4); // Ok
            Resutl_Lit.Text = "a=" + a + "<br> b18=" + b + "<br>c-18=" + c + "<br>d1=" + d + "<br>ea-1=" + ea + "<br>f=" + f + "<br>g(f,-4)=" + g;
         
        }
        static string Caesar(string text, int shift)
        {
            string syntax="";
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // Letter.
                char letter = buffer[i];
                // Add shift to all.
                letter = (char)(letter + shift);
                // Subtract 26 on overflow.
                // Add 26 on underflow.
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                // Store.
                buffer[i] = letter ;
                syntax += buffer[i] + "(" + "" + ")" + ",";
            }
            //return new string(buffer);
            return  (syntax);
        }

    }
}
