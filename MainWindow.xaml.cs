using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AoTTG_Tools
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_Transparency_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int value = int.Parse(TextBox_Transparency.Text);
                if (value < 0)
                {
                    TextBox_Transparency.Text = "0";
                }
                else if (value > 100)
                {
                    TextBox_Transparency.Text = "100";
                }
            }
            catch
            {
                TextBox_Transparency.Text = "";
            }
        }

        private void TextBox_Red_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int value = int.Parse(TextBox_Red.Text);
                if (value < 0)
                {
                    TextBox_Red.Text = "0";
                }
                else if (value > 255)
                {
                    TextBox_Red.Text = "255";
                }
            }
            catch
            {
                TextBox_Red.Text = "";
            }
        }
        private void TextBox_Green_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int value = int.Parse(TextBox_Green.Text);
                if (value < 0)
                {
                    TextBox_Green.Text = "0";
                }
                else if (value > 255)
                {
                    TextBox_Green.Text = "255";
                }
            }
            catch
            {
                TextBox_Green.Text = "";
            }
        }
        private void TextBox_Blue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int value = int.Parse(TextBox_Blue.Text);
                if (value < 0)
                {
                    TextBox_Blue.Text = "0";
                }
                else if (value > 255)
                {
                    TextBox_Blue.Text = "255";
                }
            }
            catch
            {
                TextBox_Blue.Text = "";
            }
        }

        private void Button_Convert_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Output.Text = "";
            if (TextBox_Input.Text.Length <= 0)
            {
                TextBox_Input.Text = "Put some Map script here :v";
            }
            else if (TextBox_Red.Text.Equals("") ||
                TextBox_Green.Text.Equals("") ||
                TextBox_Blue.Text.Equals(""))
            {
                TextBox_Output.Text = "All Text Boxes must have value";
                return;
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                string[] script = TextBox_Input.Text.Split('\n');
                foreach (string line in script)
                {
                    string[] split = line.Replace("\r", "").Split(',');
                    string temp = "";
                    if (split[0].Equals("racing") && split.Length == 12 && split[1].StartsWith("kill"))
                    {
                        List<string> list = split.ToList();
                        list[0] = "custom";
                        list.Insert(2, "transparent" + (float.Parse(TextBox_Transparency.Text) / 100f).ToString());
                        list.Insert(6, "1");
                        list.Insert(7, (float.Parse(TextBox_Red.Text) / 255f).ToString());
                        list.Insert(8, (float.Parse(TextBox_Green.Text) / 255f).ToString());
                        list.Insert(9, (float.Parse(TextBox_Blue.Text) / 255f).ToString());
                        list.Insert(10, "0");
                        list.Insert(11, "0");
                        foreach (string s in list)
                        {
                            temp += s + ',';
                        }
                        _ = builder.Append(temp.Substring(0, temp.Length - 2) + ";\n");
                    }
                    _ = builder.Append(line + "\n");
                }
                TextBox_Output.Text = builder.ToString();
            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Output.Text = "";
        }

        private void Button_Help_Click(object sender, RoutedEventArgs e)
        {
            _ = MessageBox.Show(Window_,
                "Just a Help Button :/\n" +
                "Ok, just kidding...\n\n" +
                "Step 1. Put your Custom map script in input TextBox\n" +
                "Step 2. add a values in TextBoxes\n" +
                "Step 3. Click Convert button\n" +
                "Step 4. Copy the Map script in Output TextBox\n" +
                "And your Done!, easy as that\n\n" +
                "Credits:\n" +
                "Original Source, Python Script\n" +
                "-Zender\n" +
                "GUI Version\n" +
                "-Nexus\n\n" +
                "Report bugs to Nexus\n" +
                "HaveFun!!!\n"
                , "Help!", MessageBoxButton.OK, MessageBoxImage.Question, MessageBoxResult.None, MessageBoxOptions.None);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "<Pending>")]
        private void OutputColor()
        {
            //ColorOut.Background = Color.FromRgb(byte.Parse(TextBox_Red.Text), byte.Parse(TextBox_Green.Text), byte.Parse(TextBox_Blue.Text));
        }
    }
}
