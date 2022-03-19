namespace OopTestApp
{
    internal abstract class Promotor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string MyBusinessCard { get; set; }
        public string Type { get; set; }

        public void Promote()
        {
            ShareWithInnerCircle();
            UsePaidAds();
        }

        protected abstract void UsePaidAds();

        protected abstract void ShareWithInnerCircle();
    }
}
