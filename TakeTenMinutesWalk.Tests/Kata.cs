public class Kata
{
    public static bool IsValidWalk(string[] directions)
    {
        var is10minWalk = directions.Length == 10;
        var northSouthDifference = directions.Count("n") - directions.Count("s");
        var eastWestDifference = directions.Count("e") - directions.Count("w");
        return is10minWalk && northSouthDifference == 0 && eastWestDifference == 0;
    }
}
