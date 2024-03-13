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
        static void Main(string[] args)
        {
            // 배열
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
        }
    }
}
