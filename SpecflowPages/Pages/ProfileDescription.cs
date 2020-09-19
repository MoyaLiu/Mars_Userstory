using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ProfileDescription
    {
        private By WrtIcBy = By.XPath("//h3[@class='ui dividing header']/span/i[@class='outline write icon']");
        private By TextAreaBy = By.XPath("//textarea[@name='value']");
        private By SaveBy = By.XPath("//*[@type='button'][text()='Save']");
        private IWebElement WrtIc => WebHelper.FindElement(Driver.driver, WrtIcBy);
        private IWebElement TextArea => WebHelper.FindElement(Driver.driver, TextAreaBy);
        private IWebElement Save => WebHelper.FindElement(Driver.driver, SaveBy);

        public void ClickDescriptionWrtIcon()
        {
            WebHelper.WaitClickable(Driver.driver, WrtIcBy, 5);
            WrtIc.Click();
        }

        public void EnterDescription(string description)
        {
            WebHelper.WaitClickable(Driver.driver, TextAreaBy, 5);
            TextArea.Click();
            TextArea.SendKeys(Keys.Control + 'a' + Keys.Backspace);
            TextArea.Clear();
            TextArea.SendKeys(description);
        }
        
        public void ClickSaveButton()
        {
            WebHelper.WaitClickable(Driver.driver, SaveBy, 5);
            Save.Click();
        }

        public string getAlertDialogText()
        {
            var alertDialogDisplay = By.XPath("//div[@class='ns-box-inner']");
            WebHelper.WaitVisible(Driver.driver, alertDialogDisplay, 2);
            var text = WebHelper.FindElement(Driver.driver, alertDialogDisplay).Text;
            Console.WriteLine("text = " + text);
            return text;
        }


    }
}
