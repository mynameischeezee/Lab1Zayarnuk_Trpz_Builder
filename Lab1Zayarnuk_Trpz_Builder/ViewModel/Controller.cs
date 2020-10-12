using System;
using Lab1Zayarnuk_Trpz_Builder.BLL.Impementaion;
using Lab1Zayarnuk_Trpz_Builder.BLL.Absract;
namespace Lab1Zayarnuk_Trpz_Builder.ViewModel
{
    public class Controller
    { 
       private BuilderService builderService = new BuilderService();

        public string StartWork(Builder builder)
        {
            return $"Builder`s {builder.WorkerName} work status now is {builderService.StartWork(builder)}.";
        }
        public string FinishWork(Builder builder)
        {
            return $"Builder`s {builder.WorkerName} work status now is {builderService.FinishWork(builder)}.";
        }
        public string GetWorkStatus(Builder builder)
        {
            return $"Builder`s {builder.WorkerName} works status is: {builderService.GetWorkStatus(builder)}.";
        }
        public string BuildBricks(Builder builder, int bricks)
        {
            return $"Builder {builder.WorkerName} successfuly built {builderService.BuildBricks(builder, bricks)} brick(s). {builder.BricksOnSession} brick(s) after last rest and {builder.TotalBricksOnSession} on this sesseion.";
        }
        public string HowManyBricksBuilt(Builder builder)
        {
            return $"Builder {builder.WorkerName} built {builderService.HowManyBricksBuilt(builder)} brick(s) after rest and {builder.TotalBricksOnSession} brick(s) on this session.";
        }
        public string HowManyTimeWasOnRest(Builder builder)
        {
            return $"Builder {builder.WorkerName} was on rest for {builderService.HowManyTimeWasOnRest(builder)} minute(s).";
        }
        public string TakeRestForMinutes(Builder builder, int minutes)
        {
            return $"Builder {builder.WorkerName} took a rest for {minutes} minutes and now has a status {builderService.TakeRestForMinutes(builder, minutes)}";
        }
    }
}
