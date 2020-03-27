namespace LSP
{
    public abstract class Phone {
        public virtual void Call();
        public virtual void ReceiveCall();
        public virtual void SendEmail();
    }
    public class Telephone : Phone{
        public override void SendEmail(){
            // Telephone can't send Email
        }
    }
}
//violation becasuse an override SendEmail() method does nothing because Telephone can't send email.

//fix violation
namespace LSP
{
    public abstract class Phone {
        public virtual void Call();
        public virtual void ReceiveCall();
    }
    public class MobilePhone : Phone{
        public virtual void SendEmail();
    }
}