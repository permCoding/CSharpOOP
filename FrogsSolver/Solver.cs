using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogsSolver
{
    class SolverQueue_1 // на 1 шаг в глубину
    {
        private string Start { get; set; }

        private int length; // просто для удобства - длина поля лягушек

        private int maxStep = 2; // для универсальности

        public Queue<string> que; // очередь текущих позиций игры
        public SolverQueue_1(string start)
        {
            Start = start;
            length = start.Length; // ширина поля
            que = new Queue<string>();
            que.Enqueue(Start);
        }
        public void FindNext()
        {
            string first = que.Dequeue();
            for (int i = 0; i < length; i++) // проверяем все индексы строки в позиции игры
            {
                for (int step = 1; step <= maxStep; step++) // проверяем возможные длины хода
                {
                    if ((first[i] == 'X') && ((i + step) < length) && (first[i + step] == '_'))
                    {
                        char[] arr = first.ToCharArray();
                        arr[i] = '_'; arr[i + step] = 'X';
                        que.Enqueue(String.Join("", arr));
                    }
                    if ((first[i] == 'O') && ((i - step) >= 0) && (first[i - step] == '_'))
                    {
                        char[] arr = first.ToCharArray();
                        arr[i] = '_'; arr[i - step] = 'O';
                        que.Enqueue(String.Join("", arr));
                    }
                }
            }
        }
    }
    class SolverQueue_2 // на 1 шаг в глубину со списками ходов предыдущих
    {
        private string Start { get; set; }

        private int length; // просто для удобства - длина поля лягушек

        private int maxStep = 2;

        public Queue<List<string>> que; // очередь текущих позиций игры
        public SolverQueue_2(string start)
        {
            Start = start;
            length = start.Length; // ширина поля
            que = new Queue<List<string>>();
            que.Enqueue(new List<string> { Start });
        }
        public void FindNext()
        {
            List<string> firstList = que.Dequeue();
            string first = firstList.Last();
            for (int i = 0; i < length; i++) // проверяем все индексы строки в позиции игры
            {
                for (int step = 1; step <= maxStep; step++) // проверяем возможные длины хода
                {
                    if ((first[i] == 'X') && ((i + step) < length) && (first[i + step] == '_'))
                    {
                        char[] arr = first.ToCharArray();
                        arr[i] = '_'; arr[i + step] = 'X';
                        List<string> tmp = firstList.GetRange(0, firstList.Count());
                        tmp.Add(String.Join("", arr));
                        que.Enqueue(tmp);
                    }
                    if ((first[i] == 'O') && ((i - step) >= 0) && (first[i - step] == '_'))
                    {
                        char[] arr = first.ToCharArray();
                        arr[i] = '_'; arr[i - step] = 'O';
                        List<string> tmp = firstList.GetRange(0, firstList.Count());
                        tmp.Add(String.Join("", arr));
                        que.Enqueue(tmp);
                    }
                }
            }
        }
    }
    class SolverQueue_3 // до нахождения конечного состояния со списками ходов предыдущих
    {
        private string Start { get; set; }
        private string Stop { get; set; } // конечная успешная позиция

        private int length; // просто для удобства - длина поля лягушек

        private int maxStep = 2;

        public Queue<List<string>> que; // очередь текущих позиций игры

        private bool check = true; // для прерывания поиска после найденного решения
        public SolverQueue_3(string start)
        {
            Start = start;
            length = start.Length; // ширина поля
            que = new Queue<List<string>>();
            que.Enqueue(new List<string> { Start });

            Stop = new string('O', length/2) + '_' + new string('X', length/2);
        }
        public SolverQueue_3(string start, string stop)
        {
            Start = start;
            length = start.Length; // ширина поля
            que = new Queue<List<string>>();
            que.Enqueue(new List<string> { Start });

            Stop = stop;
        }
        public void FindNext()
        {
            while (check && (que.Count > 0))
            {
                List<string> firstList = que.Dequeue();
                string first = firstList.Last();
                for (int i = 0; i < length; i++) // проверяем все индексы строки в позиции игры
                {
                    for (int step = 1; step <= maxStep; step++) // проверяем возможные длины хода
                    {
                        if ((first[i] == 'X') && ((i + step) < length) && (first[i + step] == '_'))
                        {
                            char[] arr = first.ToCharArray();
                            arr[i] = '_'; arr[i + step] = 'X';
                            List<string> tmp = firstList.GetRange(0, firstList.Count());
                            string nextStep = String.Join("", arr);
                            tmp.Add(nextStep);
                            que.Enqueue(tmp);
                            if (nextStep == Stop) check = false; // нашли решение
                        }
                        if ((first[i] == 'O') && ((i - step) >= 0) && (first[i - step] == '_'))
                        {
                            char[] arr = first.ToCharArray();
                            arr[i] = '_'; arr[i - step] = 'O';
                            List<string> tmp = firstList.GetRange(0, firstList.Count());
                            string nextStep = String.Join("", arr);
                            tmp.Add(nextStep);
                            que.Enqueue(tmp);
                            if (nextStep == Stop) check = false; // нашли решение
                        }
                    }
                }
            }
        }
    }
}
