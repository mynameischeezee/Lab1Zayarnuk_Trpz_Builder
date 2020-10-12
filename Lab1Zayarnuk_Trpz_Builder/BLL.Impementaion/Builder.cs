using System;
using Lab1Zayarnuk_Trpz_Builder.BLL.Absract;
namespace Lab1Zayarnuk_Trpz_Builder.BLL.Impementaion
{
    public class Builder : Worker
    {
        public int BricksOnSession;
        public int RestMinutesOnSession;
        public int TotalBricksOnSession;
        public Builder(string name, int Age, WorkType workType, WorkStatus workStatus) : base(name, Age, workType, workStatus)
        {
            this.BricksOnSession = 0;
            this.RestMinutesOnSession = 0;
            this.TotalBricksOnSession = 0;
        }
        public void AddBricksOnSeesion(int bricks)
        {
            if (bricks > 0)
            {
                this.BricksOnSession += bricks;
                this.TotalBricksOnSession += bricks;
            }
            else
            {
                throw new Exception("Wrong bricks amount.");
            }
        }
        public void ResetBricksOnSession()
        {
            this.BricksOnSession = 0;
        }
        public void ResetTotalBricksOnSession()
        {
            this.TotalBricksOnSession = 0;
        }
        public void ResetRestMinutes()
        {
            this.RestMinutesOnSession = 0;
        }
        public void AddRestMinutes(int minutes)
        {
            if (minutes > 0)
            {
                this.RestMinutesOnSession = minutes;
            }
            else
            {
                throw new Exception("Wrong minutes amount.");
            }
        }
    }
}
