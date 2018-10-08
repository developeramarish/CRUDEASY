using OpenQA.Selenium;

namespace EasyCrud.TestsUI.Helpers
{
    public static class SeleniumGetMethods
    {
        public static string GetInnerText(this IWebElement element)
           => element.GetAttribute("innerText");
    }
}
