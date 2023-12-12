namespace AoC_2022.Days;

public partial class Day7
{
    private sealed class Directory
	{
		internal Directory Parent { get; set; }
		internal List<Directory> Children { get; } = new();
		internal List<File> Files { get; } = new();
		internal string Name { get; set; }

		internal Directory(string name, Directory? parent = null)
		{
			if (parent != null)
			{
                Parent = parent;
            }
			else
			{
				Parent = this;
			}

			Name = name;
		}

		internal bool ChildExists(string name)
		{
            foreach (Directory child in Children)
            {
                if (child.Name == name)
                {
					return true;
                }
            }
			return false;
        }

		internal Directory FindChild(string name)
		{
			foreach (Directory child in Children)
			{
				if (child.Name == name)
				{
					return child;
				}
				return FindChild(child.Name);
			}

			throw new InvalidOperationException($"Child `{name}` was not found.");
		}
	};
}
