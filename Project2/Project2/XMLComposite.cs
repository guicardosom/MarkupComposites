using System;

namespace Project2
{
	public class XMLComposite : IComposite
	{
        private List<IComposite> _children = new List<IComposite>();

        public void AddChild(IComposite child)
        {
            if (!_children.Contains(child))
                _children.Add(child);
        }

        public string Print(int depth)
        {
            string xmlFormat = "";

            foreach (var child in _children)
                xmlFormat += child.Print(depth);

            return xmlFormat;
        }
    }
}

