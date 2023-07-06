using System;

namespace Project2
{
	public interface IComposite
	{
        void AddChild(IComposite child);
        string Print(int depth);
    }
}

