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
using MessageBox = System.Windows.MessageBox;

namespace EquationProgram
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Переменные

        /// <summary>
        /// Степень числа X
        /// </summary>
        int x_Pow;

        /// <summary>
        /// Степень числа Y
        /// </summary>
        int y_Pow;

        /// <summary>
        /// Число С в зависмости от выбранной функции в ComboBox и выбранного значения
        /// </summary>
        double Const_c;

        /// <summary>
        /// Значение функции 
        /// </summary>
        double F_xy;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Вычисление опреденных чисел C и запись их 
        /// в ComboBox в зависимсоти от выбранной функции
        /// </summary>
        /// <param name="istart">Стартовое число i для массива</param>
        /// <param name="istep"> Шаг по числу i для массива</param>
        /// <param name="ifinish">Конечное число i для массива</param>
        /// <param name="x_Pow">Степень числа X</param>
        /// <param name="y_Pow">Степень числа Y</param>
        /// <returns></returns>
        public int ComboboxChange(int istart, int istep, int ifinish, int x_Pow, out int y_Pow)
        {
            C_ComboBox.Items.Clear();
            for (int i = istart; i <= ifinish; i += istep)
            {
                C_ComboBox.Items.Add(i);
            }
            return y_Pow = x_Pow - 1;
        }
        /// <summary>
        /// Ввод опреденных чисел С в ComboBox в зависимости от выбранного элемента из списка ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FunctionList_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (ComboBox_Function1.IsSelected)
            {
                ComboboxChange(1, 1, 5, 1, out y_Pow);
                
            }
            else if (ComboBox_Function2.IsSelected)
            {
                 ComboboxChange(10, 10, 50, 2, out y_Pow);
            }

            else if (ComboBox_Function3.IsSelected)
            {
                C_ComboBox.Items.Clear();
                ComboboxChange(100, 100, 500, 3, out y_Pow);
            }
            else if (ComboBox_Function4.IsSelected)
            {
                C_ComboBox.Items.Clear();
                ComboboxChange(1000, 1000, 5000, 4, out y_Pow);
            }
            else if (ComboBox_Function5.IsSelected)
            {
                C_ComboBox.Items.Clear();
                ComboboxChange(10000, 10000, 50000, 5, out y_Pow);
            }
        }
       
        /// <summary>
       /// Расчет функции. Если данные из ComboBox не выбраны,
       /// то значения установятся по умолчанию. Запись в DataGrid
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FunctionList_ComboBox.SelectedItem == null || C_ComboBox.SelectedItem == null)
            {
                string Type_of_Function = FunctionList_ComboBox.Items[FunctionList_ComboBox.SelectedIndex = 0].ToString();

                string Type_of_C = C_ComboBox.Items[C_ComboBox.SelectedIndex = 0].ToString();
                MessageBox.Show("Вы ввели не все данные." + '\n' + "Предложены значения по умолчанию:" + '\n' + "Тип функции " + Type_of_Function + '\n' + "Значение параметра c = " + Type_of_C);
            }

            string s = C_ComboBox.Items[C_ComboBox.SelectedIndex].ToString();
            Const_c = Convert.ToDouble(s);

            Equations Equation = new Equations(Convert.ToDouble(textBox_x.Text), Convert.ToDouble(textBox_y.Text), Convert.ToDouble(textBox_a.Text), Convert.ToDouble(textBox_b.Text), Const_c);
            F_xy = Equation.FunctionXY(x_Pow, y_Pow);

            Rezult rezult = new Rezult(Convert.ToString(F_xy), Convert.ToString(Equation.Y), Convert.ToString(Equation.X));
            dataGrid_Rezult.Items.Add(rezult);
        }
        /// <summary>
        /// Запрет на ввод "." и алфавита
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TextCancel (object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!char.IsDigit(e.Text, 0) && (e.Text != ","))
            {
                { e.Handled = true; }
            }
            else if ((e.Text == ",") && ((textBox.Text.IndexOf(",") != -1) || (textBox.Text == "")))
            {
                e.Handled = true;
            }
        }
        private void TextBox_x_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextCancel(sender, e);
           
        }
        private void TextBox_a_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextCancel(sender, e);
        }
        private void TextBox_b_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextCancel(sender, e);
        }
        private void TextBox_y_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextCancel(sender, e);
        }
    }
}

