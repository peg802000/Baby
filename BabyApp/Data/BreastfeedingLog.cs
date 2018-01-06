using System;
namespace BabyApp
{
    public class BreastfeedingLog
    {
        private DateTime _timeStamp;
        private TimeSpan _breastfeedingDuration;
        private string _side;
        private int _id;
        private int _babyId;
        public BreastfeedingLog(TimeSpan breastfeedingDuration,string side, int babyId)
        {
            _side = side;
            _breastfeedingDuration = breastfeedingDuration;
            _timeStamp = DateTime.Now;
            _babyId = babyId;
        }
        public BreastfeedingLog()
        {
        }
        public TimeSpan BreestfeedingDuration
        {
            get
            {
                return _breastfeedingDuration;
            }
            set
            {
                _breastfeedingDuration = value;
           }
        }
        public string Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }
        public DateTime TimeStamp
        {
            get
            {
                return _timeStamp;
            }
            set
            {
                _timeStamp = value;
            }
        }
        public int BabyId
        {
            get
            {
                return _babyId;
            }
            set
            {
                _babyId = value;
            }
        }
    }
}
