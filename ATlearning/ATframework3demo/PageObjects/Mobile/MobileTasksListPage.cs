using atFrameWork2.BaseFramework;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;

namespace ATframework3demo.PageObjects.Mobile
{
    public class MobileTasksListPage
    {

        public bool IsTaskPresent(Bitrix24Task task)
        {
            var taskTitle = new MobileItem($"//android.widget.TextView[@content-desc=\"task-list_SECTION_TITLE\" and @text=\"{task.Title}\"]",
                $"Заголовок задачи с текстом {task.Title}");

            bool isTaskPresent = Waiters.WaitForCondition(() => taskTitle.WaitElementDisplayed(), 2, 6,
                $"Ожидание появления задачи '{task.Title}' в списке задач");
            return isTaskPresent;
        }

        public MobileProjectListPage SelectProject()
        {
            var ProjectSelector = new MobileItem("//android.widget.TextView[@resource-id=\"com.bitrix24.android:id/title\" and @text=\"Проекты\"]","Селектор 'Проекты' в верхней карусели страницы");
            ProjectSelector.Click();
            return new MobileProjectListPage();
        }
    }
}
