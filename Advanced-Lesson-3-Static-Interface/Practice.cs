using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void AL3_P3_3()
        {
        }
        public static void GuessType<T>(T item)
        {
	        
	        switch (item)
	        {
		        case string s:
		        {
			        Console.WriteLine($"Вы передали строку длиной {s.Length} символов. ");
			        break;
		        }
		        case int i:
		        {
			        Console.WriteLine("Вы передали положительное целое число");
			        break;
		        }
		        case double d:
		        {
			        Console.WriteLine($"Вы передали вещественное число с {d.ToString().Split('.')[1].Length} значимыми цифрами");
			        break;
		        }
		        case DateTime dt:
		        {
			        Console.WriteLine($"Вы передали время: {dt}");
			        break;
		        }
		        default:
		        {
			        Console.WriteLine("Понятия не имею, что вы передали");
			        break;
		        }
	        }
        }
	}    
}
