using PropertiesExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Customer
    {
        int _CustomerID;
        string _CustomerName;
        bool _Status;
        double _Balance;
        Cities _City;
        public Customer(int customerid,string customername, Cities city,bool status,double balance)
        {
            _CustomerID = customerid;
            _CustomerName = customername;
            _Status = status;
            _City = city;
            _Balance = balance;
        }
        public bool Status
        {
            get { return _Status; }
            set
            {
                if (_Status == true)
                {
                    _Status = value;
                }
            }
        }
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                if (_Status == true)
                {
                    _CustomerName = value;
                }
            }
        }
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    _Balance = value;
                }
            }
        }
        public Cities City
        {
            get { return _City; }
            set
            {
                if (_Status == true)
                {
                    _City = value;
                }
            }
        }
    }
}
