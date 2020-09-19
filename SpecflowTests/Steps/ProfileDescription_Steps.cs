using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Steps
{
    [Binding]
    public sealed class ProfileDescription_Steps
    {
        ProfileDescription profileDescription = null;

        ProfileDescription_Steps()
        {
            profileDescription = new ProfileDescription();
        }

        [Given(@"Click description edit icon")]
        public void GivenClickDescriptionEditIcon()
        {
            profileDescription.ClickDescriptionWrtIcon();
        }

        [Given(@"Enter the description ""(.*)""")]
        public void GivenEnterTheDescription(string description)
        {
            profileDescription.EnterDescription(description);
        }

        [When(@"Click save button")]
        public void WhenClickSaveButton()
        {
            profileDescription.ClickSaveButton();
        }
        [Then(@"The dialog ""(.*)""should be displayed")]
        public void ThenTheDialogShouldBeDisplayed(string display)
        {
            Assert.AreEqual(display, profileDescription.getAlertDialogText());
        }




    }
}
