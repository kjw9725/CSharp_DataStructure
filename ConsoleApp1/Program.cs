using System;

namespace ConsoleApp1
{
    internal class Program
    {
        // 가장 큰값을 반환하는 함수(빈배열일때 0을 return)
        static int GetHighestScore(int[] scores)
        {
            int numb = 0;

            foreach(int score in scores)
            {
                if (score > numb) numb = score;
            }
            return numb;
        }

        // 평균값을 반환하는 함수(빈배열일때 0을 return)
        static int GetAverageScore(int[] scores)
        {
            int total = 0;

            if (scores.Length == 0) return 0;

            foreach (int score in scores)
            {
                total += score;
            }

            return total / scores.Length;
        }

        // value값이 있는지 확인하고 있으면 번호 없으면 -1을 반환하는 함수
        static int GetIndexOf(int[] scores, int value)
        {

            for(int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        // 작은수부터 앞에 오게 정렬하는 함수
        static void Sort(int[] scores)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex]){
                        minIndex = j;
                    }
                }
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }

        class Map
        {
            int[,] tiles =
            {
                // 1: 갈수없는곳, 0: 갈수있는곳
                {1,1,1,1,1 },
                {1,0,0,0,1 },
                {1,0,0,0,1 },
                {1,0,0,0,1 },
                {1,1,1,1,1 }
            };
            public void Render()
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    for (int x = 0; x < tiles.GetLength(0); x++)
                    {
                        if (tiles[x,y] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.Write('\u25cf');
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        class Monster
        {
            public int id;
            public Monster(int id) { this.id = id; }
        }

        static void Main(string[] args)
        {
            //★배열
            int[] scores = new int[5] {50, 20, 30, 40, 10 }; // 5개의 정수로 된 배열 score

            // 0 1 2 3 4(0번부터 시작)
            /*
            scores[0] = 50;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 10;
            */

            for(int i = 0; i < scores.Length; i++)
            {
                //Console.WriteLine(scores[i]);
            }

            foreach(int score in scores)
            {
                //Console.WriteLine(score);
            }

            Console.WriteLine(GetHighestScore(scores));
            Console.WriteLine(GetAverageScore(scores));
            Console.WriteLine(GetIndexOf(scores, 40));
            Sort(scores);


            //★다차원 배열
            int[] array = new int[5] { 10, 30, 40, 20, 50 };

            int[,] arr = new int[2, 3] { { 1,2,3 },{ 4,5,6 } }; //3(가로) X 2(세로)배열

            Map map = new Map();
            map.Render();


            //★List
            List<int> list = new List<int>(); // List<타입> 이름;
            for (int i = 0; i <5; i++)
                list.Add(i);

            // 삽입
            list.Insert(2, 999); // 3번째에 999를 삽입하고 원래 3번째이후에 있는것들은 한칸씩 밀린다
            // list[0] = 1; (list가 1개이상 있을때만 사용가능 권장x)

            // 삭제
            list.RemoveAt(0); // 0번째를 삭제
            bool success = list.Remove(3); // list안에서 제일 앞에있는 3을 제거하고 제거되었는지 아닌지를 bool 값으로 반환
            list.Clear(); // 전체 삭제

            // for문으로도 조회 가능하며 Length 대신 Count 사용
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            foreach(int num in list)
            {
                Console.WriteLine(num);
            }


            //★Dictionary
            List<int> monsterList = new List<int>();
            // 100만마리의 몬스터중에서 특정 몬스터를 찾을때 유용(Hashtable 기법)
            // Key -> Value
            // Dictionary

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for(int i = 0; i <10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            dic.TryGetValue(100000, out mon); // index를 초과해도 에러 없이 사용이 가능해 아래방법보다 유용
            // Monster mon = dic[5000];

            dic.Remove(7777);
            dic.Clear();

            // List와 Dictionary의 차이
            // List: 요소들을 순차적으로 저장하기때문에 일반적으로 요소의 삽입과 제거가 빠르다
            // Dictionary: 해시테이블로 구현되어 있으며 키를 기반으로 값을 검색하기 때문에 많은 요소에서 효율적인 검색가능 (단 순서에 의존하는 연산에서는 List보다 느릴수 있음)

        }
    }
}
