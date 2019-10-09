using System;
using System.Collections.Generic;
using System.Text;

namespace AssetManagment
{
    public class CheckedOutItem
    {
        public string name;
        public string asuriteId;
        public string email;
        public string phoneNumber;
        public string reason;
        public string loandedDate;
        public string adapterName;
        
        public CheckedOutItem(string name, string asuriteId, string email, string phoneNumber, string reason, string loandedDate, string adapterName)
        {
            this.name = name;
            this.asuriteId = asuriteId;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.reason = reason;
            this.loandedDate = loandedDate;
            this.adapterName = adapterName;
        }

        public override string ToString()
        {
            return $"{name},{asuriteId},{email},{phoneNumber},{reason},{loandedDate},{adapterName}";
        }
        
    }

}
