using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ticketopia.Attributes
{
    public class YearRange : ValidationAttribute
    {
        private readonly int _minYear;
        private readonly int _maxYear;

        public YearRange(int minYear, int maxYear)
        {
            _minYear = minYear;
            _maxYear = maxYear;
        }

        public override bool IsValid(object value)
        {
            if (value is DateTime dateTime)
            {
                if(dateTime.Year>= _minYear && dateTime.Year<= _maxYear)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
