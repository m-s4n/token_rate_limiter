Token Tabanlı bir rate limiter örneği

Bu örnekte belirli zaman dilimi içinde belirli sayıda istemci isteğini kabul edeceğiz

Token tabanlı rate limiter, her geçen zaman diliminde belirli sayıda jeton (token) oluşturur ve her istemci isteği geldiğinde bir jeton kullanır. Eğer jeton kalmamışsa, istek reddedilir.