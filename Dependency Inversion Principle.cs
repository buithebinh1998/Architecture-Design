namespace DIP 
{
    public class Developer 
    {
        private int fullTask;
        private int remainingTask;
        private int happiness;
        public Developer(int fullTask)
        {
            this.fullTask = fullTask;
            remainingTask = fullTask;
        }

        public void Working(){
            happiness++;
            remainingTask--;
        }
    }

    public class Team 
    {   
        private Developer position;
        public Team() {
            this.position = new Developer(100);
        }
        public void taskSpeedUp(){
            position.Working();
        }
    }
}
//violation bacause when changing to a new position like DevOps, QC, PO..., we need to change the Team implementation

//fix violation
namespace DIP 
{
    public interface Position
    {
        void Working();
    }
    public class Developer: Position
    {
        private int fullTask;
        private int remainingTask;
        private int happiness;
        public Developer(int fullTask)
        {
            this.fullTask = fullTask;
            remainingTask = fullTask;
        }
        public override void Working(){
            happiness++;
            remainingTask--;
        }
    }

    public class Team 
    {   
        private Position position;
        public Team(Position position) {
            this.position = position;
        }
        public void taskSpeedUp(){
            postion.Working();
        }
    }
}