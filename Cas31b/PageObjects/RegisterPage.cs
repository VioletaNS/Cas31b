using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;


namespace Cas31b.PageObjects
{
    class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver) { }
        private IWebElement inputFirstName
        {
            get
            {
                return this.FindElement(By.Name("ime"));
            }
        }
        private IWebElement inputLastName
        {
            get
            {
                return this.FindElement(By.Name("prezime"));
            }
        }
        private IWebElement inputEmail
        {
            get
            {
                return this.FindElement(By.Name("email"));
            }
        }
        private IWebElement inputUserName
        {
            get
            {
                return this.FindElement(By.Name("korisnicko"));
            }
        }
        private IWebElement inputPassword
        {
            get
            {
                return this.FindElement(By.Name("lozinka"));
            }
        }
        private IWebElement inputPasswordRepeat 
        { 
            get
            {
                return this.FindElement(By.Name("lozinka opet"));
            }
        }
        private IWebElement buttonRegister
        {
            get
            {
                return this.FindElement(By.Name("register"));
            }
        }
        public void EnterFirstName(string firstname)
        {
            this.ExplicitWait();
            this.waitElementToBeClickable(By.Name("ime"));
            this.inputFirstName.SendKeys(firstname);
        }
        public void EnterLastName(string lastname)
        {
            this.ExplicitWait();
            this.waitElementToBeClickable(By.Name("prezime"));
            this.inputLastName.SendKeys(lastname);
        }
        public void EnterEmail(string email)
        {
            this.ExplicitWait();
            this.waitElementToBeClickable(By.Name("email"));
            this.inputEmail.SendKeys(email);
        }
        public void EnterUserName(string username)
        {
            this.ExplicitWait();
            this.waitElementToBeClickable(By.Name("korisnicko"));
            this.inputUserName.SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            this.ExplicitWait();
            this.waitElementToBeClickable(By.Name("lozinka"));
            this.inputPassword.SendKeys(password);
        }
        public void EnterPasswordAgain(string password)
        {
            this.ExplicitWait();
            this.waitElementToBeClickable(By.Name("lozinkaOpet"));
            this.inputPasswordRepeat.SendKeys(password);
        }
       
        public HomePage ClickOnButtonRegister()
        {
            this.buttonRegister.Click();
            this.waitElementToBeVisible(By.XPath("//div[contains(@class, 'success') and contains(., 'Uspeh']"));
            this.ExplicitWait();
            return new HomePage(this.driver);
        }
    }

}
