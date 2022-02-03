using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Xunit;
using System.Threading;

namespace SFSelenBiotusHM
{
    [Binding]
    public class MyAccountSteps
    {
        private IWebDriver _driver;

        [Given(@"user on the andMe homepage")]
        public void GivenUserOnTheBiotusHomepage()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://kiev.i-mne.com/");

        }
        
        [When(@"user click on registration button")]
        public void WhenUserClickOnRegistrationButton()
        {
            _driver.Navigate().GoToUrl("http://kiev.i-mne.com/authentication/");
            _driver.FindElement(By.Id("SubmitCreate")).Click();

        }
        [When(@"user put data")]
        public void WhenUserPutData()
        {
            _driver.FindElement(By.Id("customer_firstname")).SendKeys("Test");
            _driver.FindElement(By.Id("customer_lastname")).SendKeys("Test");
            _driver.FindElement(By.Id("phone_mobile")).SendKeys("0956462082");
            _driver.FindElement(By.Id("email")).SendKeys("tast2test1@gmail.com");
            _driver.FindElement(By.Id("passwd")).SendKeys("!123qweqwe");
        }
        [When(@"user press button registration")]
        public void WhenUserPressButtonRegistration()
        {
            _driver.FindElement(By.Id("submitAccount")).Click();
            
        }

        [Then(@"user sees the personal area")]
        public void ThenUserSeesThePersonalArea()
        {
            _driver.FindElement(By.LinkText("Test Test")).Click();
            _driver.FindElement(By.CssSelector("h1"));
            Assert.Equal("Мой аккаунт", _driver.FindElement(By.CssSelector("h1")).Text);
        }

        [When(@"user clicks on the Enter button")]
        public void WhenUserClicksOnTheEnterButton()
        {
            _driver.FindElement(By.LinkText("Вход")).Click();
        }

        [When(@"user put data for authorization")]
        public void WhenUserPutDataForAuthorization()
        {
            _driver.FindElement(By.Name("email_ajax")).SendKeys("tast2test1@gmail.com");
            _driver.FindElement(By.Name("passwd_ajax")).SendKeys("!123qweqwe");
            
        }
        [When(@"user press button authorization")]
        public void WhenUserPressButtonAuthorization()
        {
            _driver.FindElement(By.Id("SubmitLogin_ajax")).Click();
            Thread.Sleep(2000);   
        }
        [Then(@"user sees the personal area1")]
        public void ThenUserSeesThePersonalArea1()
        {
            _driver.FindElement(By.XPath("//a[contains(text(),'Test Test')]")).Click();
            _driver.FindElement(By.CssSelector("h1"));
            Assert.Equal("Мой аккаунт", _driver.FindElement(By.CssSelector("h1")).Text);
        }


        [When(@"user press button myAccount")]
        public void WhenUserPressButtonMyAccount()
        {
            _driver.FindElement(By.XPath("//a[contains(text(),'Test Test')]")).Click();
        }

        [When(@"user press button myAdress")]
        public void WhenUserPressButtonMyAdress()
        {
            _driver.FindElement(By.LinkText("Мои адреса")).Click();
        }
        [When(@"user add adess")]
        public void WhenUserAddAdess()
        {
            _driver.FindElement(By.LinkText("Добавить адрес")).Click();
        }
        [When(@"user add data to adress")]
        public void WhenUserAddDataToAdress()
        {
            _driver.FindElement(By.Id("address1")).SendKeys("ул.Угловая");
            _driver.FindElement(By.Id("entrance_number")).SendKeys("3");
            _driver.FindElement(By.Id("floor_number")).SendKeys("9");
            _driver.FindElement(By.Id("door_phone")).SendKeys("5");
            _driver.FindElement(By.Id("postcode")).SendKeys("49000");
            _driver.FindElement(By.ClassName("jq-selectbox__select")).Click();
            _driver.FindElement(By.CssSelector("#id_country-styler input")).SendKeys("Украина");
            _driver.FindElement(By.CssSelector("li:nth-child(201)")).Click();
            _driver.FindElement(By.Id("phone_mobile")).SendKeys("099999999");
            _driver.FindElement(By.XPath("//body[@id='address']/main/div/div/form/p/input[2]")).Click();
        }
        [Then(@"user sees another adress")]
        public void ThenUserSeesAnotherAdress()
        {
            _driver.FindElement(By.ClassName("addresses")).Click();
            _driver.FindElement(By.ClassName("address_phone_mobile"));
            Assert.Equal("099999999", _driver.FindElement(By.ClassName("address_phone_mobile")).Text);
        }

        [When(@"user press button SingOut")]
        public void WhenUserPressButtonSingOut()
        {
            _driver.FindElement(By.XPath("(//a[contains(text(),'Выход')])[2]")).Click();
        }
        [Then(@"user sees the Enter button")]
        public void ThenUserSeesTheEnterButton()
        {
            Assert.Equal("Вход", _driver.FindElement(By.LinkText("Вход")).Text);
        }


    }
}
