
namespace RateLimiter.TokenRateLimiter
{
    public class TokenRateLimiter
    {
        private readonly int _limit;
        private readonly TimeSpan _interval;
        private int _tokens;
        private DateTime _lastRequestTime;

        public TokenRateLimiter(int limit, TimeSpan interval)
        {
            _limit = limit;
            _interval = interval;
            _tokens = limit;
            _lastRequestTime = DateTime.Now;
        }

        public bool isAllowRequest()
        {
            DateTime currentTime = DateTime.Now;

            // Tokenlar yenilenir
            if(currentTime - _lastRequestTime > _interval)
            {
                _tokens = _limit;
                _lastRequestTime = currentTime;
            }

            // token varsa isteği kabul et
            if(_tokens > 0)
            {
                _tokens --;
                return true;
            }

            // token yoksa isteği reddet
            return false;
        }
    }


}