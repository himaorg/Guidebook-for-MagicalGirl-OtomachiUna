using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System;
using System.IO;

namespace 魔法少女音街ウナ解説書;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenMarkdown(string filePath)
    {
        if (File.Exists(filePath))
        {
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }
        else
        {
            MessageBox.Show("ファイルが見つかりません: " + filePath, "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    // AI
    private void About_V1_0(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\AI\V1.0\About_V1.0.md");
    private void フェールセーフ(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\AI\V1.0\フェールセーフ.md");
    private void About_V2_0(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\AI\V2.0\About_V2.0.md");
    private void ツクヨミ(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\AI\V2.0\ツクヨミ.md");

    // Economy
    // 人財商取引界隈
    private void モンスター教孤児院(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\人財商取引界隈\モンスター教孤児院.md");
    private void 労働者(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\人財商取引界隈\労働者.md");
    private void 労働者ギルド(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\人財商取引界隈\労働者ギルド.md");
    private void 人財取引関係図(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\人財商取引界隈\人財取引関係図.md");
    private void 孤児(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\人財商取引界隈\孤児.md");
    private void 魔法少女(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\魔法少女.md");
    private void 魔法少女ギルド(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\人財商取引界隈\魔法少女ギルド.md");

    // 宗教商取引界隈
    // 空飛ぶうどんモンスター教
    private void 教義(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\宗教商取引界隈\空飛ぶうどんモンスター教\教義.md");
    private void 宗教取引関係図(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\宗教商取引界隈\宗教取引関係図.md");

    // 工芸品商取引界隈
    private void 工芸品取引関係図(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\工芸品商取引界隈\工芸品取引関係図.md");

    // 知恵商取引界隈
    private void GF学者(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\知恵商取引界隈\GF学者.md");
    private void 魔法少女学者(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\industry-classification\知恵商取引界隈\魔法少女学者.md");

    private void economic_theory(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Economy\economic_theory.md");

    // Human
    // Species
    // dvelg
    // Ethnicity
    private void craftドヴェルグ(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\dvelg\Ethnicity\craftドヴェルグ.md");
    private void smisドヴェルグ(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\dvelg\Ethnicity\smisドヴェルグ.md");


    // god
    //Ethnicity
    private void 創造神(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\god\Ethnicity\創造神.md");
    private void 守護神(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\god\Ethnicity\守護神.md");
    private void 愛の神(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\god\Ethnicity\愛の神.md");
    private void 戦神(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\god\Ethnicity\戦神.md");
    private void 死神(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\god\Ethnicity\死神.md");
    private void 知恵の神(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\god\Ethnicity\知恵の神.md");
    private void 自然神(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\god\Ethnicity\自然神.md");
    private void 豊穣神(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\god\Ethnicity\豊穣神.md");

    // homus
    // Ethnicity
    // unity_homus
    private void ウノー(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unity_homus\ウノー.md");
    private void サノー(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unity_homus\サノー.md");
    private void ルブラン(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unity_homus\ルブラン.md");
    private void 克人(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unity_homus\克人.md");
    private void 希実(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unity_homus\希実.md");
    private void 潤(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unity_homus\潤.md");
    private void 空(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unity_homus\空.md");
    private void 音街ウナ(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unity_homus\音街ウナ.md");

    // homus
    // Ethnicity
    // unreal_homus
    private void キリスト(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unreal_homus\キリスト.md");
    private void ナポレオン(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unreal_homus\ナポレオン.md");
    private void ヒトラー(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unreal_homus\ヒトラー.md");
    private void 概要(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Human\Species\homus\Ethnicity\unreal_homus\概要.md");

    // Joker
    // Ethnicity
    private void 寝そべり族(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Joker\Ethnicity\寝そべり族.md");
    private void 無敵の男の人(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Joker\Ethnicity\無敵の男の人.md");

    private void Joker_About(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\Joker\Joker_About.md");

    // 空飛ぶうどんモンスター教
    // 役職や階級
    private void 教皇(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\空飛ぶうどんモンスター教\役職や階級\教皇.md");
    private void 枢機卿(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\空飛ぶうどんモンスター教\役職や階級\枢機卿.md");
    private void 大司教(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\空飛ぶうどんモンスター教\役職や階級\大司教.md");
    private void 司教(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\空飛ぶうどんモンスター教\役職や階級\司教.md");
    private void 司祭(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\空飛ぶうどんモンスター教\役職や階級\司祭.md");
    private void 助祭(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\空飛ぶうどんモンスター教\役職や階級\助祭.md");

    // 本部と支部
    private void アトランティス本部(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\空飛ぶうどんモンスター教\本部と支部\アトランティス本部.md");
    private void クル支部(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\空飛ぶうどんモンスター教\本部と支部\クル支部.md");

    // 軍需物資
    private void ドヴェルグOS(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\軍需物資\OS\ドヴェルグOS.md");
    private void 時空メス(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\軍需物資\Script\時空メス.md");
    private void オーガベイン(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\軍需物資\手持ち武器\オーガベイン.md");
    private void フレイブレイド(object sender, RoutedEventArgs e) => OpenMarkdown(@"..\..\..\軍需物資\手持ち武器\フレイブレイド.md");


}
