using System;
using InspectorLib;

namespace InspectorLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp inspector = new FunctionInsp();

          
            Console.WriteLine("Главный инспектор: " + inspector.GetInspector());
            Console.WriteLine("Название автоинспекции: " + inspector.GetCarInspection());

            Console.WriteLine("Список сотрудников:");
            foreach (var worker in inspector.GetWorkers())
            {
                Console.WriteLine(worker);
            }

            // Изменение главного инспектора
            if (inspector.SetInspector("Миронов А.В."))
            {
                Console.WriteLine("Новый главный инспектор: " + inspector.GetInspector());
            }
            else
            {
                Console.WriteLine("Не удалось установить нового главного инспектора. ФИО не найдено в списке сотрудников.");
            }

            // Генерация госномера
            var (success, generatedNumber) = inspector.GenerateNumber("7852", 'В', "75");
            if (success)
            {
                Console.WriteLine("Сгенерированный госномер: " + generatedNumber);
            }
            else
            {
                Console.WriteLine("Ошибка при генерации госномера: " + generatedNumber);
            }

            // Добавление нового сотрудника
            if (inspector.AddWorker("Сивухин. М.А."))
            {
                Console.WriteLine("Список сотрудников после добавления нового:");
                foreach (var worker in inspector.GetWorkers())
                {
                    Console.WriteLine(worker);
                }
            }
            else
            {
                Console.WriteLine("Не удалось добавить нового сотрудника. Сотрудник уже существует.");
            }
        }
    }
}
