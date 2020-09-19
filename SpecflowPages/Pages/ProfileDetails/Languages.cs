using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages.ProfileDetails
{
    class Languages
    {
        private By LanguagesTitleBy = By.XPath("//a[contains(@class,'item')][@data-tab='first']");

        private By LanguageAddEditBy = By.XPath("//input[@placeholder='Add Language']");
        private By LanguageLevelDropdownBy = By.XPath("//select[@class ='ui dropdown'][@name='level']");
        private By LanguageWrtIcBy = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i");//tbody[i] is row number
        private By LanguageRmIcBy = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i");//td[i] is column number
        private By LanguageUpdateBtnBy = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[@value='Update']");////tbody[i] is row number
        private By LanguageCancelUpdateBtnBy = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[@value='Cancel']");
        private By AddLanguageBtnBy = By.XPath("//input[@class='ui teal button'][@value='Add']");
        private By CancelAddBtnBy = By.XPath("//input[@class='ui button'][@value='Cancel']");
        private By AddNewBtnBy = By.XPath("//div[@class='ui teal button ']");

        private IWebElement eLanguages => WebHelper.FindElement(Driver.driver, LanguagesTitleBy);
        private IWebElement eLanguageAddEdit => WebHelper.FindElement(Driver.driver, LanguageAddEditBy);
        private IWebElement eLanguageLevelDropdown => WebHelper.FindElement(Driver.driver, LanguageLevelDropdownBy);
        private IWebElement eAddLanguageBtn => WebHelper.FindElement(Driver.driver, AddLanguageBtnBy);
        private IWebElement eCancelAddBtn => WebHelper.FindElement(Driver.driver, CancelAddBtnBy);
        private IWebElement eLanguageWrtIc => WebHelper.FindElement(Driver.driver, LanguageWrtIcBy);
        private IWebElement eLanguageRmIc => WebHelper.FindElement(Driver.driver, LanguageRmIcBy);
        private IWebElement eLanguageUpdateBtn => WebHelper.FindElement(Driver.driver, LanguageUpdateBtnBy);
        private IWebElement eLanguageCancelUpdateBtn => WebHelper.FindElement(Driver.driver, LanguageCancelUpdateBtnBy);


        private IWebElement eAddNewButton => WebHelper.FindElement(Driver.driver, AddNewBtnBy);

        public void ClickLanguageTab()
        {
            WebHelper.WaitClickable(Driver.driver, LanguagesTitleBy, 5);
            eLanguages.Click();
        }

        public void ClickAddNewButton()
        {
            WebHelper.WaitClickable(Driver.driver, AddNewBtnBy, 5);
            eAddNewButton.Click();
        }

        public void EnterLanguageAndLevel(string language, string level)
        {
            Console.WriteLine("language = " + language);
            Console.WriteLine("level = " + level);
            WebHelper.WaitClickable(Driver.driver, LanguageAddEditBy, 5);
            eLanguageAddEdit.Click();
            eLanguageAddEdit.SendKeys(Keys.Control + "a" + Keys.Backspace);
            eLanguageAddEdit.SendKeys(language);
            WebHelper.WaitClickable(Driver.driver, LanguageLevelDropdownBy, 5);
            eLanguageLevelDropdown.Click();
            eLanguageLevelDropdown.SendKeys(level);
        }

        public void ClickAdd()
        {
            WebHelper.WaitClickable(Driver.driver, AddLanguageBtnBy, 5);
            eAddLanguageBtn.Click();
        }
        public void ClickCancelAdd()
        {
            WebHelper.WaitClickable(Driver.driver, CancelAddBtnBy, 5);
            eCancelAddBtn.Click();
        }
        public void ClickLanguageWrtIc()
        {
            WebHelper.WaitClickable(Driver.driver, LanguageWrtIcBy, 5);
            eLanguageWrtIc.Click();
        }
        public void ClickRemove()
        {
            WebHelper.WaitClickable(Driver.driver, LanguageRmIcBy, 5);
            eLanguageRmIc.Click();
        }
        public void ClickUpdate()
        {
            WebHelper.WaitClickable(Driver.driver, LanguageUpdateBtnBy, 5);
            eLanguageUpdateBtn.Click();
        }
        public void ClickCancelUpdate()
        {
            WebHelper.WaitClickable(Driver.driver, LanguageCancelUpdateBtnBy, 5);
            eLanguageCancelUpdateBtn.Click();
        }

        public string getLanguageText()
        {
            var by = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody/tr/td[1]");
            WebHelper.WaitVisible(Driver.driver, by, 5);
            return WebHelper.FindElement(Driver.driver, by).Text;
        }
        public string getLanguageLevelText()
        {
            var by = By.XPath("//div[@data-tab='first']/div/div[2]/div/table/tbody/tr/td[2]");
            WebHelper.WaitVisible(Driver.driver, by, 5);
            return WebHelper.FindElement(Driver.driver, by).Text;
        }
        public string getAlertDialogText()
        {
            var alertDialogDisplay = By.XPath("//div[@class='ns-box-inner']");
            WebHelper.WaitVisible(Driver.driver, alertDialogDisplay, 2);
            var text = WebHelper.FindElement(Driver.driver, alertDialogDisplay).Text;
            Console.WriteLine("text = " + text);
            return text;
        }
        public bool isVisibleAlertDialog()
        {
            var alertDialogDisplay = By.XPath("//div[@class='ns-box-inner']");
            if (WebHelper.WaitVisible(Driver.driver, alertDialogDisplay, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
