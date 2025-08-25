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
