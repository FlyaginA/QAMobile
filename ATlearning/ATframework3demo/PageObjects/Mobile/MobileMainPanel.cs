using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    /// <summary>
    /// Главная панель приложения
    /// </summary>
    public class MobileMainPanel
    {
        /// <summary>
        /// переключение на раздел задач
        /// </summary>
        /// <returns></returns>
        public MobileTasksListPage SelectTasks()
        {
            var tasksTab = new MobileItem("//android.widget.TextView[@text=\"Задачи\"]", 
                "Таб 'Задачи'");
            tasksTab.Click();

            return new MobileTasksListPage();
        }

        public MobileCreateTaskPage ClickAddButton()
        {
            return new MobileCreateTaskPage(); 
        }

    }
}