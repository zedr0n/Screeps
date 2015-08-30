using Bridge;
using Bridge.Html5;
using Screeps.Bridge;

namespace Screeps
{
    public class App
    {
        [Ready]
        public static void Main()
        {
            // Simple alert() to confirm it's working
            //Global.Alert("Success");

            Game game = new Game();

            Creep.Property[] props = {Creep.Property.WORK, Creep.Property.CARRY, Creep.Property.MOVE};
            Creep.Spec spec = new Creep.Spec( props );

            foreach(Spawn spawn in game.spawns)
            {
                spawn.createCreep(spec, "creep1");
            }

            game.spawns["Spawn1"].createCreep(spec, "creep1");
        }
    }
}