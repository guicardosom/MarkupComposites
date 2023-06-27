using System;

namespace Project2
{
	public class JSONComposite : IComposite
	{
        private List<IComposite> _children = new List<IComposite>();

        public void AddChild(IComposite child)
        {
            if (!_children.Contains(child))
                _children.Add(child);
        }

        public string Print(int depth)
        {
            string jsonFormat = "";

            foreach (var child in _children)
                jsonFormat += child.Print(depth);

            return jsonFormat;
        }
    }
}

