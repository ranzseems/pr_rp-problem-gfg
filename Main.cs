using pr_rp_problem;

internal static class MainHelpers
{
    public static void Main(String[] args)
    {
        Problem problem = new();
        problem.Solve(3, 9, "rptpprpypzpipprrrhpp");
        Solution solution = new();
        solution.Solve(3, 9, "rptpprpypzpipprrrhpp");
    }
}

//pr = 2 * 3  = 6
//rp = 2 * 9 = 18
//tppypzpipprrrhpp
