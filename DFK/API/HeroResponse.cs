namespace DFK.API
{
    public class HeroResponse
    {
        public class Data
        {
            public Hero hero { get; set; }
        }
        public Data data { get; set; }
    }
}