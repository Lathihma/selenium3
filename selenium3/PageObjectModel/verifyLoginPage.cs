using System;
using System.Collections.Generic;
using System.Text;

namespace selenium3.PageObjectModel
{
    class verifyLoginPage(IWebdriver driver)
    {
        var username = driver.FindElements(By.CssSelector("a[data-toggle=dropdown]"))[1].Text;
        Assert.AreEqual(username, "Hello hari!");
    }
}
