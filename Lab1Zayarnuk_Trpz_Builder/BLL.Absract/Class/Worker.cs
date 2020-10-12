using System;
using System.Collections;
namespace Lab1Zayarnuk_Trpz_Builder.BLL.Absract
{
    public abstract class Worker
    {
        public string WorkerName;
        public int WorkerAge;
        public WorkType WorkerWorkType;
        public WorkStatus WorkerWorkStatus;
        public Worker(string Name, int Age, WorkType workType, WorkStatus workStatus)
        {
            WorkerName = Name;
            WorkerAge = WorkerService.CheckAge(Age);
            WorkerWorkType = workType;
            WorkerWorkStatus = workStatus;
        }

    }
}
