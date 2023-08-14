namespace Exercise_12
{
    public class Testpaper : ITestpaper
    {
        public string Subject { get; set; }
        public string[] MarkScheme { get; set; }
        public string PassMark { get; set; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }
    }
}
