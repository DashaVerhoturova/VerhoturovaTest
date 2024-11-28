using InspectorLib;
class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра класса FunctionInsp
        var inspector = new FunctionInsp();

        // Получение ФИО главного инспектора
        Console.WriteLine("Главный инспектор: " + inspector.GetInspector());

        // Получение названия инспекции
        Console.WriteLine("Название инспекции: " + inspector.GetCarInspection());

        // Изменение главного инспектора
        string newInspector = "Иванов И.И."; // Новое имя для инспектора
        if (inspector.SetInspector(newInspector))
        {
            Console.WriteLine("Главный инспектор изменён на: " + inspector.GetInspector());
        }
        else
        {
            Console.WriteLine("Ошибка изменения инспектора."); // Вывод сообщения об ошибке
        }

        // Генерация номера
        try
        {
            // Формируем номер и выводим его на экран
            string generatedNumber = inspector.GenerateNumber("123", "A", "75");
            Console.WriteLine("Сгенерированный номер: " + generatedNumber);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message); // Вывод сообщения об ошибке при генерации номера
        }

        // Получение списка сотрудников
        Console.WriteLine("Список сотрудников: " + string.Join(", ", inspector.GetWorker()));

        // Добавление нового сотрудника
        inspector.AddWorker("Сидоров С.С.");
        // Вывод обновленного списка сотрудников
        Console.WriteLine("Обновленный список сотрудников: " + string.Join(", ", inspector.GetWorker()));
    }
}
