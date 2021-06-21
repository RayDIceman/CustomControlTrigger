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

namespace TestCustomControl.Controls
{
    /// <summary>
    /// Выполните шаги 1a или 1b, а затем 2, чтобы использовать этот пользовательский элемент управления в файле XAML.
    ///
    /// Шаг 1a. Использование пользовательского элемента управления в файле XAML, существующем в текущем проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:TestCustomControl.Controls"
    ///
    ///
    /// Шаг 1б. Использование пользовательского элемента управления в файле XAML, существующем в другом проекте.
    /// Добавьте атрибут XmlNamespace в корневой элемент файла разметки, где он 
    /// будет использоваться:
    ///
    ///     xmlns:MyNamespace="clr-namespace:TestCustomControl.Controls;assembly=TestCustomControl.Controls"
    ///
    /// Потребуется также добавить ссылку из проекта, в котором находится файл XAML,
    /// на данный проект и пересобрать во избежание ошибок компиляции:
    ///
    ///     Щелкните правой кнопкой мыши нужный проект в обозревателе решений и выберите
    ///     "Добавить ссылку"->"Проекты"->[Поиск и выбор проекта]
    ///
    ///
    /// Шаг 2)
    /// Теперь можно использовать элемент управления в файле XAML.
    ///
    ///     <MyNamespace:CustomControl/>
    ///
    /// </summary>
    public class CustomControl : Control
    {
        static CustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl), new FrameworkPropertyMetadata(typeof(CustomControl)));
        }



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(CustomControl), new PropertyMetadata(""));



        public string OpeningText
        {
            get { return (string)GetValue(OpeningTextProperty); }
            set { SetValue(OpeningTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OpeningText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OpeningTextProperty =
            DependencyProperty.Register("OpeningText", typeof(string), typeof(CustomControl), new PropertyMetadata(""));



        public string ClosingText
        {
            get { return (string)GetValue(ClosingTextProperty); }
            set { SetValue(ClosingTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClosingText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClosingTextProperty =
            DependencyProperty.Register("ClosingText", typeof(string), typeof(CustomControl), new PropertyMetadata(""));



        public string ArrowData
        {
            get { return (string)GetValue(ArrowDataProperty); }
            set { SetValue(ArrowDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArrowData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrowDataProperty =
            DependencyProperty.Register("ArrowData", typeof(string), typeof(CustomControl), new PropertyMetadata(""));




        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(CustomControl), new PropertyMetadata(false));



        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Command.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(CustomControl), new PropertyMetadata(null));






    }
}
