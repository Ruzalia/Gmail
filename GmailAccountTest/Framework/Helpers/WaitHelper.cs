using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Threading;

namespace GmailTest.Framework.Helpers
{
    public class WaitHelper
    {
        public static TimeSpan DefaultTimeStep = TimeSpan.FromMilliseconds(200);
        public static TimeSpan DefaultTimeOutMilliseconds = TimeSpan.FromMilliseconds(10000);

        public static bool WaitForElementAccessable(IWebElement element, TimeSpan timeout, string elementName = null)
        {
            var timer = new Stopwatch();
            timer.Start();
            while (timeout > timer.Elapsed)
            {
                try
                {
                    Thread.Sleep(DefaultTimeStep);
                    if (element.Displayed & element.Enabled)
                    {
                        return true;
                    }
                }
                catch (Exception) { }
            }
            Console.WriteLine("Element "+elementName+" was not displayed or enabled.");
            return false;
        }
    }
}
