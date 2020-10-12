using System;
using Lab1Zayarnuk_Trpz_Builder.BLL.Absract;
using Lab1Zayarnuk_Trpz_Builder.BLL.Impementaion;
using Lab1Zayarnuk_Trpz_Builder.ViewModel;

namespace Lab1Zayarnuk_Trpz_Builder
{
    class MainClass
    {

        public static void Main(string[] args)
        {

           Builder builder = new Builder("John", 30, WorkType.BrickBuilder, WorkStatus.Absent);
           Controller builderService = new Controller();
            Console.WriteLine(@"
     __          __  ______   _         _____    ____    __  __   ______     _______    ____     
     \ \        / / |  ____| | |       / ____|  / __ \  |  \/  | |  ____|   |__   __|  / __ \    
      \ \  /\  / /  | |__    | |      | |      | |  | | | \  / | | |__         | |    | |  | |   
       \ \/  \/ /   |  __|   | |      | |      | |  | | | |\/| | |  __|        | |    | |  | |   
        \  /\  /    | |____  | |____  | |____  | |__| | | |  | | | |____       | |    | |__| |   
  ____   \/  \/   _ |______| |______|  \_____|  \____/__|_|  |_| |______|      |_|     \____/    
 |  _ \          (_) | |     | |                  / ____|                       (_)              
 | |_) |  _   _   _  | |   __| |   ___   _ __    | (___     ___   _ __  __   __  _    ___    ___ 
 |  _ <  | | | | | | | |  / _` |  / _ \ | '__|    \___ \   / _ \ | '__| \ \ / / | |  / __|  / _ \
 | |_) | | |_| | | | | | | (_| | |  __/ | |       ____) | |  __/ | |     \ V /  | | | (__  |  __/
 |____/   \__,_| |_| |_|  \__,_|  \___| |_|      |_____/   \___| |_|      \_/   |_|  \___|  \___|");
            
            
            Console.WriteLine(builderService.GetWorkStatus(builder));
            Console.WriteLine(builderService.StartWork(builder));
            Console.WriteLine(builderService.GetWorkStatus(builder));
            try {Console.WriteLine(builderService.BuildBricks(builder, 20));}   catch (Exception e){ Console.WriteLine($"*Error: {e.Message}*");}
            try { Console.WriteLine(builderService.BuildBricks(builder, 20)); } catch (Exception e) {Console.WriteLine($"*Error: {e.Message}*");}
            try { Console.WriteLine(builderService.BuildBricks(builder, 20)); } catch (Exception e) {Console.WriteLine($"*Error: {e.Message}*");}
            try { Console.WriteLine(builderService.BuildBricks(builder, 20)); } catch (Exception e) {Console.WriteLine($"*Error: {e.Message}*");}
            try {Console.WriteLine(builderService.BuildBricks(builder, 25));}   catch (Exception e) {Console.WriteLine($"*Error: {e.Message}*");}
            try { Console.WriteLine(builderService.BuildBricks(builder, 20)); } catch (Exception e) {Console.WriteLine($"*Error: {e.Message}*");}
            try { Console.WriteLine(builderService.BuildBricks(builder, 20)); } catch (Exception e) {Console.WriteLine($"*Error: {e.Message}*");}
            Console.WriteLine(builderService.HowManyBricksBuilt(builder));
            try {Console.WriteLine(builderService.TakeRestForMinutes(builder, 10));} catch (Exception e) {Console.WriteLine($"*Error: {e.Message}*");}
            try { Console.WriteLine(builderService.TakeRestForMinutes(builder, 15)); } catch (Exception e) {Console.WriteLine($"*Error: {e.Message}*");}
            Console.WriteLine(builderService.GetWorkStatus(builder));
            Console.WriteLine(builderService.HowManyBricksBuilt(builder));
            Console.WriteLine(builderService.HowManyTimeWasOnRest(builder));
            Console.WriteLine(builderService.FinishWork(builder));
            Console.WriteLine(builderService.GetWorkStatus(builder));
            Console.ReadLine();
        }
        
    }
}
