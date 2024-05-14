using System.Windows;
using System.Windows.Controls;

namespace Ex_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Subject _subject;
        private Observer1 _observer1;
        private Observer2 _observer2;
        private Observer3 _observer3;

        public MainWindow()
        {
            InitializeComponent();
            _subject = new Subject();
            _observer1 = new Observer1();
            _observer2 = new Observer2();
            _observer3 = new Observer3();
            DataContext = this;
        }
        public string State { get; set; }
        public string Observer1State { get; set; }
        public string Observer2State { get; set; }
        public string Observer3State { get; set; }

        private void ChangeStateButton_Click(object sender, RoutedEventArgs e)
        {
            _subject.ChangeState("New State");
        }

        //private void CheckBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    var checkBox = sender as CheckBox;
        //    switch (checkBox.TabIndex)
        //    {
        //        case O1.TabIndex:
        //                break;
                    
        //    }
        //    if (checkBox == O1)
        //    {
        //        if (checkBox.IsChecked.HasValue)
        //        {
        //            _subject.RegisterObserver(_observer1);
        //            label1.Content += _observer1.Update();
        //        }
        //        else
        //        {
        //            _subject.UnregisterObserver(_observer1);
        //            label1.Content = "Lable";
        //        }
        //    }
        //    else if (checkBox.Content.ToString() == "Observer 2")
        //    {
        //        if (checkBox.IsChecked.Value)
        //        {
        //            _subject.RegisterObserver(_observer3);
        //        }
        //        else
        //        {
        //            _subject.UnregisterObserver(_observer3);
        //        }
        //    }
        //}

        private void O1_Checked(object sender, RoutedEventArgs e)
        {
            if (O1.IsChecked.Value)
            {
                _subject.AddObserver(_observer1);
            }
            else
            {
                _subject.RemoveObserver(_observer1);
            }
        }

        private void O2_Checked(object sender, RoutedEventArgs e)
        {
            

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            if (O2.IsChecked.Value)
            {
                _subject.AddObserver(_observer2);
            }
            else
            {
                _subject.RemoveObserver(_observer2);
            }
        }
    }
}