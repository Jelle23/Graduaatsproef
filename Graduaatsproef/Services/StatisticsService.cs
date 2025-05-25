public class StatisticsService
{
    private readonly List<Statistic> statistics = new()
    {
        new Statistic { Title = "Aantal assets", Value = 120 },
        new Statistic { Title = "Aantal gateways", Value = 45 },
        new Statistic { Title = "Aantal asset types", Value = 6 },
        new Statistic { Title = "Aantal gateway types", Value = 4 },
        new Statistic { Title = "Aantal companies", Value = 8 },
        new Statistic { Title = "Aantal users", Value = 22 },
        new Statistic { Title = "Aantal projecten", Value = 14 },
        new Statistic { Title = "Aantal measurements per dag", Value = 0 },
        new Statistic { Title = "Aantal events per dag", Value = 57 },
        new Statistic { Title = "Aantal application logs in de tabel", Value = 134 }
    };

    public Task<List<Statistic>> GetStatisticsAsync()
    {
        return Task.FromResult(statistics);
    }

    public class Statistic
    {
        public string Title { get; set; }
        public int Value { get; set; }
    }
}
