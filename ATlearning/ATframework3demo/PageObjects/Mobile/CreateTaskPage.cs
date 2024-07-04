
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile
{
    public class CreateTaskPage
    {
        public CreateTaskPage EnterTaskTitle(string taskName)
        {
            var TitleField = new MobileItem("//android.widget.EditText[@text=\"Название задачи\"]", "поле с названием задачи");
            TitleField.SendKeys(taskName);
            return this;
        }
    }
}