using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MusicApp
{
    public partial class Search_Interface : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        string songname = "";
        string artistname = "";
        string country = "";
        string genre = "";
        string search = "";

        public Search_Interface()
        {
            InitializeComponent();
        }

        private void Search_Interface_Load(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\XML\Songs.xml");
            nodeList = xmlDoc.SelectNodes("/Songs" + "/Song");
            Search newform = (Search)this.Parent.Parent;
            for (int i = 0; i < nodeList.Count; i++)
            {
                songname = nodeList[i].SelectSingleNode("Name").InnerText.Trim();
                artistname = nodeList[i].SelectSingleNode("Artist").InnerText.Trim();
                country = nodeList[i].SelectSingleNode("Country").InnerText.Trim();
                genre = nodeList[i].SelectSingleNode("Genre").InnerText.Trim();
                search = songname + artistname + country + genre;

                if (RemoveUnicode(search).ToLower().Contains(RemoveUnicode(newform.txt_Search.Text).ToLower()))
                {
                    MusicBox x = new MusicBox();
                    x.SongName = songname;
                    x.ArtistName = artistname;
                    x.SongImage = Image.FromFile(@"..\\..\\SongImages\" + songname + ".jpg");
                    FlLayout_Searches.Controls.Add(x);
                }
            }
        }

        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
    }
}
