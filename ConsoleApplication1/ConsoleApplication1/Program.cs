using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson2Task1
{
    class Program
    {
        /// <summary>
        /// Необходимо написать игру, развивающую навык быстро считать. 
        /// Пользователю дается одна минута, за это время он должен разгадать 
        /// как можно больше математических задачек, которые формируются автоматически с 
        /// помощью генератора случайных чисел.
        /// Пример задачки: «24 + 49 = ?».   
        /// Если пользователь дает неверный ответ или же после нажатия на 
        /// Enter минута истекла, то игра заканчивается. Пользователю сообщается
        /// его результат (число верных ответов) и лучший результат (число верных 
        /// ответов и дата игры). Если игроку удалось побить рекорд, программа должна 
        /// его поздравить и перезаписать лучший результат.   
        /// Для хранения информации между вызовами программы следует использовать 
        /// текстовый файл. Подходящий пример смотрите в примере ex_02_07. Необходимо 
        /// реализовать, по крайней мере, два вида задачек (скажем, сложение и вычитание),
        /// которые должны чередоваться случайным образом.  
        /// </summary>
        /// <param name="args"></param>
        /// 

        static void Main(string[] args)
        {
            int correctAnswer;
            int userAnswer;
            int score = 0;
            int bestScore;
            string bestScoreTime;
            Boolean keepPlaing = true;


            DateTime currentTime = DateTime.Now;
            DateTime endTime = currentTime.AddMinutes(1);

            string filename = "C:/Users/Jul/Documents/Visual Studio 2013/Projects/Training/Training/score.txt";
            if (File.Exists(filename))
            {

                string[] scoreArr = File.ReadAllLines(filename);
                bestScore = Convert.ToInt32(scoreArr[0]);
                bestScoreTime = scoreArr[1];
                Console.WriteLine("Start game ");
            }
            else
            {
                bestScore = 0;
                bestScoreTime = DateTime.Now.ToString();
                Console.WriteLine("File does not exist");
            }
            Console.WriteLine("The best score is: " + bestScore);
            System.Timers.Timer timer = new System.Timers.Timer();


            Console.WriteLine("------------------------------------");

            Random randomValue = new Random();
            do
            {
                int firstValue = randomValue.Next(1, 20);
                int secondValue = randomValue.Next(1, 20);

                int operation = randomValue.Next(1, 3);
                if (operation == 1)
                {
                    Console.Write(firstValue + " + " + secondValue + " = ");
                    correctAnswer = firstValue + secondValue;
                }
                else
                {
                    Console.Write(firstValue + " - " + secondValue + " = ");
                    correctAnswer = firstValue - secondValue;
                }

                string userAnswerString = Console.ReadLine();
                userAnswer = Convert.ToInt32(userAnswerString);

                if (correctAnswer == userAnswer)
                {
                    score = score + 1;
                }
                else
                {
                    keepPlaing = false;
                    Console.WriteLine("Answer is wrong");
                }


                if (endTime < DateTime.Now)
                {
                    keepPlaing = false;
                    Console.WriteLine("One minute is over.");
                }



            } while (keepPlaing);


            if (bestScore < score)
            {
                bestScore = score;
                string[] arrayWithBestScore = new string[2];
                arrayWithBestScore[0] = Convert.ToString(bestScore);
                arrayWithBestScore[1] = DateTime.Now.ToString();

                File.WriteAllLines(filename, arrayWithBestScore);

                Console.WriteLine("Your have the best score: " + score);
                // Console.WriteLine("The best score is: " + bestScore);
                Console.WriteLine("YOU WIN");

                Console.WriteLine("Game time is: " + arrayWithBestScore[1]);
            }
            else
            {
                Console.WriteLine("Your score is: " + score);
                Console.WriteLine("The best score is: " + bestScore);

                Console.WriteLine("Game time is: " + bestScoreTime);

                Console.WriteLine("The game is over");
            }

            Console.ReadKey();
        }

    }
}


