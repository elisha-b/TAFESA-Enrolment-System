using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System
{
    internal class Address
    {
        private string streetNum;
        private string streetName;
        private string suburb;
        private string postcode;
        private string state;

        const string DEF_STREET_NUM = "N/A";
        const string DEF_STREET_NAME = "N/A";
        const string DEF_SUBURB = "N/A";
        const string DEF_POSTCODE = "N/A";
        const string DEF_STATE = "N/A";

        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE) { }

        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        public override string ToString()
        {
            return StreetNum + " " + StreetName + " " + Suburb + " " + State + " " + Postcode;
        }
    }
}
