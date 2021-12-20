
namespace ExamTask
{
    public class Checker
    {
        public int WaitingResults { get; set; }
        public int Checked { get; set; }
        private void Checking()
        {
            if (WaitingResults == 0)
            {
                return;
            }
        }
    }
}
