using UnityEngine;

public class Constants : MonoBehaviour {

    // Unit actions
    public enum UnitAction{
        Move = 0,
        Attack = 1,
        Mine = 2,
        Deactivate = 3
    }
    public static int NUMBER_OF_ACTIONS = 4;
    public static UnitAction IntegerToAction(int i)
    {
        switch (i)
        {
            
            case 1:
                return UnitAction.Attack;
            case 2:
                return UnitAction.Mine;
            case 3:
                return UnitAction.Deactivate;
            default:
                return UnitAction.Move;
        }
    }

    // Target types, for broadcast to selected units by SelectUnits.cs, clicked
    // on by right mouse button
    public enum TargetType
    {
        EnemyUnit = 0,
        MineableZone = 1,
        Structure = 2
    }

    // Tags
    public static string NONPLAYER_UNIT = "NonplayerUnit";
    public static string PLAYER_UNIT = "SelectableUnit";
    public static string SPAWN_AREA = "Spawn";
    public static string MINEABLE_ZONE = "Mineable";

    // Terrain
    public static int TERRAIN_HALF_SIZE = 500;

}
