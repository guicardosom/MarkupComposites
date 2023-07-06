using System;

namespace Project2
{
	public class XMLBuilder : IBuilder
	{
        private XMLBranch root, current;
        private Stack<XMLBranch> openBranches;

        public XMLBuilder()
		{
            root = current = new XMLBranch("root");
            openBranches = new Stack<XMLBranch>();
            openBranches.Push(current);
        }

        public void BuildBranch(string name)
        {
            XMLBranch branch = new XMLBranch(name);
            current.AddChild(branch);
            current = branch;
            openBranches.Push(current);
        }

        public void BuildLeaf(string name, string content)
        {
            current.AddChild(new XMLLeaf(name, content));
        }

        public void CloseBranch()
        {
            if (openBranches.Count() > 1)
                openBranches.Pop();
            current = openBranches.Peek();
        }

        public IComposite GetDocument()
        {
            return root;
        }
    }
}

