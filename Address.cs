﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Address
    {  //all this attribute are privet
        private string roadNo, houseNo, city, country;

        public Address(string roadNo, string houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;

        }

        public string RoadNo  //property
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }

        }
        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }

        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }

        }

        public string Country
        {
            set { this.country = value; }
            get { return this.country; }

        }
        public string GetAddress()
        {
            return this.roadNo + "," + this.houseNo + "," + this.city + "," + this.country;

        }


    }




}
