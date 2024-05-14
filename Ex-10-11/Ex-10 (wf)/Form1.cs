namespace Ex_10__wf_
{
    public partial class Form1 : Form
    {
        public Subject _subject;
        public Observer1 _observer1;
        public Observer1 _observer2;
        public Observer1 _observer3;
        public Form1()
        {
            InitializeComponent();
            _subject = new Subject();
            _observer1 = new Observer1("Ob1");
            _observer2 = new Observer1("Ob2");
            _observer3 = new Observer1("Ob3");
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            var CheckB = sender as CheckBox;
            switch (CheckB.Text)
            {
                case "Observer 1":
                    if (CheckB.Checked)
                    {
                        _subject.AddObserver(_observer1);
                        LogBox.Text += "_observer1 enabled" + Environment.NewLine;
                        label1.Text = _subject._state;
                    }
                    else
                    {
                        _subject.RemoveObserver(_observer1);
                        LogBox.Text += "_observer1 disabled" + Environment.NewLine;
                        label1.Text = _subject._state;
                    }
                    break;
                case "Observer 2":
                    if (CheckB.Checked)
                    {
                        _subject.AddObserver(_observer2);
                        LogBox.Text += "_observer2 enabled" + Environment.NewLine;
                        label2.Text = _subject._state;
                    }
                    else
                    {
                        _subject.RemoveObserver(_observer2);
                        LogBox.Text += "_observer2 disabled" + Environment.NewLine;
                        label2.Text = _subject._state;
                    }
                    break;
                case "Observer 3":
                    if (CheckB.Checked)
                    {
                        _subject.AddObserver(_observer3);
                        LogBox.Text += "_observer3 enabled" + Environment.NewLine;
                        label3.Text = _subject._state;
                    }
                    else
                    {
                        _subject.RemoveObserver(_observer3);
                        LogBox.Text += "_observer3 disabled" + Environment.NewLine;
                        label3.Text = _subject._state;
                    }
                    break;
            }
        }
        // Activate
        private void button1_Click(object sender, EventArgs e)
        {
            _subject.ChangeState("activate");
            if (_subject._observers.Contains(_observer1)) label1.ForeColor = Color.Green;
            else label1.ForeColor = Color.Red;
            if (_subject._observers.Contains(_observer2)) label2.ForeColor = Color.Green;
            else label2.ForeColor = Color.Red;
            if (_subject._observers.Contains(_observer3)) label3.ForeColor = Color.Green;
            else label3.ForeColor = Color.Red;
            Update();
        }
        // Disactivate
        private void button2_Click(object sender, EventArgs e)
        {
            _subject.ChangeState("disactivate");
            Update();

        }
        // обновляет данные в label'ах
        private void Update()
        {
            foreach (var item in _subject._observers)
            {
                switch (item.Name)
                {
                    case "Ob1":
                        label4.Text = item.Time.ToString() + " ms";
                        label1.Text = _subject._state;
                        break;
                    case "Ob2":
                        label5.Text = item.Time.ToString() + " ms";
                        label2.Text = _subject._state;
                        break;
                    case "Ob3":
                        label6.Text = item.Time.ToString() + " ms";
                        label3.Text = _subject._state;
                        break;

                }
            }
            if (_subject._observers.Contains(_observer1)) label1.ForeColor = Color.Green;
            else label1.ForeColor = Color.Red;
            if (_subject._observers.Contains(_observer2)) label2.ForeColor = Color.Green;
            else label2.ForeColor = Color.Red;
            if (_subject._observers.Contains(_observer3)) label3.ForeColor = Color.Green;
            else label3.ForeColor = Color.Red;
        }
    }
}
