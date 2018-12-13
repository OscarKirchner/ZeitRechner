using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;
using WpfApplication1.Resources;

namespace WpfApplication1
{
    /// <summary>
    /// Interaktionslogik für Einstellungen.xaml
    /// </summary>
    public partial class Einstellungen : Window
    {
        public XmlSerializer xs;
        public List<DefaultWerte> ls;
        public static string path = "%appdata%";
        IMainFrame MainFrame;
        public Einstellungen()
        {
            MainFrame = MainWindow.Me;
            InitializeComponent();
            checkBox.IsChecked = MainFrame.IsSnowing(); //Kann Ab januar Deaktiviert WERDEN! NEIN!
            if (checkBox.IsChecked == true)
            {
                label2_Copy.IsEnabled = false;
                comboBox.IsEnabled = false;
            }
            else
            {
                checkBox.IsChecked = false;
                label2_Copy.IsEnabled = true;
                comboBox.IsEnabled = true;
            }

            Oeffnet();
            ls = new List<DefaultWerte>();
            xs = new XmlSerializer(typeof(List<DefaultWerte>));
            try
            {
                FileStream fr = new FileStream(path, FileMode.Open, FileAccess.Read);
                ls = (List<DefaultWerte>)xs.Deserialize(fr);
                int i = ls.Count;
                i = i - 1;
                textBox.Text = ls[i].ZeitGuthaben;
                textBox_Copy.Text = ls[i].GekommenH;
                textBox_Copy1.Text = ls[i].GekommenM;
                textBox_Copy2.Text = ls[i].Pause;
                textBox_Copy3.Text = ls[i].WillGehenH;
                textBox_Copy4.Text = ls[i].WillGehenM;
                textBox_Copy5.Text = ls[i].Wunschfaktor;
                if (ls[i].Winter == "True")
                {
                    checkBox.IsChecked = true;
                }
                else
                {
                    checkBox.IsChecked = false;
                }

                if (ls[i].BackColor == "WhiteB")
                {
                    comboBox.SelectedItem = WhiteB;
                }
                else if (ls[i].BackColor == "DarkGrayB")
                {
                    comboBox.SelectedItem = DarkGrayB;
                }
                else if (ls[i].BackColor == "GreenB")
                {
                    comboBox.SelectedItem = GreenB;
                }
                else if (ls[i].BackColor == "LightBlueB")
                {
                    comboBox.SelectedItem = LightBlueB;
                }
                else if (ls[i].BackColor == "RosaB")
                {
                    comboBox.SelectedItem = RosaB;
                }
                else if (ls[i].BackColor == "LightCoralB")
                {
                    comboBox.SelectedItem = LightCoralB;
                }
                else if (ls[i].BackColor == "LightYellowB")
                {
                    comboBox.SelectedItem = LightYellowB;
                }
                else if (ls[i].BackColor == "BlackB")
                {
                    comboBox.SelectedItem = BlackB;
                }
                else if (ls[i].BackColor == "RealBlackB")
                {
                    comboBox.SelectedItem = RealBlackB;
                }
                else if (ls[i].BackColor == "BuntB")
                {
                    comboBox.SelectedItem = BuntB;
                }

                fr.Close();
            }
            catch (Exception ex)
            {
                //    comboBox.SelectedItem = LightCoralB; //auf weiß ändern im januar
                comboBox.SelectedItem = WhiteB; //auf weiß ändern im januar

            }
        }


        public void Oeffnet()
        {
            textBlock.Text = "[Changelog:]" +
                 "\n-v1_1:         Hinzufügen der Zeit, wann man gehen möchte" +
                 "\n-v1_1_1:     Keyboard-Kontrolle hinzugefügt" +
                 "\n-v1_1_2:     Bug fixes" +
                 "\n-v1_2:         Wunschfaktor berechnen" +
                 "\n-v1_2_1:     Bug fixes" +
                 "\n-v1_3:         Wunschfaktor auch kleiner als aktueller Faktor möglich" +
                 "\n-v1_3_1:     Bug fixes und Anpassungen der Grenzwerte und" +
                 "\n                  Messageboxen" +
                 "\n-v1_3_2:     Tooltipps mit Beispielen zu den jeweiligen Labels" +
                 "\n                  hinzugefügt und Formulierungen angepasst" +
                 "\n-v1_3_3:     Noch mehr Tasten-Controlls hinzugefügt" +
                 "\n-v1_3_4:     Bug fixes bei Wunschfaktor < Zeitguthaben" +
                 "\n-v1_3_5:     WinterSpecial hinzugefügt" +
                 "\n-v1_3_6:     Feldeingabe auf Numeric beschränkt" +
                 "\n-v1_4:         Einstellungsmenü statt Infobox" +
                 "\n-v1_4_1:     Bug fixes" +
                 "\n-v1_4_2:     Einstellungsmenü Allg. freigeschalten" +
                 "\n-v1_4_3:     Bug fixes und Anpassung in den allg. Einstellungen" +
                 "\n[-v1_5:        Wintermodus optional und Hintergrundfarben]*" +
                 "\n-v1_5_1:     Bug fixes, Neustart nach Speicherung, mehr Farben" +
                 "\n-v1_5_2:     Vorerst Finale Version auch Firmenübergreifend" +
                 "\n-v1_5_3:     Ende, neue Version (v2_0) findet ihr in meinem Transfer oder ihr schreibt mir eine Email." +
                 "\n\nGeplant:" +
                 "\n-Auto-Jump bei den Uhrzeitfeldern" +
                 "\n-Sprachen DE und EN" +
                 "\n-Bei weiteren Ideen: schreibt mir gerne eine Email" +
                 "\n\nMit [..]* gekennzeichnete Versionen wurden nicht öffentlich released." +
                // "\n>Zur Zeit sind alle Ideen umgesetzt. Wenn euch was ein-/auffällt, schreibt mir gerne eine Email." +
                "";
            textBlock1.Text = "" +
                "\nDiese Anwendung wurde von Oscar Kirchner zur Errechnung der Kompensationszeiten " +
                "bei der ines GmbH Konstanz geschrieben. " +
                "\nSeit der Umstellung auf ein anderes System wird der Rechner bei ines nichtmehr benötigt. Allerdings nutzen viele Firmen diese Art der Abrechnung und somit ist das Programm ab jetzt für alle verfügbar. Auf GitHub findet ihr den kompletten Code." +
                "\n\nVerbesserungsvorschläge oder Bugs gerne an kirchner.oscar@googlemail.com" +
                "";
            textBlock3.Text = "\n- Per TAB- und Enter-Taste könnt ihr das Programm ohne Maus nutzen." +
                "\n- Dein Wunschfaktor kann größer oder kleiner als dein aktuelles Zeitguthaben sein. Auch die Zeit, zu der du heute gehen magst kannst" +
                "\ndu unabhängig von allem Anderen eintragen." +
                "\n- '24:00 Uhr' solltest du als '00:00 Uhr' angeben, sonst bekommst du einen Fehler. Liegt aber sowieso ausserhalb der Regelzeiten." +
                "\n- Wenn ihr den Wintermodus aktiviert habt, wird die Hintergrundfarbe immer automatisch auf Rot gesetzt." +
                "\n- Mit der ESC-Taste lässt sich das Programm schließen. Diese Infobox lässt sich mit der I-Taste öffnen." +
                "\n- Ihr könnt bis Faktor +/- 6,00 Rechnen, denkt aber bitte daran, dass eigentlich max. +/- 4 Stunden an einem Tag ausgeglichen werden können." +
                "\n- Ihr könnt eure eigenen Defaultwerte in den Einstellungen festlegen, diese werden unter '%appdata%' gespeichert." +
                "\n- Denk daran, dass in der ines-Zeiterfassung abgerundet wird. Wird dir also als neuer Faktor '1,48666..' angezeigt wird, hast du nachher '1,48' auf deinem konto, nicht '1,49'." +
                "\n- Es kann zu sog. weichen Fehlern kommen, zB. wenn die angegebene Pausenzeit nicht mindestens 30 Minuten beträgt. Diese werden durch eine Meldung mit dem Titel 'Achtung' gekennzeichnet, der Zeitrechner rechnet aber trotzdem. Bitte beachte, dass es in so einem Fall zu Fehlern kommen kann." +
                "\n\n*- Die minimalen Ungenauigkeiten sind immer zu eurem 'Besten'. Es kann also sein, dass ihr eine Minute länger bleibt als nötig, damit die angegebene Zielzeit sicher erreicht wird. Es ist jedoch niemals so, dass euch die App in den Feierabend schickt, ihr aber den gewünschten Faktor verfehlt. Allerdings bleibt auch das ohne Gewähr." +                
                "";
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            string completeString = null;
            if (sender is TextBox)
            {
                TextBox tb = ((TextBox)sender);
                string currentText = tb.Text.Remove(tb.SelectionStart, tb.SelectionLength);
                currentText.Insert(tb.CaretIndex, e.Text);
                completeString = currentText.Insert(tb.CaretIndex, e.Text);
            }
            Regex regex = new Regex(@"^([+-]?(((6(,)?)|(6,0{1,2}))|([0-5](,)?)|([0-5],\d{1,2}?))?)$");
            e.Handled = !regex.IsMatch(completeString);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(e.Uri.AbsoluteUri);
            e.Handled = true;
        }


        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            if (!MainFrame.IsSnowing())
            {
                MainFrame.StartSnow();
                comboBox.SelectedItem = LightCoralB;
                label2_Copy.IsEnabled = false;
                comboBox.IsEnabled = false;
            }
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (MainFrame.IsSnowing())
            {
                MainFrame.StopSnow();
                comboBox.SelectedItem = WhiteB;
                label2_Copy.IsEnabled = true;
                comboBox.IsEnabled = true;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (checkBox.IsChecked == true)
                {
                    ((ComboBoxItem)comboBox.SelectedItem).Name = "LightCoralB";
                }
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                DefaultWerte sc = new DefaultWerte();
                sc.ZeitGuthaben = textBox.Text;
                sc.GekommenH = textBox_Copy.Text;
                sc.GekommenM = textBox_Copy1.Text;
                sc.Pause = textBox_Copy2.Text;
                sc.WillGehenH = textBox_Copy3.Text;
                sc.WillGehenM = textBox_Copy4.Text;
                sc.Wunschfaktor = textBox_Copy5.Text;
                sc.Winter = checkBox.IsChecked.ToString();
                sc.BackColor = ((ComboBoxItem)comboBox.SelectedItem).Name;
                //sc.Sprache = radioButton.IsChecked.ToString();
                ls.Add(sc);
                xs.Serialize(fs, ls);
                fs.Close();
                if (checkBox.IsChecked == true)
                {
                    if (MessageBox.Show("Deine Defaultwerte wurden zurückgesetzt.\n\nAchtung: Da du den Wintermodus aktiviert hast, wurde die Hintergrundfarbe automatisch auf Rot gesetzt. Wenn du eine andere Farbe willst, musst du das Winterspecial deaktivieren.\n\nBeim nächsten Neustart treten deine Änderungen in Kraft.\n\nMöchtest du den Zeitrechner jetzt neustarten?", "Speichern Erfolgreich", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                        Application.Current.Shutdown();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    if (MessageBox.Show("Deine Defaultwerte wurden gespeichert.\n\nBeim nächsten Neustart treten deine Änderungen in Kraft.\n\nMöchtest du den Zeitrechner jetzt neustarten?", "Speichern Erfolgreich", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                        Application.Current.Shutdown();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //checkBox.IsChecked = true; //im januar anpassen
            checkBox.IsChecked = false;

            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                DefaultWerte sc = new DefaultWerte();
                sc.ZeitGuthaben = "0,00";
                sc.GekommenH = "08";
                sc.GekommenM = "00";
                sc.Pause = "30";
                sc.WillGehenH = "17";
                sc.WillGehenM = "00";
                sc.Wunschfaktor = "2,5";
                // sc.Sprache = radioButton.IsChecked.ToString();

                sc.Winter = checkBox.IsChecked.ToString(); //im januar anpassen (bzw wird oben angepasst)
                //sc.BackColor = "LightCoralB"; //im januar anpassen
                sc.BackColor = "WhiteB"; //im januar anpassen

                ls.Add(sc);
                xs.Serialize(fs, ls);
                fs.Close();
                if (MessageBox.Show("Deine Defaultwerte wurden zurückgesetzt.\n\nBeim nächsten Neustart treten deine Änderungen in Kraft.\n\nMöchtest du den Zeitrechner neustarten?", "Reset Erfolgreich", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
                    Application.Current.Shutdown();
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
