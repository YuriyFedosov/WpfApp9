using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp9
{
    internal class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedCommand Bold { get; set; }
        public static RoutedCommand Italic { get; set; }
        public static RoutedCommand Underline { get; set; }

        static MyCommands()
        {
            InputGestureCollection boldInput = new InputGestureCollection
            {
                new KeyGesture(Key.B, ModifierKeys.Control)
            };
            InputGestureCollection italicInput = new InputGestureCollection
            {
                new KeyGesture(Key.I, ModifierKeys.Control)
            };
            InputGestureCollection underlineInput = new InputGestureCollection
            {
                new KeyGesture(Key.U, ModifierKeys.Control)
            };
            Exit = new RoutedUICommand("Выход",
                                       "Exit",
                                       typeof(MyCommands));
            Bold = new RoutedCommand("Bold",
                                     typeof(MyCommands),
                                     boldInput);
            Italic = new RoutedCommand("Italic",
                                       typeof(MyCommands),
                                       italicInput);
            Underline = new RoutedCommand("Underline", typeof(MyCommands), underlineInput);
        }
    }
}
