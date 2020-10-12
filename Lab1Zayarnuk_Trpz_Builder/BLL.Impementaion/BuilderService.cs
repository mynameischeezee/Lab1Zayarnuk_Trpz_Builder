using System;
using Lab1Zayarnuk_Trpz_Builder.BLL.Absract;
namespace Lab1Zayarnuk_Trpz_Builder.BLL.Impementaion
{
    public class BuilderService : IBuilderService
    {
        public WorkStatus StartWork(Builder builder)
        {
            if (builder.WorkerWorkStatus != WorkStatus.OnWork)
            {
                builder.ResetBricksOnSession();
                builder.WorkerWorkStatus = WorkStatus.OnWork;
                return builder.WorkerWorkStatus;
            }
            else
            {
                throw new Exception("Worker already on work.");
            }
        }
        public WorkStatus FinishWork(Builder builder)
        {
            if (builder.WorkerWorkStatus != WorkStatus.Absent)
            {
                builder.ResetTotalBricksOnSession();
                builder.ResetRestMinutes();
                builder.ResetBricksOnSession();
                builder.WorkerWorkStatus = WorkStatus.Absent;
                return builder.WorkerWorkStatus;
            }
            else
            {
                throw new Exception("Worker already absent.");
            }
        }
        public WorkStatus SetWorkStatus(Worker worker, WorkStatus workStatus)
        {
            worker.WorkerWorkStatus = workStatus;
            return worker.WorkerWorkStatus;
        }
        public WorkStatus GetWorkStatus(Worker worker)
        {
            return worker.WorkerWorkStatus;
        }

        public int BuildBricks(Builder builder, int bricks)
        {
            if (bricks <= 20 && builder.WorkerWorkStatus == WorkStatus.OnWork)
            {
                if (builder.BricksOnSession + bricks <= 100)
                {
                    builder.AddBricksOnSeesion(bricks);
                    return bricks;
                }
                else
                {
                    throw new Exception($"{builder.WorkerName} can`t build {bricks} bricks. {builder.WorkerName} can build only {100 - builder.BricksOnSession} more brick(s) than should go on rest.");
                }

            }
            else
            {
                throw new Exception("For building bricks, brick amount should be less then 20 and builder should be on work.");
            }
        }
        public int HowManyBricksBuilt(Builder builder)
        {
            return builder.BricksOnSession;
        }

        public int HowManyTimeWasOnRest(Builder builder)
        {
            return builder.RestMinutesOnSession;
        }
        public WorkStatus TakeRestForMinutes(Builder builder, int restTime)
        {
            if (restTime >= 15 && builder.WorkerWorkStatus != WorkStatus.Absent)
            {
                builder.WorkerWorkStatus = WorkStatus.OnRest;
                builder.ResetBricksOnSession();
                builder.AddRestMinutes(restTime);
                builder.WorkerWorkStatus = WorkStatus.OnWork;
                return builder.WorkerWorkStatus;
                
            }
            else
            {
                throw new Exception($"{builder.WorkerName} is absent or input rest time is less than 15 minutes");
            }
        }
    }
}
