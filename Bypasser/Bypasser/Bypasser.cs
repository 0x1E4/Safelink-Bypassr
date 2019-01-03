/*
#========================================================#
#                                                        #
#       Bypasser link for indonesian weaboo's            #
#                                                        #
#========================================================#
#                                                        #
# Welcome folks, the reason i'm making this shit because #
# i cannot open some links on daizurin or meownime safe  #
# link, because my adblock error (i can't disable it lol)#
#                                                        #
# You can support daizurin or meownime site by clicking  #
# their ads, yeah.......                                 #
#                                                        #
# - 0x1E4                                                #
#========================================================#
#                                                        #
#    Also dont forget to subscribe to @PewDiePie or      #
#         You cant get into your house >:(               #
#                                                        #
#========================================================#
*/


//using some weird stuff.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;

//don't forget bout namespace.
namespace Bypasser
{
    public partial class Bypasser : Form
    {
        //string for cheking link (jezz i'm so fricc'n lazzy bout checking with link like thiz
        static String link1 = "https://globalinew.com/?go="; // /?go=
        static String link2 = "http://davinsurance.com/?id="; // /?id=

        //Load form 1.
        public Bypasser()
        {
            InitializeComponent();
            Title.BackColor = Color.Transparent;
            Penjelasan.BackColor = Color.Transparent;
            Credits.BackColor = Color.Transparent;
        }

        //function by https://stackoverflow.com/users/128459/chris-mullins
        public static bool IsBase64String(string s)
        {
            s = s.Trim();
            return (s.Length % 4 == 0) && Regex.IsMatch(s, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

        }

        //Function by me.
        public static string TryHash(string tex)
        {
            if (IsBase64String(tex))
            {
                byte[] data = Convert.FromBase64String(tex);
                return Encoding.UTF8.GetString(data);
            }
            else if (tex.Contains(link1))
            {
                tex = tex.Replace(link1, "");
                byte[] data = Convert.FromBase64String(tex);
                return Encoding.UTF8.GetString(data);

            }
            else if (tex.Contains(link2))
            {
                tex = tex.Replace(link2, "");
                byte[] data = Convert.FromBase64String(tex);
                return Encoding.UTF8.GetString(data);

            }
            else
            {
                return tex = "null";
            }
        }
        
        //begins the experiment!
        private void SmashBtn_Click(object sender, EventArgs e)
        {
            //Get what you copied!
            var sample = Clipboard.GetText();
            
            //Try hashing like a boss.
            var result = TryHash(sample);

            //if result not contains null
            if (!result.Contains("null"))
            {
                //Execute da shiet!
                try
                {
                    Process.Start("chrome.exe", result);
                }
                catch(Exception)
                {
                    Process.Start("iexplore.exe", result);
                }
            }
            else
            {
                //Execute da shiet!
                MessageBox.Show("That is not a link!");
            }
        }
        
        //Just a little credits uwu.
        private void Credits_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://web.facebook.com/0x1E4");
        }
    }
}
