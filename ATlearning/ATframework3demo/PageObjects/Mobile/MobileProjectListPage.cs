
using atFrameWork2.BaseFramework;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.TestEntities;
using System.Threading.Tasks;

namespace ATframework3demo.PageObjects.Mobile
{
    /// <summary>
    /// страница с проектами
    /// </summary>
    public class MobileProjectListPage
    {
        /// <summary>
        /// клик по кнопке "+" в правом нижнем углу
        /// </summary>
        /// <returns></returns>
        public MobileCreateProjectPageStep1 ClickAddButton()
        {
            var AddButton = new MobileItem("//android.widget.ImageButton[@resource-id=\"com.bitrix24.android:id/component_fab\"]", "Кнопка '+' в правом нижнем углу ");
            AddButton.Click();
            return new MobileCreateProjectPageStep1();
        }


        /// <summary>
        /// ассерт наличия на экране созданного проекта
        /// </summary>
        /// <param name="testProject"></param>
        /// <returns></returns>
        internal bool IsProjectPresent(Bitrix24Project testProject)
        {
            var projectTitle = new MobileItem($"//android.widget.TextView[@resource-id=\"com.bitrix24.android:id/title\" and @text=\"{testProject.Title}\"]", "заголовок с названием проекта");
            bool isProjectPresent = Waiters.WaitForCondition(() => projectTitle.WaitElementDisplayed(), 2, 6,
                $"Ожидание появления задачи '{testProject.Title}' в списке задач");
            return isProjectPresent;
        }
    }
}