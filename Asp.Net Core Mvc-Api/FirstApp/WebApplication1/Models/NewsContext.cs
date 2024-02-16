using System.Collections.Generic;

namespace FirstApp.Models
{
    public static class NewsContext
    {
        public static List<News> List = new()
        {
            new News { title="New 1" },
            new News { title="New 2" },
        };
    }
}
