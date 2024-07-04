
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    /// <summary>
    /// Страница создания проекта#2
    /// </summary>
    public class MobileCreateProjectPageStep2
    {
        /// <summary>
        /// клик по кнопке "создать" 
        /// </summary>
        /// <returns></returns>
        public MobileProjectListPage ClickCreateButton()
        {
            var CreateButton = new MobileItem("//android.widget.TextView[@text=\"Создать\"]", "кнопка 'Создать'");
            CreateButton.Click();
            return new MobileProjectListPage();
        }
    }
}