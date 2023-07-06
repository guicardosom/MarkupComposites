using System;

namespace Project2
{
	public class JSONBuilder : IBuilder
	{
        private JSONBranch root, current;
        private Stack<JSONBranch> openBranches;

        public JSONBuilder()
		{
            root = current = new JSONBranch("");
            openBranches = new Stack<JSONBranch>();
            openBranches.Push(current);
        }

        public void BuildBranch(string name)
        {
            JSONBranch branch = new JSONBranch(name);
            current.AddChild(branch);
            current = branch;
            openBranches.Push(current);
        }

        public void BuildLeaf(string name, string content)
        {
            current.AddChild(new JSONLeaf(name, content));
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

