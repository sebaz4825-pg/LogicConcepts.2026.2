using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    internal class HourLyEmployee : Employee

    {
        // Fields
        private decimal _hourValue;
        private float _woekingHours;

        // Constructor
        public HourLyEmployee(nt id, string firsName, string lastName, Date bornDate, Date hireDate, bool isActive, decimal salary)
        : base(id, firsName, lastName, bornDate, hireDate, isActive)
        {

            _hourValue = _hourValue

        }
        // Properties

        public float CommissionPercentage
        {
            get => _hourValue;
            set => _hourValue = ValidateCommissionPercentage(value);
        }

        public decimal Sales
        {
            get => _sales;
            set => _sales = ValidateSales(value);

        }
        // Public Methods


        public override decimal GetValueToPay()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{base.ToString}\n\t" +
                $"Born date.....:   {BornDate,20}\n\t" +
                $"Hire date.....:   {HireDate,20}\n\t" +
                $"Salary........:   {GetValueToPay(),20:c2}";
        // Private Methods

        private decimal ValidateHourValue(decimal hourValue)
        {

        }
    }
}
