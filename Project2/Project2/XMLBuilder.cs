using System;

namespace Project2
{
	public class XMLBuilder : IBuilder
	{
        private XMLComposite root, last;

        public XMLBuilder()
		{
            root = last = new XMLComposite("root");
        }

        public void BuildBranch(string name)
        {
            XMLComposite branch = new XMLComposite(name);
            root.AddChild(branch);
            last = branch;
        }

        public void BuildLeaf(string name, string content)
        {
            XMLLeaf leaf = new XMLLeaf(name, content);
            root.AddChild(leaf);
        }

        public void CloseBranch()
        {
            var children = root.GetChildren();
            for (int i = children.Count - 1; i == 0; i++)
                if (children[i] is XMLComposite &&
                    children[i] != last &&
                    children[i] != root)
                    last = (XMLComposite)children[i];
        }

        public IComposite GetDocument()
        {
            return root;
        }
    }
}

