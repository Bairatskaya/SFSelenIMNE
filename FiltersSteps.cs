using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SFSelenBiotusHM
{
    [Binding]
    public class FiltersSteps
    {
        private IWebDriver _driver;

        [Given(@"user on the MoskvaAndMe homepage")]
        public void GivenUserOnTheMoskvaAndMeHomepage()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://moskva.i-mne.com/");
          
        }
        
        [Given(@"user press on kosmetika-i-gigiena button")]
        public void GivenUserPressOnKosmetika_I_GigienaButton()
        {
            _driver.FindElement(By.XPath("//a[contains(text(),'Косметика и гигиена')]")).Click();
        }
        
        [When(@"user presses the manufacturer button")]
        public void WhenUserPressesTheManufacturerButton()
        {
            _driver.FindElement(By.XPath("//body[@id='body']/div/div[4]/div[2]/div[2]/div/div/div[3]/div/div/form/div[3]/div[2]")).Click();
           
        }

        [When(@"user choose BioMio brand")]
        public void WhenUserChooseBioMioBrand()
        {
            _driver.FindElement(By.XPath("//body[@id='body']/div/div[4]/div[2]/div[2]/div/div/div[3]/div/div/form/div[3]/div[3]/ul/li[4]/label")).Click();
            

        }

        [When(@"user clicks the In stock button")]
        public void WhenUserClicksTheInStockButton()
        {
            _driver.FindElement(By.XPath("//body[@id='body']/div/div[4]/div[2]/div[2]/div/div/div[3]/div/div/form/div[8]/div[2]")).Click();
            _driver.FindElement(By.XPath("//body[@id='body']/div/div[4]/div[2]/div[2]/div/div/div[3]/div/div/form/div[8]/div[3]/ul/li[2]/label")).Click();

        }

        [When(@"user presses the manufacturer country button")]
        public void WhenUserPressesTheManufacturerCountryButton()
        {
            _driver.FindElement(By.XPath("//body[@id='body']/div/div[4]/div[2]/div[2]/div/div/div[3]/div/div/form/div[2]/div[2]")).Click();
        }

        [When(@"user selects country russia")]
        public void WhenUserSelectsCountryRussia()
        {
            _driver.FindElement(By.XPath("//body[@id='body']/div/div[4]/div[2]/div[2]/div/div/div[3]/div/div/form/div[2]/div[3]/ul/li/label")).Click();
        }

        [When(@"user presses the organic certificate button")]
        public void WhenUserPressesTheOrganicCertificateButton()
        {
            _driver.FindElement(By.CssSelector("//body[@id='body']/div/div[4]/div[2]/div[2]/div/div/div[3]/div/div/form/div[6]/div[2]")).Click();
        }
        
        [When(@"product selection is USDA certified")]
        public void WhenUserPressesTheproductHaveUSDACertified()
        {
            _driver.FindElement(By.XPath("//body[@id='body']/div/div[4]/div[2]/div[2]/div/div/div[3]/div/div/form/div[6]/div[3]/ul/li/label")).Click();
        }
        
        [Then(@"user sees in the list BioMio")]
        public void ThenUserSeesInTheListBioMio()
        {
            _driver.FindElement(By.LinkText("BioMio BIO-SOAP Антибактериальное жидкое мыло с маслом чайного дерева, 300 мл"));
            Assert.Contains("BioMio", _driver.FindElement(By.LinkText("BioMio BIO-SOAP Антибактериальное жидкое мыло с маслом чайного дерева, 300 мл")).Text);
        }

        [Then(@"user sees in the list products available")]
        public void ThenUserSeesInTheListProductsAvailable()
        {
            _driver.FindElement(By.LinkText("Шампунь «Жива» (Миролада) 500мл"));
            Assert.Contains("Миролада", _driver.FindElement(By.LinkText("Шампунь «Жива» (Миролада) 500мл")).Text);
        }
        
        [Then(@"user sees in the list selena shampoo")]
        public void ThenUserSeesInTheListSelenaShampoo()
        {
            _driver.FindElement(By.LinkText("(//a[contains(@href, '/product/shampun-hozyayka-mednoy-gory-mirolada-500ml')])[2]"));
            Assert.Contains("Селена", _driver.FindElement(By.LinkText("(//a[contains(@href, '/product/shampun-hozyayka-mednoy-gory-mirolada-500ml')])[2]")).Text);
        }
        
        [Then(@"user sees in the list product organic coconut oil")]
        public void ThenTheUserSeesInTheListProductOrganicCoconutOil()
        {
            _driver.FindElement(By.LinkText("Кокосовое масло Вирджин Барака organic 200мл Премиум стекло"));
            Assert.Contains("Кокосовое масло", _driver.FindElement(By.LinkText("Кокосовое масло Вирджин Барака organic 200мл Премиум стекло")).Text);
        }
    }
}
