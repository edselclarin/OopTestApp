namespace OopTestApp
{
    internal abstract class Writer : IVlogger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AuthorBio { get; set; }
        public string Type { get; set; }

        public abstract void Vlog();

        public abstract void Write();
    }
}
