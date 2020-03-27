namespace ISP
{
    public interface IAllLaptop
    {
        void openFile();

        void playMusic();  

        void connectWifi();  
    }

    public class NewLaptop : IAllLaptop{
        public void openFile(){
            console.log("File opened");
        }
        public void playMusic(){
            console.log("Play music");
        }
        public void connectWifi(){
            console.log("New Laptop can connect to Wifi");
        }
    }
    public class OldLaptop : IAllLaptop{
        public void openFile(){
            console.log("File opened");
        }
        public void playMusic(){
            console.log("Play music");
        }
        public void connectWifi(){
            throw new NotSupportedException();
        }
    }
}
//violation because all laptops have to implement the method connectWifi, although old laptops can not use that method.

//fix violation
namespace ISP
{
    public interface IOpenFile
    {
        void openFile();
    }

    public interface IOpenFile
    {
        void playMusic();
    }

    public interface IConnectWifi
    {
        void connectWifi();
    }

    public class NewLaptop : IOpenFile, IOpenFile, IConnectWifi {
        public void openFile(){
            console.log("File opened");
        }
        public void playMusic(){
            console.log("Play music");
        }
        public void connectWifi(){
            console.log("New Laptop can connect to Wifi");
        }
    }

    public class OldLaptop : IOpenFile, IOpenFile {
        public void openFile(){
            console.log("File opened");
        }
        public void playMusic(){
            console.log("Play music");
        }
    }
}

