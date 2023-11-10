using System;
using System.Collections.Generic;
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

namespace Клавиатурный_тренажер
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<Key, Label> keyValuePairs = new Dictionary<Key, Label>();
        private bool isPress = false;

        
        public MainWindow()
        {
            InitializeComponent();
            AddKeys();
            txb1.Text = "";
            this.KeyDown += Label_KeyDown;
            this.KeyUp += Label_KeyUp;
            txb1.KeyDown += txb1_KeyDown;
            
        }
        private void AddKeys()
        {
            keyValuePairs.Add(Key.Q, lbl_Q);
            keyValuePairs.Add(Key.W, lbl_W);
            keyValuePairs.Add(Key.E, lbl_E);
            keyValuePairs.Add(Key.R, lbl_R);
            keyValuePairs.Add(Key.T, lbl_T);
            keyValuePairs.Add(Key.Y, lbl_Y);
            keyValuePairs.Add(Key.U, lbl_U);
            keyValuePairs.Add(Key.I, lbl_I);
            keyValuePairs.Add(Key.O, lbl_O);
            keyValuePairs.Add(Key.P, lbl_P);
            //keyValuePairs.Add(Key.R, lbl_sym1);
            //keyValuePairs.Add(Key.R, lbl_sym2);
            keyValuePairs.Add(Key.A, lbl_A);
            keyValuePairs.Add(Key.S, lbl_S);
            keyValuePairs.Add(Key.D, lbl_D);
            keyValuePairs.Add(Key.F, lbl_F);
            keyValuePairs.Add(Key.G, lbl_G);
            keyValuePairs.Add(Key.H, lbl_H);
            keyValuePairs.Add(Key.J, lbl_J);
            keyValuePairs.Add(Key.K, lbl_K);
            keyValuePairs.Add(Key.L, lbl_L);
            //keyValuePairs.Add(Key.P, lbl_sym3);
            //keyValuePairs.Add(Key.P, lbl_sym4);
            //keyValuePairs.Add(Key.P, lbl_sym5);
            keyValuePairs.Add(Key.Z, lbl_Z);
            keyValuePairs.Add(Key.X, lbl_X);
            keyValuePairs.Add(Key.C, lbl_C);
            keyValuePairs.Add(Key.V, lbl_V);
            keyValuePairs.Add(Key.B, lbl_B);
            keyValuePairs.Add(Key.N, lbl_N);
            keyValuePairs.Add(Key.M, lbl_M);
            //keyValuePairs.Add(Key.P, lbl_sym6);
            //keyValuePairs.Add(Key.P, lbl_sym7);
            //keyValuePairs.Add(Key.P, lbl_sym8);
        }

        private void Label_KeyDown(object sender, KeyEventArgs e)
        {
            
            isPress = true;
            if (keyValuePairs.ContainsKey(e.Key))
            {
                
                txb1.Text += e.Key.ToString();
                Label lbl = keyValuePairs[e.Key];
                lbl.Background = Brushes.Red;// Brush(Colors.Red);
            }
        }

        private void Label_KeyUp(object sender, KeyEventArgs e)
        {
            isPress = false;
            Label lbl = keyValuePairs[e.Key];
            lbl.Background = Brushes.Gray;
        }

        private void txb1_KeyDown(object sender, KeyEventArgs e)
        {
            isPress = true;
        }
    }
}
