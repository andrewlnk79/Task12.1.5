using Task12._1._5;
class Program
{
    public static IAdwersting? Adwersting { get; set; }

    static void Main()
    {
        Adwersting = new Adwersting();


        var user1 = new User("Alex", true);
        var user2 = new User("Tom", false);
        var zone1 = new LoginZone(Adwersting, user1);
        var zone2 = new LoginZone(Adwersting, user2);
        zone1.ShowAdws();
        zone2.ShowAdws();
        Console.ReadLine();
    }
}