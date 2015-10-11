namespace MonoLine
{
    class Backlog
    {
        private static string[] log = new string[short.MaxValue];
        private int logCount = 0;
        private int maxCount = 0;

        public void AddLog(string str)
        {
            if (str != log[logCount])
            {
                logCount++;
                maxCount = logCount;
                log[logCount] = str;
            } 
        }

        public string ReturnLog(string str)
        {
            if (logCount > 1) return log[--logCount];
            return str;
        }

        public string ForwardLog(string str)
        {
            if (logCount < maxCount) return log[++logCount];
            return str;
        }
    }
}
