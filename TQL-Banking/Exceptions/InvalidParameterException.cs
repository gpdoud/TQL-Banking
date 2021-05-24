using System;
using System.Collections.Generic;
using System.Text;

namespace TQL_Banking.Exceptions {
    
    public class InvalidParameterException : Exception {

        public decimal Amount { get; set; }

        public InvalidParameterException(decimal Amount) : base() {
            this.Amount = Amount;
        }
        public InvalidParameterException() : base() {
        }
        public InvalidParameterException(string Message) : base(Message) {
        }
        public InvalidParameterException(string Message, Exception InnerException) 
            : base(Message, InnerException) {

        }
    }
}
