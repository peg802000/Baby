using System;
namespace BabyApp
{
    public class Baby
    {
        private int _id;
        private DateTime _babyBirthday;
        private string _babyName;
        private decimal _babyBirthWeight;
        private decimal _babyBirthLength;
        public Baby(DateTime babyBirthday,string babyName,decimal babyBirthWeight, decimal babyBirthLength)
        {
            _babyBirthday = babyBirthday;
            _babyName = babyName;
            _babyBirthLength = babyBirthLength;
            _babyBirthWeight = babyBirthWeight;
        }
        public Baby()
        {
        }
        public DateTime BabyBirthday
        {
            get
            {
                return _babyBirthday;
            }
            set
            {
                _babyBirthday = value;
            }
        }
        public string BabyName
        {
            get
            {
                return _babyName;
            }
            set
            {
                _babyName = value;
            }
        }
        public decimal BabyBirthLength
        {
            get
            {
                return _babyBirthLength;
            }
            set
            {
                _babyBirthLength = value;
            }
        }
        public decimal BabyBirthWeight
        {
            get
            {
                return _babyBirthWeight;
            }
            set
            {
                _babyBirthWeight = value;
            }
        }
    }
}
