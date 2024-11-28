using System;
using System.Collections.Generic;

namespace InspectorLib
{
    // Класс, содержащий методы и свойства автоинспекции
    public class FunctionInsp
    {
        // Название инспекции
        private readonly string _inspectionName = "Автоинспекция г. Чита";
        // ФИО главного инспектора
        private string _chiefInspector = "Васильев Василий Иванович";
        // Список сотрудников инспекции
        private List<string> _workers = new List<string>
        {
            "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И."
        };

        // Метод для получения ФИО главного инспектора
        public string GetInspector()
        {
            return _chiefInspector;
        }

        // Метод для получения названия инспекции
        public string GetCarInspection()
        {
            return _inspectionName;
        }

        // Метод для изменения главного инспектора
        // Возвращает true, если изменение успешно, в противном случае false
        public bool SetInspector(string fullname)
        {
            // Проверка, есть ли полное имя в списке сотрудников
            if (_workers.Contains(fullname))
            {
                _chiefInspector = fullname;
                return true;
            }
            return false; // Не удалось изменить инспектора
        }

        // Метод для генерации госномера
        public string GenerateNumber(string number, string symbol, string code)
        {
            // Проверка корректности символа
            if (!string.IsNullOrEmpty(symbol) && symbol.Length == 1 && char.IsLetter(symbol, 0) && char.IsUpper(symbol[0]))
            {
                return $"{symbol}{number}_{code}"; // Формирование номера в заданном формате
            }
            throw new ArgumentException("Неверный формат символа."); // Ошибка при неверном формате
        }

        // Метод для получения списка сотрудников
        public List<string> GetWorker()
        {
            return new List<string>(_workers); // Возвращаем копию списка сотрудников
        }

        // Метод для добавления нового сотрудника в список
        public void AddWorker(string fullname)
        {
            // Проверка на уникальность сотрудника
            if (!_workers.Contains(fullname))
            {
                _workers.Add(fullname); // Добавление нового сотрудника
            }
        }
    }
}