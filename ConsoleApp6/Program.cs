namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Member member1 = new Member("Bob Bean", 19, true);
            Member member2 = new Member("PETŐFI SÁNDOR", 193, true);
            Member member3 = new Member("Rory Nite", 60, false);
            member1.CheckIn();
            member1.CheckIn();
            member1.CheckIn();
            member1.CheckIn();
            member1.CheckIn();
            member1.CheckIn();
            member2.CheckIn();
            member2.CheckIn();
            member2.CheckIn();
            member2.CheckIn();
            member3.CheckIn();
            member3.CheckIn();
            member3.CheckIn();
            Console.WriteLine(member1.Describe());
            Console.WriteLine(member2.Describe());
            Console.WriteLine(member3.Describe());
            Membership ship1 = new Membership(member1, 50, 3);
            Membership ship2 = new Membership(member2, 66, 6);
            Console.WriteLine($"Total cost for {ship1.Owner.Describe()} is {ship1.TotalCost()}");
            Console.WriteLine($"Total cost for {ship2.Owner.Describe()} is {ship2.TotalCost()}");
            ship1.Extend(5);
            Console.WriteLine($"Total cost for {ship1.Owner.Describe()} is {ship1.TotalCost()}");
            Console.WriteLine($"Total cost for {ship2.Owner.Describe()} is {ship2.TotalCost()}");
            Console.WriteLine($"Price / Visit for {ship1.Owner.Describe()} is {ship1.PricePerVisit()}");
            Console.WriteLine($"Price / Visit for {ship2.Owner.Describe()} is {ship2.PricePerVisit()}");

        }
    }
}
