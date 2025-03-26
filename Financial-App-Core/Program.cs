using Financial_App_Core.Data;
using Financial_App_Core.Models;
using Kendo.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);
builder.Services.AddKendo(x =>
{
    x.DeferToScriptFiles = true;
});

builder.Services.AddDbContext<FinancialDbContext>(options =>
    options.UseSqlite("Data Source=financial.db"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<FinancialDbContext>();
    db.Database.EnsureCreated();
    SeedDatabase(db);
}

void SeedDatabase(FinancialDbContext db)
{
    if (!db.Transactions.Any())
    {
        db.Transactions.AddRange(new List<TransactionModel>
        {
            new() { Date = new DateTime(2025, 1, 1), Merchant = "Starbucks", Amount = 15.00M, Category = "Food and Beverages", PayMethod = "Debit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 2), Merchant = "Amazon", Amount = 1500.00M, Category = "Shopping", PayMethod = "Credit Card", Status = TransactionStatus.Postponed },
            new() { Date = new DateTime(2025, 1, 3), Merchant = "Sephora", Amount = 200.00M, Category = "Shopping", PayMethod = "Bank Transfer", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 4), Merchant = "Qatar Airways", Amount = 1000.00M, Category = "Travel", PayMethod = "Credit Card", Status = TransactionStatus.Postponed },
            new() { Date = new DateTime(2025, 1, 6), Merchant = "Apple Store", Amount = 2699.00M, Category = "Shopping", PayMethod = "Credit Card", Status = TransactionStatus.Pending },
            new() { Date = new DateTime(2025, 1, 7), Merchant = "Lidl", Amount = 294.82M, Category = "Groceries", PayMethod = "Bank Transfer", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 8), Merchant = "Fitness", Amount = 1000.00M, Category = "Wellness", PayMethod = "Bank Transfer", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 9), Merchant = "Hermes", Amount = 1000.00M, Category = "Shopping", PayMethod = "Bank Transfer", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 10), Merchant = "Tesla", Amount = 5000.00M, Category = "Investments", PayMethod = "Credit Card", Status = TransactionStatus.Postponed },
            new() { Date = new DateTime(2025, 1, 10), Merchant = "Uber", Amount = 40.00M, Category = "Transport", PayMethod = "Credit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 11), Merchant = "McDonald's", Amount = 20.00M, Category = "Food and Beverages", PayMethod = "Debit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 12), Merchant = "Netflix", Amount = 15.99M, Category = "Entertainment", PayMethod = "Credit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 13), Merchant = "Spotify", Amount = 9.99M, Category = "Entertainment", PayMethod = "Credit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 14), Merchant = "Zara", Amount = 150.00M, Category = "Shopping", PayMethod = "Debit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 15), Merchant = "Domino's Pizza", Amount = 25.50M, Category = "Food and Beverages", PayMethod = "Bank Transfer", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 16), Merchant = "Shell", Amount = 60.00M, Category = "Transport", PayMethod = "Credit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 17), Merchant = "Nike", Amount = 300.00M, Category = "Shopping", PayMethod = "Debit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 18), Merchant = "Walmart", Amount = 120.00M, Category = "Groceries", PayMethod = "Credit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 19), Merchant = "UberEats", Amount = 45.00M, Category = "Food and Beverages", PayMethod = "Bank Transfer", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 20), Merchant = "Best Buy", Amount = 999.99M, Category = "Electronics", PayMethod = "Credit Card", Status = TransactionStatus.Pending },
            new() { Date = new DateTime(2025, 1, 21), Merchant = "Expedia", Amount = 800.00M, Category = "Travel", PayMethod = "Credit Card", Status = TransactionStatus.Postponed },
            new() { Date = new DateTime(2025, 1, 22), Merchant = "Samsung Store", Amount = 1299.00M, Category = "Electronics", PayMethod = "Debit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 23), Merchant = "Booking.com", Amount = 600.00M, Category = "Travel", PayMethod = "Bank Transfer", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 24), Merchant = "IKEA", Amount = 750.00M, Category = "Home & Living", PayMethod = "Credit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 25), Merchant = "Disney+", Amount = 7.99M, Category = "Entertainment", PayMethod = "Credit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 26), Merchant = "eBay", Amount = 100.00M, Category = "Shopping", PayMethod = "Debit Card", Status = TransactionStatus.Pending },
            new() { Date = new DateTime(2025, 1, 27), Merchant = "H&M", Amount = 180.00M, Category = "Shopping", PayMethod = "Credit Card", Status = TransactionStatus.Published },
            new() { Date = new DateTime(2025, 1, 28), Merchant = "KFC", Amount = 19.99M, Category = "Food and Beverages", PayMethod = "Bank Transfer", Status = TransactionStatus.Published }
        });
    }

    if (!db.Cashflows.Any())
    {
        var random = new Random();
        var months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
            .Where(m => !string.IsNullOrEmpty(m)).ToList();

        db.Cashflows.AddRange(months.Select(month => new CashflowModel
        {
            Month = month,
            Stocks = random.Next(10000, 50000),
            RealEstate = random.Next(10000, 50000),
            Bonds = random.Next(10000, 50000)
        }));
    }

    if (!db.StockData.Any())
    {
        var stockData = new List<StockDataPoint>();
        var random = new Random();
        var startDate = new DateTime(2015, 1, 1);
        var endDate = new DateTime(2025, 12, 31);
        decimal open = 150;

        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                continue;

            decimal high = open + (decimal)(random.NextDouble() * 10);
            decimal low = open - (decimal)(random.NextDouble() * 10);
            if (low < 0) low = 0;
            decimal close = low + (decimal)(random.NextDouble() * (double)(high - low));
            long volume = random.Next(1000000, 8000000);

            stockData.Add(new StockDataPoint
            {
                Date = date,
                Open = Math.Round(open, 2),
                High = Math.Round(high, 2),
                Low = Math.Round(low, 2),
                Close = Math.Round(close, 2),
                Volume = volume,
                Symbol = "BA"
            });

            open = close;
        }

        db.StockData.AddRange(stockData);
    }

    db.SaveChanges();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseMiddleware<KendoDeferredScriptsMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();