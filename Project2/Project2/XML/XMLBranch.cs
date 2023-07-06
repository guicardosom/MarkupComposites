using System;

namespace Project2
{
	public class XMLBranch : IComposite
	{
        private List<IComposite> _children;
        private string name;

        public XMLBranch(string n)
        {
            name = n;
            _children = new List<IComposite>();
        }

        public void AddChild(IComposite child)
        {
            if (!_children.Contains(child))
                _children.Add(child);
        }

        public string Print(int depth)
        {
            string xmlFormattedText = String.Format("{0," + depth * 4 + "}<{1,0}>\n", " ", name);

            foreach (var child in _children)
            {
                xmlFormattedText += child.Print(depth + 1);
                xmlFormattedText += '\n';
            }

            xmlFormattedText += String.Format("{0," + depth * 4 + "}</{1,0}>", " ", name);

            return xmlFormattedText;
        }
    }
}

