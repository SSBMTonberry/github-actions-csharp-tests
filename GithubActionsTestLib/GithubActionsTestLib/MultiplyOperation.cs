namespace GithubActionsTestLib;

public class MultiplyOperation : IMathOperation<decimal>
{
    public decimal Sum(decimal a, decimal b) => a * b;
}