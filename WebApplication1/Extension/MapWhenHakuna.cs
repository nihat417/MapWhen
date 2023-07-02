namespace WebApplication1.Extension
{
    public class MapWhenHakuna
    {
        private RequestDelegate next;

        public MapWhenHakuna(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("start");
            await next.Invoke(context);
            Console.WriteLine("end");
        }
    }
}
