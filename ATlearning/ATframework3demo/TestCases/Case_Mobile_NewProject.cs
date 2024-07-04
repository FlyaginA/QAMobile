using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.TestEntities;
using ATframework3demo.PageObjects.Mobile;
using atFrameWork2.BaseFramework.LogTools;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Mobile_NewProject : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(
                new TestCase("Создание проекта", mobileHomePage => CreateProject(mobileHomePage)));
            return caseCollection;
        }




        void CreateProject(MobileHomePage homePage)
        {
            string projectName = "testTasks" + DateTime.Now.Ticks.ToString();
            var testProject = new Bitrix24Project(projectName);


            bool isProjectPresent = homePage
                .TabsPanel
                //кликаем в "Задачи"
                .SelectTasks()  
                //выбираем "проекты"
                .SelectProject()
                //нажимаем на кнопку "добавить"
                .ClickAddButton()
                //вводим название проекта
                .EnterTitleProject(testProject)
                //нажимаем "далее"
                .ClickContinueButton()
                //нажимаем "создать"
                .ClickCreateButton()
                //проверяем наличие созданного проекта на экране
                .IsProjectPresent(testProject);


            if (!isProjectPresent)
            {
                Log.Error($"Созданный проект с названием {testProject.Title} не отображается");
            }
            else
            {
                Log.Info($"Созданный проект с названием {testProject.Title} отображается");
            }
        }
    }
}

