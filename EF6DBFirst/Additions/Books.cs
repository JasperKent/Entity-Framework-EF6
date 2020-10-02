namespace EF6DBFirst
{
    public partial class Book
    {
        public override string ToString()
        {
            return $"{Title} ({PublicationYear})";
        }
    }
}
