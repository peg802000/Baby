using System;
using System.Timers;
using UIKit;
using SQLite;

namespace BabyApp
{
    public partial class ViewController : UIViewController
    {
        private DateTime start = new DateTime();
        private Timer timer;
        private bool _isRunning;
        private DateTime _pauseStarted;
        private TimeSpan _pausedTime;
        partial void BtRight_TouchUpInside(UIButton sender)
        {
            _isRunning = true;
            BtLeft.Enabled = false;
            BtRight.Enabled = false;
            BtPauCon.Enabled = true;
            BtStop.Enabled = true;
            StartTimer();
        }       
        partial void BtPauCon_TouchUpInside(UIButton sender)
        {
            if(_isRunning==true)
            {   
                _isRunning = false;
                BtPauCon.SetTitle("Continue",UIControlState.Normal);
                timer.Stop();
                _pauseStarted = DateTime.Now;
            }
            else
            {
                _isRunning = true;
                BtPauCon.SetTitle("Pause", UIControlState.Normal);
                timer.Start();
                _pausedTime = DateTime.Now.Subtract(_pauseStarted).Add(_pausedTime);
            }
        }   
        partial void BtStop_TouchUpInside(UIButton sender)
        {
            _isRunning = false;
            BtLeft.Enabled = true;
            BtRight.Enabled = true;
            BtPauCon.Enabled = false;
            BtStop.Enabled = false;
            StopTimer();


            DatabaseHelper dh = new DatabaseHelper();
        }
        partial void BtLeft_TouchUpInside(UIButton sender)
        {
             _isRunning = true;
             BtLeft.Enabled = false;
             BtRight.Enabled = false;
             BtPauCon.Enabled = true;
             BtStop.Enabled = true;
             StartTimer();
        }
      
        protected ViewController(IntPtr handle) : base(handle)
        {

            // Note: this .ctor should not contain any initialization logic.
        }
        private void StopTimer()
        {
            timer.Stop();
            timer.Dispose();

            TimeSpan timeToSave=TimeExtensions.StripMilliseconds(DateTime.Now.Subtract(start).Subtract(_pausedTime));

            DatabaseHelper dh = new DatabaseHelper();
            BreastfeedingLog bl = new BreastfeedingLog(timeToSave, "L",1);
            dh.CreateTable();
            dh.InsertBreastfeedingLog(bl);
            dh.Select();
        }

        private void StartTimer()
        {
            _pausedTime= DateTime.Now.Subtract(DateTime.Now);
            timer = new Timer();
            // 1000= 1 second , the timer will run every second  
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;
            start = DateTime.Now;
            timer.Start();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _isRunning = false;
            this.BtLeft.Layer.CornerRadius = 45;
            this.BtRight.Layer.CornerRadius = 45;
            this.BtLeft.Layer.BorderWidth = 1;
            this.BtRight.Layer.BorderWidth = 1;
            this.BtPauCon.Layer.CornerRadius = 35;
            this.BtStop.Layer.CornerRadius = 35;
            this.BtPauCon.Layer.BorderWidth = 1;
            this.BtStop.Layer.BorderWidth = 1;
            BtPauCon.Enabled = false;
            BtStop.Enabled = false;

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TimeSpan myDate = TimeExtensions.StripMilliseconds(DateTime.Now.Subtract(start).Subtract(_pausedTime));
            InvokeOnMainThread(() =>
            {
                LbTimer.Text = myDate.Minutes.ToString("D2") + ":" + myDate.Seconds.ToString("D2");
            });
        }
       

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }


}
