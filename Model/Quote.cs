namespace MyMotivationBlazorApp.Model
{
    public class Quote
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Problem { get; set; }

        public int PhilosopherId { get; set; }

        public Philosopher Philosopher { get; set; }
    }
}
