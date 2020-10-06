using System;
namespace Lab1Zayarnuk_Trpz_Builder.BLL.Absract
{
    public interface IWorkerService
    {
        WorkStatus GetWorkStatus(Worker worker);
        WorkStatus SetWorkStatus(Worker worker, WorkStatus workStatus);
        
    }
}
