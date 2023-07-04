using System;
using System.Xml.Linq;

namespace Project2
{
	public class XMLComposite : IComposite
	{
        private List<IComposite> _children = new List<IComposite>();
        private string name;

        public XMLComposite(string n)
        {
            name = n;
        }

        public List<IComposite> GetChildren()
        {
            return _children;
        }

        public void AddChild(IComposite child)
        {
            if (!_children.Contains(child))
                _children.Add(child);
        }

        public string Print(int depth)
        {
            string xmlFormat = $"<{name}>\n";

            foreach (var child in _children)
                xmlFormat += child.Print(depth);

            xmlFormat += $"\n</{name}>";

            return xmlFormat;
        }
    }
}

