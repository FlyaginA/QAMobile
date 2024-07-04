
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class MobileCreateProjectPage2
    {
        public MobileProjectListPage ClickCreateButton()
        {
            var CreateButton = new MobileItem("//android.widget.TextView[@text=\"Создать\"]", "кнопка 'Создать'");
            CreateButton.Click();
            return new MobileProjectListPage();
        }
    }
}