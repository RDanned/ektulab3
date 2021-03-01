using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class Route
    {
        public string imagePath;
        public string name;
        public string description;

        public Route setImage(string path)
        {
            this.imagePath = path;
            return this;
        }

        public Route setName(string name)
        {
            this.name= name;
            return this;
        }

        public Route setDescription(string description)
        {
            this.description = description;
            return this;
        }

        public string displayedImage
        {
            get { return this.imagePath; }
        }

        public string displayedName
        {
            get { return this.name; }
        }
    }
}
