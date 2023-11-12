using MS_SQL_Server;
using(ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    Human human1 = new Human { Name="Ted",Age=40};
    Human human2 = new Human { Name = "Jane", Age=30 };

    db.Humans.AddRange(human1, human2);
    db.SaveChanges();
}

using (ApplicationContext db = new ApplicationContext())
{
    var humans=db.Humans.ToList();
    Console.WriteLine("Human List:");
    foreach(Human h in humans)
        Console.WriteLine($"{h.Id}.{h.Name} - {h.Age}");
}
