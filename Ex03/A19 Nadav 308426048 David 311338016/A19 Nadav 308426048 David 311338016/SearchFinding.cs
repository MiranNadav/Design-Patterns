using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Nadav_308426048_David_311338016
{
    class SearchFinding 
    {
        public enum TypeEnum { Post, Event, Page, Group }

        public string Text { get; set; }
        public TypeEnum Type { get; set; }

        public SearchFinding (string i_Text, TypeEnum i_Type)
        {
            Text = i_Text;
            Type = i_Type;
        }

 
    }
}
