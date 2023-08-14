namespace Exercise_12
{
    public interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(ITestpaper paper, string[] answers);
    }
}
