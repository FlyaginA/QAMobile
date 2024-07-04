
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

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
        public MobileCreateProjectPageStep1 EnterTitleProject(Bitrix24Project entity)
        {
            var titleField = new MobileItem("//android.widget.EditText[@text=\"Заполнить\"]", "поле с именем проекта");
            titleField.SendKeys(entity.Title);
            return this;
        }
        /// <summary>
        /// Клик по кнопке "далее"
        /// </summary>
        /// <returns></returns>
        public MobileCreateProjectPageStep2 ClickContinueButton()
        {

            var continueButton = new MobileItem("//android.widget.TextView[@text=\"Далее\"]","кнопка 'далее'");
            continueButton.Click();
            return new MobileCreateProjectPageStep2();
        }
    }
}