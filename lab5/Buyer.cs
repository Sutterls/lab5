using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Buyer
    {
        public sbyte Age { get; set; } /// ну допустим, что максимум люди доживают до 127

        public Buyer(sbyte age)
        {
            Age = age;
            if (Age <= 0) // проверка, на значения меньшие или равные 0
            {
                throw new ArgumentException("Age mustn't be less than or equal to 0"); // выбрасываем исключение ArgumentException с сообщением об ошибке
            }
        }
    }
}
