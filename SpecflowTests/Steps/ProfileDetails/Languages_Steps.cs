using MarsQA_1.SpecflowPages.Pages.ProfileDetails;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps
{
    [Binding]
    public sealed class Languages_Steps
    {
        Languages languages = null;

        Languages_Steps()
        {
            languages = new Languages();
        }

        [Given(@"Click Languages Tab")]
        public void GivenClickLanguagesTab()
        {
            languages.ClickLanguageTab();
        }

        [Given(@"Click Add New button")]
        public void GivenClickAddNewButton()
        {
            languages.ClickAddNewButton();
        }

        [Given(@"Enter the ""(.*)"" and ""(.*)""")]
        public void GivenEnterTheAnd(string language, string level)
        {
            languages.EnterLanguageAndLevel(language, level);
        }

        [When(@"Click Add")]
        public void WhenClickAdd()
        {
            languages.ClickAdd();
        }

        [When(@"Click Cancel add button")]
        public void WhenClickCancelAddButton()
        {
            languages.ClickCancelAdd();
        }

        //[Then(@"The ""(.*)"" and ""(.*)"" should be displayed")]
        //public void ThenTheAndShouldBeDisplayed(string language, string level)
        //{
        //    Assert.AreEqual(language, language + " " +profileAttributes.getLanguageText());
        //    Assert.AreEqual(level, profileAttributes.getLanguageLevelText());
        //}

        [Given(@"Click the language item edit button")]
        public void GivenClickTheLanguageItemEditButton()
        {
            languages.ClickLanguageWrtIc();
        }

        [When(@"Click update")]
        public void WhenClickUpdate()
        {
            languages.ClickUpdate();
        }

        [When(@"Click Cancel update button")]
        public void WhenClickCancelUpdateButton()
        {
            languages.ClickCancelUpdate();
        }

        [Given(@"Click the language item delete button")]
        public void GivenClickTheLanguageItemDeleteButton()
        {
            languages.ClickRemove();
        }

        [Then(@"The alert dialog ""(.*)"" should be displayed")]
        public void ThenTheAlertDialogShouldBeDisplayed(string notification)
        {
            StringAssert.Contains(notification, languages.getAlertDialogText());
        }

        [Then(@"The alert dialog should not be displayed")]
        public void ThenTheAlertDialogShouldNotBeDisplayed()
        {
            Assert.IsFalse(languages.isVisibleAlertDialog());
        }

    }
}
