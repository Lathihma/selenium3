namespace selenium3
{
    public class TestsBase
    {

        private void Verifyloginpage()
        {
            var username = driver.FindElements(By.CssSelector("a[data-toggle=dropdown]"))[1].Text;
            Assert.AreEqual(username, "Hello hari!");
        }
    }
}