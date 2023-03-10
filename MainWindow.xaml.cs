using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rayreth_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\loicw\AppData\Local\Programs\Termius\Termius.exe";
            Process.Start(filePath);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string bravePath = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
            string wordPath = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            Process.Start(bravePath);
            Process.Start(wordPath);
        }

        private void Code_Click(object sender, RoutedEventArgs e)
        {
            string discordPath = @"C:\Users\loicw\AppData\Local\DiscordCanary\app-1.0.57\DiscordCanary.exe";
            string vscodePath = @"C:\Users\loicw\AppData\Local\Programs\Microsoft VS Code\Code.exe";
            string terminusPath = @"C:\Users\loicw\AppData\Local\Programs\Termius\Termius.exe";
            string mysqlworkbenchPath = @"C:\Program Files\MySQL\MySQL Workbench 8.0 CE\MySQLWorkbench.exe";
            string bravePath = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
            string ytmusicPath = @"C:\Users\loicw\Downloads\YouTube-Music-1.19.0.exe";
            Process.Start(discordPath);
            Process.Start(vscodePath);
            Process.Start(terminusPath);
            Process.Start(mysqlworkbenchPath);
            Process.Start(bravePath);
            Process.Start(ytmusicPath);
        }

        private void More_Click(object sender, RoutedEventArgs e)
        {
            more_options more = new more_options();
            more.Show();
            this.Close();
        }

        private void codestudio_Click(object sender, RoutedEventArgs e)
        {
            string discordPath = @"C:\Users\loicw\AppData\Local\DiscordCanary\app-1.0.57\DiscordCanary.exe";
            string vsstudioPath = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";
            string terminusPath = @"C:\Users\loicw\AppData\Local\Programs\Termius\Termius.exe";
            string mysqlworkbenchPath = @"C:\Program Files\MySQL\MySQL Workbench 8.0 CE\MySQLWorkbench.exe";
            string bravePath = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
            string ytmusicPath = @"C:\Users\loicw\Downloads\YouTube-Music-1.19.0.exe";
            Process.Start(discordPath);
            Process.Start(vsstudioPath);
            Process.Start(terminusPath);
            Process.Start(mysqlworkbenchPath);
            Process.Start(bravePath);
            Process.Start(ytmusicPath);
        }

        private void chill_Click(object sender, RoutedEventArgs e)
        {
            string discordPath = @"C:\Users\loicw\AppData\Local\DiscordCanary\app-1.0.57\DiscordCanary.exe";
            string bravePath = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
            Process.Start(discordPath);
            Process.Start(bravePath);
        }
    }
}
