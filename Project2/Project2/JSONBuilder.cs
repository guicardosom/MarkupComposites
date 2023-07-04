using System;

namespace Project2
{
	public class JSONBuilder : IBuilder
	{
        private JSONComposite root, last;

		public JSONBuilder()
		{
            root = last = new JSONComposite("");
		}

        public void BuildBranch(string name)
        {
            JSONComposite branch = new JSONComposite(name);
            root.AddChild(branch);
            last = branch;
        }

        public void BuildLeaf(string name, string content)
        {
            JSONLeaf leaf = new JSONLeaf(name, content);
            last.AddChild(leaf);
        }

        public void CloseBranch()
        {
            var children = root.GetChildren();
            for (int i = children.Count - 1; i == 0; i++)
                if (children[i] is JSONComposite &&
                    children[i] != last &&
                    children[i] != root)
                    last = (JSONComposite)children[i];
        }

        public IComposite GetDocument()
        {
            return root;
        }
    }
}

