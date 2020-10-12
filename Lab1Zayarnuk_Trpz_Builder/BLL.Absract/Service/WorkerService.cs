using System;
namespace Lab1Zayarnuk_Trpz_Builder.BLL.Absract
{
    public static class WorkerService
    {
        public static int CheckAge(int age)
        {
            if (age > 0)
            {
                return age;
            }
            else
            {
                throw new Exception("Wrong age.");
            }

        }
    }
}
