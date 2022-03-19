// See https://aka.ms/new-console-template for more information

using OopTestApp;

var promotors = new List<Promotor>()
{
    new XSClubPromotor()
    {
        FirstName = "Luke",
        LastName = "Skywalker",
    },
    new XSClubPromotor()
    {
        FirstName = "Princess",
        LastName = "Leia",
    },
    new OmniaClubPromotor()
    {
        FirstName = "Han",
        LastName = "Solo",
    },
};

var writers = new List<Writer>()
{
    new BookWriter()
    {
        FirstName = "Phil",
        LastName = "Jackson",
        Type = "Book"
    },
    new BookWriter()
    {
        FirstName = "Kobe",
        LastName = "Bryant",
        Type = "Book"
    },
    new BlogWriter()
    {
        FirstName = "Magic",
        LastName = "Johnson",
        Type = "Blog"
    }
};

var bodybuilders = new List<IBodyBuilder>()
{
    new XSClubPromotor()
    {
        FirstName = "Arnold",
        LastName = "Schwarzenegger",
    },
    new XSClubPromotor()
    {
        FirstName = "Rhonda",
        LastName = "Rousey",
    },
};

var vloggers = new List<IVlogger>()
{
    new BookWriter()
    {
        FirstName = "Lewis",
        LastName = "Hamilton",
        Type = "Book"
    },
    new BlogWriter()
    {
        FirstName = "Max",
        LastName = "Verstappen",
        Type = "Blog"
    }
};

foreach (var promotor in promotors)
{
    promotor.Promote();
}
Console.WriteLine();

foreach (var writer in writers)
{
    writer.Write();
}
Console.WriteLine();

foreach (var bodybuilder in bodybuilders)
{
    bodybuilder.Workout();
}
Console.WriteLine();

foreach (var vlogger in vloggers)
{
    vlogger.Vlog();
}
