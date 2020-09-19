using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class WebHelper
    {
        public static void WaitClickable(IWebDriver webDriver, By by, int seconds)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, seconds));
                wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("The element is not clickable, time out, " + ex.Message);
            }
        }

        public static bool WaitVisible(IWebDriver webDriver, By by, int seconds)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, seconds));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                return true;
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("The element is not visible, time out, " + ex.Message);
                return false;
            }
        }

        public static IWebElement FindElement(IWebDriver webDriver, By by)
        {
            try
            {
                var webElement = webDriver.FindElement(by);
                return webElement;
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine("Did not find the element." + ex.Message);
                return null;
            }
        }

        public static String GetCurrentPageURL(IWebDriver driver, int seconds, By by)
        {
            try
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                return driver.Url;
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("Get current page url " + seconds + "seconds time out." + ex.Message);
                return null;
            }
        }
    }
}
