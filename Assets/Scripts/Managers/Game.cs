public static class Game
{
    public static Map map;
    public static Objects objects;

    public static void Init()
    {
        objects = new Objects();
    }

    public static void Quit()
    {
        map = null;
        objects = null;
    }
}