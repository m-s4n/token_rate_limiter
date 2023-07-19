using RateLimiter.TokenRateLimiter;

// Saniyede en fazla 10 isteğe izin veren rate limiter oluşturulur
TokenRateLimiter tokenRateLimiter = new(10, TimeSpan.FromSeconds(1));

// 50 istek
for(int i= 0; i< 50; i++)
{
    if(tokenRateLimiter.isAllowRequest())
    {
        Console.WriteLine($"İstek {i} : kabul edildi");
    }
    else
    {
        Console.WriteLine($"İstek {i} : reddedildi");
    }
    Thread.Sleep(50);
}