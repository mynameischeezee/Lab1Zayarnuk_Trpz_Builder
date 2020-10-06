using System;
using Lab1Zayarnuk_Trpz_Builder.BLL.Impementaion;

namespace Lab1Zayarnuk_Trpz_Builder.BLL.Absract
{
    public interface IBuilderService<T> : IWorkerService where T : Builder
    {
        WorkStatus StartWork(T worker);
        WorkStatus FinishWork(T worker);
        WorkStatus TakeRestForMinutes(T worker, int restTime);
        int HowManyTimeWasOnRest(T worker);
        int BuildBricks(T worker, int bricks);
        int HowManyBricksBuilt(T worker);
        

    }
}
