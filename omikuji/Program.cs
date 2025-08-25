using System.Collections;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

//おみくじ
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

//for (int i=0; i<100; i++) //i：カウンタ変数（index i）、i++: インクリメント演算子
//{
//    Console.WriteLine("今" + i + "回目の繰り返しです");
//}

//for (int i = 0; i< 100; i++)
//{
//    int result = rand.Next(0, 5);
//    Console.WriteLine(omikuji[result]);
//    count[result]++; //resultで引いた結果の番号をカウントアップする
//}

//配列countの結果を順番に表示する
//for (int i= 0; i< count.Length; i++)
//{
//    Console.WriteLine(omikuji[i] + "は" + count[i] + "回引きました");
//}

//// 論理型
//bool end = false; // 終わりフラグ
//// いつ終わりが来るかわからないループ
//while (end == false) //終わりのフラグがこない間は繰り返す
//{
//    int dice = rand.Next(1, 7); //1以上7未満の数をランダムに生成
//    if (dice == 1)
//    {
//        end = true; //終わりのフラグを立てる
//    }
//    Console.WriteLine("つづく"); 
//}

// 大吉を引いたら繰り返しループをやめて終了する
bool end = false; // 終わりフラグ
while (!end) //endはfalseであるかどうか→成立していれば繰り返す
{
    int result = rand.Next(0, 5); //ランダムに0~4の数を生成
    Console.WriteLine(omikuji[result]);
    count[result]++; //resultで引いた結果の番号をカウントアップする

    if (result ==0)
    {
        end = true; //大吉(= omikuji[0])を引いたら終わりのフラグを立てる
    }
}

//配列countの結果を順番に表示する
for (int i=0; i< count.Length; i++)
{
    Console.WriteLine(omikuji[i] + "は" + count[i] + "回引きました");
}