using RoleplayGame.Items;
using RoleplayGame.Characters;
using RoleplayGame.Encounters;
using RoleplayGame.Scenarios;
using Program;
using NUnit.Framework;

namespace LibraryTest;
[TestFixture]
public class ScenarioTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Scenario()
    {
        //Configuración
        Elf p1 = new Elf("Jerald");
        // Crear items que se le agregan
        LongSword  espadaLarga = new LongSword(); 
        p1.AddItem(espadaLarga);
        Wizard p2  = new Wizard("Gandalf");
        Robes  tunica = new Robes(); 
        p2.AddItem(tunica);
        Troll p3 = new Troll("Glad");

        //Ahora los encuentros
        AttackEncounter encuentro1 = new AttackEncounter(p1, p2);
        encuentro1.Reporter =  new ConsoleReporter();
        encuentro1.DoEncounter();
        bool p1IsDead = false;
        bool p2IsDead = false;
        Character winnerEncounter1;
        p1IsDead = p1.IsDead;
        p2IsDead = p2.IsDead;
        // El mago tiene una fuerza de ataque mayor, por ende gana el mago
         if(p1IsDead)
        {
            winnerEncounter1 = p2;
        }
        else
        {
            winnerEncounter1 = p1;
        }
        // Restauramos la vida al ganador
        winnerEncounter1.RestoreHealth();
        // Como el ganador es el mago, y tiene una vida menor al Troll, teniendo este la coraza a su favor, gana el Troll, entonces el mago muere
        AttackEncounter encuentro2 = new AttackEncounter(winnerEncounter1, p3);
        encuentro2.Reporter =  new ConsoleReporter();
        encuentro2.DoEncounter();

        // Lo esperado sería que muriera el p2
        Assert.IsTrue(winnerEncounter1.IsDead);


        
    }
}