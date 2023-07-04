using System;

namespace Project2
{
	public class Director : IDirector
	{
        private IBuilder builder;

		public Director(IBuilder b)
		{
            builder = b;
        }

        public void BuildBranch()
        {
            builder.BuildBranch();
        }

        public void BuildLeaf()
        {
            builder.BuildLeaf();
        }

        public void CloseBranch()
        {
            builder.CloseBranch();
        }
    }
}

