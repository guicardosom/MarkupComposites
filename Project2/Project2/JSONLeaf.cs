using System;

namespace Project2
{
	public class JSONLeaf : IComposite
	{
        private string property;
        private string value;

		public JSONLeaf(string p, string v)
		{
            property = p;
            value = v;
		}

        public void AddChild(IComposite child)
        {
        }

        public string Print(int depth)
        {
            string jsonFormat = "";

            for (int i = 0; i < depth; i++)
                jsonFormat += "\t";

            jsonFormat += $"'{property}': '{value}'";

            return jsonFormat;
        }
    }
}

