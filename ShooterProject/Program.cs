using ShooterProject.Models;

namespace ShooterProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShooterManager shooterManager = new ShooterManager();
            shooterManager.Menu();
        }
    }
}