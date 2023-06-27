using System;

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
            string xmlFormat = "";

            for (int i = 0; i < depth; i++)
                xmlFormat += "\t";

            xmlFormat += $"<{tag}>{value}</{tag}>";

            return xmlFormat;
        }
    }
}

