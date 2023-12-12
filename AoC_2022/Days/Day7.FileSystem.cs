using System.Net.Http.Headers;

namespace AoC_2022.Days;

public partial class Day7
{
    private sealed class FileSystem
	{
		internal Directory Root { get; }
		internal Directory Current { get; private set; }

		internal FileSystem()
		{
			Root = new Directory("root");
			Current = Root;
		}

        internal void ChangeDirectory(string arg) => Current = Current.FindChild(arg);

        internal void EnsureDirectoryExists(string name) 
        {
            if (Current.ChildExists(name)) return;

            Current.Children.Add(new Directory(name, Current));
        }
    }
}
