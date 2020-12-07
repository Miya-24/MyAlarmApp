using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyAlarmApp
{
    public partial class MyAlarmForm : Form
    {
        private readonly NotifyIcon MyNotifyIcon;
        private int TimerValue;
        private string TimeUnit;
        private readonly Timer AlarmTimer;
        private readonly IDictionary<string, int> UnitMap;

        public MyAlarmForm()
        {
            InitializeComponent();
           
            //通知アイコン
            MyNotifyIcon = new NotifyIcon
            {
                Icon = new Icon(SystemIcons.Exclamation, 40, 40),
                Visible = false,
                Text = "MyAlarmApp"
            };
            //通知アイコンのイベントハンドラー
            MyNotifyIcon.Click += new EventHandler(NotifyIcon_Click);

            UnitMap = new Dictionary<string, int>()
            {
                { "Seconds", 1000 },
                { "Minutes", 60000 },
                { "Hours", 3600000 }
            };
            //タイマー
            AlarmTimer = new Timer();
            //タイマーのイベントハンドラー
            AlarmTimer.Tick += new EventHandler(OnTimer_Stop);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //タイマーセット
            AlarmTimer.Interval = TimerValue * UnitMap[TimeUnit];
            //ウィンドウを通知領域へ移動
            this.Visible = false;
            MyNotifyIcon.Visible = true;
            //タイマースタート
            AlarmTimer.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //タイマーストップ
            AlarmTimer.Enabled = false;
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeUnit = TimeComboBox.Text;
        }

        private void TimeValueTextBox_TextChanged(object sender, EventArgs e)
        {
            TimerValue = int.Parse(TimeValueTextBox.Text);
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                //通知領域からタスクバーへ移動
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                MyNotifyIcon.Visible = false;
            }
        }

        private void OnTimer_Stop(object sender, EventArgs e)
        {
            //タイマーストップ
            AlarmTimer.Enabled = false;
            //通知領域からメッセージ
            MyNotifyIcon.BalloonTipTitle = "おしらせ";
            MyNotifyIcon.BalloonTipText = "おしらせのメッセージ";
            MyNotifyIcon.ShowBalloonTip(3000);
        }
    }
}
