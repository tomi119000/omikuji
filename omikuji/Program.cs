using System.Text;
Console.OutputEncoding = Encoding.UTF8;

string[] omikuji = new string[5];

omikuji[0] = "0大吉";
omikuji[1] = "1中吉";
omikuji[2] = "2吉";
omikuji[3] = "3凶";
omikuji[4] = "4大凶";

//string[] omikuji = {"0大吉", "1中吉", "2吉", "3凶", "4大凶"};

//各おみくじを何回引いたかを格納する配列
int[] count = new int[5];

// RandomクラスのNext命令を呼び出し、インスタンスを作成して乱数を取得
Random rand = new Random();
int result = rand.Next(0, 5); //0以上5未満の数をランダムに生成してresultに代入

// resultの値を配列かひっぱってきてコンソールに出す
Console.WriteLine(omikuji[result]);

//for (int i=0; i<100; i++) //i：カウンタ変数（index i）、i++: インクリメント演算子
//{
//    Console.WriteLine("今" + i + "回目の繰り返しです");
//}

for (int i= 0; i< 100; i++)
{
    result = rand.Next(0, 5);
    Console.WriteLine(omikuji[result]);
    count[result]++; //resultで引いた結果の番号をカウントアップする
}

//配列countの結果を順番に表示する
for (int i=0; i< count.Length; i++)
{
    Console.WriteLine(omikuji[i] + "は" + count[i] + "回引きました");
}