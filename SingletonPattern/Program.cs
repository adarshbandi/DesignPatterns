using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLogger testLogger = new TestLogger();
            testLogger.LogInfo("-------------- Started Main Method() -----------------");
            EmployeeDetails();
            StudentDetails();
            ProfessorDetails();
            ManagerDetails();

            testLogger.TestingLogging();
            testLogger.LogInfo("-------------- Parallel programming started -----------------");
            Parallel.Invoke(() => StudentDetails(), () => ProfessorDetails(), () => ManagerDetails(), () => EmployeeDetails());
            testLogger.LogInfo("-------------- Parallel programming ended -----------------");
            testLogger.LogInfo("-------------- Ended Main Method() -----------------");
        }

        private static void ProfessorDetails()
        {
            Singleton fromProf = Singleton.GetInstance;
            fromProf.PrintMessage("Called from Professor class");

            TestLogger testLogger = new TestLogger();
            testLogger.LogInfo("Called from Professor Details method()");
        }

        private static void ManagerDetails()
        {
            Singleton fromMgr = Singleton.GetInstance;
            fromMgr.PrintMessage("Called from Manager class");

            TestLogger testLogger = new TestLogger();
            testLogger.LogInfo("Called from Professor Details method()");
        }

        private static void StudentDetails()
        {
            Singleton fromStud = Singleton.GetInstance;
            fromStud.PrintMessage("Called from Student class");

            TestLogger testLogger = new TestLogger();
            testLogger.LogInfo("Called from Professor Details method()");
        }

        private static void EmployeeDetails()
        {
            Singleton fromEmp = Singleton.GetInstance;
            fromEmp.PrintMessage("Called from Employee class");

            TestLogger testLogger = new TestLogger();
            testLogger.LogInfo("Called from Professor Details method()");
        }
    }
}
