
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;


public class ConsoleApplication2
{
  public static void Main()
  {
    string categoryName = "Test1";
    if(!PerformanceCounterCategory.Exists(categoryName))
    {
      string firstCounterName = "Goals scored";
      string firstCounterHelp = "Goals scored live update";
      string categoryHelp = "Football related real time statistics";

      PerformanceCounterCategory customCategory = new PerformanceCounterCategory(categoryName);
      PerformanceCounterCategory.Create(categoryName, categoryHelp, PerformanceCounterCategoryType.SingleInstance, firstCounterName, firstCounterHelp);
    }
    else
    {
      string counterName = "Goals scored";
      PerformanceCounter footballScoreCounter = new PerformanceCounter(categoryName, counterName);
      footballScoreCounter.ReadOnly = false;
      footballScoreCounter.RawValue = 5;
      while (true)
      {
        footballScoreCounter.Increment();
        Thread.Sleep(1000);
        Random random = new Random();
        int goals = random.Next(-5, 6);
        Console.WriteLine(goals);

        footballScoreCounter.IncrementBy(goals);
        Thread.Sleep(1000);
    }

    
    }
    
    }
 
}