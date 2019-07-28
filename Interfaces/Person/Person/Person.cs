namespace Person.Repository
{
    public class Person
    {
        public string UserId { get; set; }
        public long Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"User Id: {UserId}, Id: {Id}, Title: {Title}, Blog Completed: {(Completed ? "Yes" : "No")}";
        }
    }
}
