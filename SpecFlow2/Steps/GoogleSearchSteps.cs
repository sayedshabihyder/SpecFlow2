using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow2.Steps
{
    [Binding]
    class GoogleSearchSteps
    {
            IWebDriver driver = new ChromeDriver();

            [Given(@"I have navigated to Google page")]
            public void GivenIHaveNavigatedToGooglePage()
            {
                driver.Navigate().GoToUrl("http://www.google.co.in");
                driver.Manage().Window.Maximize();
            }



            [Given(@"I see the google page fully loaded")]
            public void GivenISeeTheGooglePageFullyLoaded()
            {
                if (driver.FindElement(By.Name("q")).Displayed == true)
                    Console.WriteLine("Page loaded fully");
                else
                    Console.WriteLine("Page failed to load");
            }

            [When(@"I type search keyword as")]
            public void WhenITypeSearchKeywordAs(Table table)
            {
                dynamic tableDetails = table.CreateDynamicInstance();
                driver.FindElement(By.Name("q")).SendKeys(tableDetails.Keyword);
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }

            [Then(@"I should see the result for keyword")]
            public void ThenIShouldSeeTheResultForKeyword(Table table)
            {
            System.Threading.Thread.Sleep(2000);
                dynamic tableDetails = table.CreateDynamicInstance();
                string key = tableDetails.Keyword;
                if (driver.FindElement(By.PartialLinkText(key)).Displayed == true)
                    Console.WriteLine("Console exsist");
                else
                    Console.WriteLine("Control not exsist");
            }
        }
    }
