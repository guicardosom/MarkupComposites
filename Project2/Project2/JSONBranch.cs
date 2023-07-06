using System;

namespace Project2
{
	public class JSONBranch : IComposite
	{
        private List<IComposite> _children;
        private string name;

        public JSONBranch(string n)
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
            string jsonFormattedText = "";

            if (!string.IsNullOrEmpty(name))
                jsonFormattedText += String.Format("{0," + depth * 4 + "}\'{1,0}\':\n", " ", name);

            jsonFormattedText += String.Format("{0," + depth * 4 + "}{1,0}\n", " ", '{');

            foreach (var child in _children)
            {
                jsonFormattedText += child.Print(depth + 1);

                if (child != _children.Last())
                    jsonFormattedText += ',';

                jsonFormattedText += '\n';
            }

            jsonFormattedText += String.Format("{0," + depth * 4 + "}{1,0}", " ", "}");

            return jsonFormattedText;
        }
    }
}

