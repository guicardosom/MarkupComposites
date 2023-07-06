using System;

namespace Project2
{
	public class Director : IDirector
	{
        private IBuilder builder;

        public string? name { get; set; }
        public string? content { get; set; }

		public Director(IBuilder b)
		{
            builder = b;
        }

        public void BuildBranch()
        {
            builder.BuildBranch(name!);
        }

        public void BuildLeaf()
        {
            builder.BuildLeaf(name!, content!);
        }

        public void CloseBranch()
        {
            builder.CloseBranch();
        }

        public void PrintDocument()
        {
            Console.WriteLine(builder.GetDocument().Print(0));
        }
    }
}

