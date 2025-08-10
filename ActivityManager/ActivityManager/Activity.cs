using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityManager
{
    internal class Activity
    {
        private string name;
        private List<string> tags;
        private DateTime lastPicked;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Tags
        { 
            get { return tags; }
            set { tags = value; } 
        }

        public DateTime LastPicked
        { 
            get { return lastPicked; } 
            set { lastPicked = value; } 
        }

        public void AddTag(string tag)
        {
            tags.Add(tag);
        }
    }
}
