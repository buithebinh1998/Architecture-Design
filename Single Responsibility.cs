namespace  SRP
{
    public class Bill {
        public string bill_id {get;set;}
        public int bill_price {get;set;}
    }

    public class createBill {
        public bool createBill(Bill b){
            console.log("Bill created");
            return true;
        }

        public void printBill(Bill b){
            console.log("Bill printed");
        }
    
    }
   
}
//violation because class createBill should only has one responsibility for createBill, not printBill.

//fix violation:
namespace  SRP
{
    public class Bill {
        public string bill_id {get;set;}
        public int bill_price {get;set;}
    }

    public class createBill {
        public bool createBill(Bill b){
            console.log("Bill created");
            return true;
        }
    }

    public class printBill {
        public void printBill(Bill b){
            console.log("Bill printed");
        }
    }
}