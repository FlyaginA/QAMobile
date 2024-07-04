
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    /// <summary>
    /// страница создания проекта#1
    /// </summary>
    public class MobileCreateProjectPageStep1
    {
        /// <summary>
        /// ввод названия в соответствующее поле
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public MobileCreateProjectPageStep1 EnterTitleProject(string Name)
        {
            var TitleField = new MobileItem("//android.widget.EditText[@text=\"Заполнить\"]", "поле с именем проекта");
            TitleField.SendKeys(Name);
            return this;
        }
        /// <summary>
        /// Клик по кнопке "далее"
        /// </summary>
        /// <returns></returns>
        public MobileCreateProjectPageStep2 ClickContinueButton()
        {

            var ContinueButton = new MobileItem("//android.widget.TextView[@text=\"Далее\"]","кнопка 'далее'");
            ContinueButton.Click();
            return new MobileCreateProjectPageStep2();
        }
    }
}