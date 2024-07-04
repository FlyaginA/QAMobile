using atFrameWork2.BaseFramework;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;

namespace ATframework3demo.PageObjects.Mobile
{
    /// <summary>
    /// страница с задачами
    /// </summary>
    public class MobileTasksListPage
    {

        /// <summary>
        /// переключение на страницу с проектами
        /// </summary>
        /// <returns></returns>
        public MobileProjectListPage SelectProject()
        {
            var projectSelector = new MobileItem("//android.widget.TextView[@resource-id=\"com.bitrix24.android:id/title\" and @text=\"Проекты\"]","Селектор 'Проекты' в верхней карусели страницы");
            projectSelector.Click();
            return new MobileProjectListPage();
        }
    }
}
