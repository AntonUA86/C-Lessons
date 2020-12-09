using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Qustion
    {   
        
        int num ;
        int countRightAnswer = 0;
        bool test = false;
        private string[] arrayQuestions = new string[]{
                  "Что храниться в типе данных Boolean ?",
                   "Какой Диапазон (бит) в типе данных Byte ?",
                   "Какой Диапазон (бит) в типе данных Int32 ?",
                   "Какой Диапазон (бит) в типе данных UInt16 ?"
             };


        private string[] arrayAnswers = new string[]
          {
                  " 1: true или false                              2: хранит целое число от 0 до 65535",
                  " 1: От 0 до 255                                 2: От -255 до 255",
                  " 1:  От -2 147 483 648 до 2 147 483 647         2: От 0 до 4 294 967 295",
                  " 1: От -128 до 127                              2: От 0 до 65 535",



          }; 
         private readonly int[]  arrayRightAnswers = { 1, 2, 1, 2 };

        private void testa()
        {
            if (test == true)
                countRightAnswer++;
            test = false;
           
        }

        private void checkAnswer(){
            num = int.Parse(Console.ReadLine());;
            for (int i = 0; i < arrayRightAnswers.Length; i++)
            {
                if (num == arrayRightAnswers[i])
                {
                   test = true;
                    arrayRightAnswers[i] = 0;
                    break;
                }
                    
                else test = false;
            }
      
            
        }


        public void start()
        {
            Console.WriteLine("Здравствуйте!!! Добро пожаловать на викторину \n");
            questionPrint();
        }

        private void questionPrint()
        {
           for (int i = 0; i < arrayQuestions.Length; i++)
            {
                    Console.WriteLine($"Вопрос номер {i + 1}:\n {arrayQuestions[i]}\n");
                    Console.WriteLine("\nВаринаты ответа " + arrayAnswers[i]);
                
                checkAnswer();
                testa();
            }
            Console.WriteLine($"Количество правильных ответов = {countRightAnswer}");
        }
        }

    }



