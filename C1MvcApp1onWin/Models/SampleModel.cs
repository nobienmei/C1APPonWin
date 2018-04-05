using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C1MvcApp1onWin.Models
{
    // Chart用サンプルエンティティ
    public class DailySale
    {
        public DateTime Date { get; set; }
        public int? TotalSales { get; set; }
        public int? AsiaSales { get; set; }
        public int? JapanSales { get; set; }
    }

    // サンプルモデルクラス
    public class SampleModel
    {
        // チャートに表示する値は乱数から作成
        private static readonly Random rand = new Random(0);

        // チャートに表示するデータ
        public IEnumerable<DailySale> Sales { get; } = Enumerable.Range(0, 92)
            .Select(index => new DailySale()
            {
                Date = new DateTime(DateTime.Today.Year, 1, 1).AddDays(index),
                JapanSales = rand.Next(0, 100),
                AsiaSales = rand.Next(100, 200),
                TotalSales = rand.Next(200, 300)
            });

        // Guageに表示するデータ
        public int GuageValue { get; set; } = 30;

        // InputNumberのデータ
        public int InputValue { get; set; } = 567;

        // InputDatetimeのデータ
        public DateTime InputDatetime { get; set; } = DateTime.Now;

        // MultiAutoCompleteのデータ
        public List<string> Todofuken { get; set; } = new List<string>
        {
            "Hokkaido",
            "Aomori", "Iwate", "Miyagi", "Akita", "Yamagata", "Fukushima",
            "Ibaraki", "Tochigi", "Gunma", "Saitama", "Chiba", "Tokyo", "Kanagawa",
            "Niigata", "Toyama", "Ishikawa", "Fukui", "Yamanashi", "Nagano", "Gifu", "Shizuoka", "Aichi",
            "Mie", "Shiga", "Kyoto", "Osaka", "Hyogo", "Nara", "Wakayama",
            "Tottori", "Shimane", "Okayama", "Hiroshima", "Yamaguchi",
            "Tokushima", "Kagawa", "Ehime", "KOchi",
            "Fukuoka", "Saga", "Nagasaki", "Kumamoto", "Oita", "Miyazaki", "Kagoshima", "Okinawa",
        };

    }
}
