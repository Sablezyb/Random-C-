using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_new_version
{
    public partial class Form1 : Form
    {
        private bool _isBogus = false;
        private int _numberStart, _numberEnd;
        private Random rnd = new Random();

        private TimeSpan _timeStart, _timeEnd;
        private int _duration = 2;

        private TwoWindow _twoWindow;
        private bool _isTwoWindow = false;
        public Form1()
        {
            InitializeComponent();

            tb_Number.Visible = _isBogus;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            
            if (_isBogus)
            {
                int rezult;
                if (!int.TryParse(tb_Number.Text, out rezult))
                {
                    ShowError("Вы ввели не число в ПЧ", "ПЧ");
                    return;
                }
            }
            
            if (!(int.TryParse(tb_NumberStart.Text, out _numberStart) && 
                int.TryParse(tb_NumberEnd.Text, out _numberEnd)))
            {
                ShowError("Вы ввели не число", "Ошибка");
                return;
            }

            _timeStart = DateTime.Now.TimeOfDay;
            _timeEnd = _timeStart.Add(new TimeSpan(0, 0, _duration));

            timer1.Start();
        }

        private void ShowError(string textError, string textCaption)
        {
            MessageBox.Show(textError, textCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void menu_Enabled_Click(object sender, EventArgs e)
        {
            _isBogus = true;
            tb_Number.Visible = true;
        }

        private void cb_TwoScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length <= 1)
            {
                _isTwoWindow = false;
                cb_TwoScreen.Checked = false;
                ShowError("Нету второго экрана", "Экран");
                return;
            }

            if (_isTwoWindow)
            {
                _isTwoWindow = false;
                if (_twoWindow != null)
                {
                    _twoWindow.Close();
                    _twoWindow = null;
                }
            }
            else
            {
                _isTwoWindow = true;
                _twoWindow = new TwoWindow();
                _twoWindow.Show();
                _twoWindow.Bounds = Screen.AllScreens[1].Bounds;
                _twoWindow.WindowState = FormWindowState.Maximized;
                _twoWindow.FormBorderStyle = FormBorderStyle.None;
            }
            
            
        }

        private void menu_Disabled_Click(object sender, EventArgs e)
        {
            _isBogus = false;
            tb_Number.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan nowTimeSec = DateTime.Now.TimeOfDay;

            if (_isBogus)
            {
                if (nowTimeSec >= _timeEnd)
                {
                    lb_Number.Text = tb_Number.Text;
                    timer1.Stop();
                    return;
                }
            }
            else
            {
                if (nowTimeSec >= _timeEnd)
                {
                    timer1.Stop();
                    return;
                }
            }


            int newNumber = rnd.Next(_numberStart, _numberEnd);
            lb_Number.Text = newNumber + "";

            
        }
    }
}
