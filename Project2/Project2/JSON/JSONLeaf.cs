using System;
using System.Xml.Linq;

namespace Project2
{
	public class JSONLeaf : IComposite
	{
        private string property;
        private string value;

		public JSONLeaf(string p, string v)
		{
            property = p;
            value = v;
		}

        public void AddChild(IComposite child)
        {
        }

        public string Print(int depth)
        {
            return String.Format("{0," + depth * 4 + "}\'{1,0}\': \'{2,0}\'", " ", property, value);
        }
    }
}

