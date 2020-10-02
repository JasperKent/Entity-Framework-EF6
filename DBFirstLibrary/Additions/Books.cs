namespace DBFirstLibrary
{
    public partial class Books
    {
        public override string ToString()
        {
            return $"{Title} ({YearOfPublication})";
        }
    }
}
