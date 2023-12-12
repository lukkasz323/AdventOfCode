namespace AoC_2022.Days;

public partial class Day7 : Day
{
    protected override void Solve()
    {
        var fs = new FileSystem(); // 348 cd, 184 dirs, 294 files

        foreach (string line in PuzzleInput)
        {
            string[] lineSplit = line.Split();

            if (lineSplit.Length == 3)
            {
                if (lineSplit[0] == "$" && lineSplit[1] == "cd")
                {
                    HandleCd(fs, lineSplit[2]);
                }
            }
            else if (lineSplit.Length == 2)
            {
                if (lineSplit[0] == "dir")
                {
                    HandleLs_Dir(fs, lineSplit[1]);
                }
                else if (int.TryParse(lineSplit[0], out int fileSize))
                {
                    HandleLs_File(fs, fileSize, lineSplit[1]);
                }
            }
            
            //if (lineSplit.Length == 3 
            //    && lineSplit[0] == "$" 
            //    && lineSplit[1] == "cd")
            //{ 
            //    HandleCd(fs, lineSplit[2]);
            //}
            //else if (lineSplit.Length == 2
            //    && lineSplit[0] == "dir")
            //{
            //    HandleLs_Dir(fs, lineSplit[1]);
            //}
            //else if (lineSplit.Length == 2
            //    && int.TryParse(lineSplit[0], out int fileSize)) 
            //{
            //    HandleLs_File(fs, fileSize, lineSplit[1]);
            //}
        }                       
    }

    private static void HandleCd(FileSystem fs, string arg)
    {
        //arg switch
        //{
        //    "/" => Root,
        //    ".." => Current.Parent,
        //    _ => Current.FindChild(arg),
        //};
}

    private static void HandleLs_Dir(FileSystem fs, string dirName)
    {

    }

    private static void HandleLs_File(FileSystem fs, int fileSize, string fileName)
	{

	}
}