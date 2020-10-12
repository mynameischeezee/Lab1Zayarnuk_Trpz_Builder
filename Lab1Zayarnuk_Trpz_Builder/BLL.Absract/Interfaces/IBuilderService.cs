using System;
using Lab1Zayarnuk_Trpz_Builder.BLL.Impementaion;

namespace Lab1Zayarnuk_Trpz_Builder.BLL.Absract
{
    public interface IBuilderService : IWorkerService
    {
        WorkStatus StartWork(Builder worker);
        WorkStatus FinishWork(Builder worker);
        WorkStatus TakeRestForMinutes(Builder worker, int restTime);
        int HowManyTimeWasOnRest(Builder worker);
        int BuildBricks(Builder worker, int bricks);
        int HowManyBricksBuilt(Builder worker);
        

    }
}
