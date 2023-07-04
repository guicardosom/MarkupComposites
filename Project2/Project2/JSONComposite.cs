using System;

namespace Project2
{
	public class JSONComposite : IComposite
	{
        private List<IComposite> _children = new List<IComposite>();
        private string name;

        public JSONComposite(string n)
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
            string jsonFormat = "";

            if (!string.IsNullOrEmpty(name))
                jsonFormat += $"'{name}':\n";      

            jsonFormat = "{\n";

            foreach (var child in _children)
                jsonFormat += child.Print(depth);

            jsonFormat += "\n}";

            return jsonFormat;
        }
    }
}

