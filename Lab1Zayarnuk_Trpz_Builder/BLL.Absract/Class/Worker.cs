using System;
using System.Collections;
namespace Lab1Zayarnuk_Trpz_Builder.BLL.Absract
{
    public abstract class Worker
    {
        public string WorkerName { get { return this.WorkerName; } protected internal set { this.WorkerName = value; } }
        public int WorkerAge  { get { return this.WorkerAge; } protected internal set { this.WorkerAge = value; } }
        public WorkType WorkerWorkType { get { return this.WorkerWorkType; } protected internal set { this.WorkerWorkType = value; } }
        public WorkStatus WorkerWorkStatus { get { return this.WorkerWorkStatus; } protected internal set { this.WorkerWorkStatus = value; } }
        public Worker(string Name, int Age, WorkType workType, WorkStatus workStatus)
        {
            this.WorkerName = Name;
            this.WorkerAge = WorkerService.CheckAge(Age);
            this.WorkerWorkType = workType;
            this.WorkerWorkStatus = workStatus;
        }

    }
}
