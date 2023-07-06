using System;
using System.Xml.Linq;

namespace Project2
{
	public class XMLLeaf : IComposite
	{
        private string tag;
        private string value;

        public XMLLeaf(string t, string v)
		{
            tag = t;
            value = v;
		}

        public void AddChild(IComposite child)
        {
        }

        public string Print(int depth)
        {
           return String.Format("{0," + depth * 4 + "}<{1,0}>{2,0}</{1,0}>", " ", tag, value);
        }
    }
}

