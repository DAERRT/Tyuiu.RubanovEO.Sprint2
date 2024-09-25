
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RubanovEO.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string mast;
            string dostoinstvo;
            switch (value1)
            {
                case 1:
                    mast = "пик";
                break;
                case 2:
                    mast = "трефы";
                    break;
                case 3:
                    mast = "бубны";
                    break;
                case 4:
                    mast = "черви";
                    break;
                default:
                    mast = "Неверное число";
                    break;
            }
            switch (value2)
            {
                case 1:
                    dostoinstvo = "Единица";
                    break;
                case 2:
                    dostoinstvo = "Двойка";
                    break;
                case 3:
                    dostoinstvo = "Тройка";
                    break;
                case 4:
                    dostoinstvo = "Четверка";
                    break;
                case 5:
                    dostoinstvo = "Пятерка";
                    break;
                case 6:
                    dostoinstvo = "Шестерка";
                    break;
                case 7:
                    dostoinstvo = "Семерка";
                    break;
                case 8:
                    dostoinstvo = "Восмерка";
                    break;
                case 9:
                    dostoinstvo = "Девятка";
                    break;
                case 0:
                    dostoinstvo = "Десятка";
                    break;
                case 11:
                    dostoinstvo = "Валет";
                    break;
                case 12:
                    dostoinstvo = "дама";
                    break;
                case 13:
                    dostoinstvo = "Король";
                    break;
                case 14:
                    dostoinstvo = "Туз";
                    break;
                default:
                    dostoinstvo = "Неверное число";
                    break;
            }
            return $"{dostoinstvo} {mast}";
        }
    }
}
